using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using NetworkedExamEngine.Helpers;
using NetworkedExamEngine.Models;

namespace NetworkedExamEngine.Data
{
    public static class DatabaseHelper
    {
        private static string _customConnectionString = null;

        public static string ConnectionString
        {
            get
            {
                if (!string.IsNullOrEmpty(_customConnectionString))
                    return _customConnectionString;

                var connSetting = ConfigurationManager.ConnectionStrings["ExamEngineDB"];
                if (connSetting != null && !string.IsNullOrEmpty(connSetting.ConnectionString))
                    return connSetting.ConnectionString;

                return "Data Source=.;Initial Catalog=ExamEngineDB;User Id=sa;Password=your_password;TrustServerCertificate=True;";
            }
            set
            {
                _customConnectionString = value;
            }
        }

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        public static bool TestConnection(string connStr, out string errorMessage)
        {
            errorMessage = string.Empty;
            try
            {
                using (var conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    using (var cmd = new SqlCommand("SELECT 1", conn))
                    {
                        cmd.ExecuteScalar();
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }

        public static void SaveConnectionStringToConfig(string newConnectionString)
        {
            try
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                if (config.ConnectionStrings.ConnectionStrings["ExamEngineDB"] != null)
                {
                    config.ConnectionStrings.ConnectionStrings["ExamEngineDB"].ConnectionString = newConnectionString;
                }
                else
                {
                    config.ConnectionStrings.ConnectionStrings.Add(new ConnectionStringSettings("ExamEngineDB", newConnectionString, "System.Data.SqlClient"));
                }
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("connectionStrings");
                _customConnectionString = newConnectionString;
            }
            catch
            {
                // In case of permission limitation, retain in memory
                _customConnectionString = newConnectionString;
            }
        }

        public static DataTable ExecuteQuery(string query, params SqlParameter[] parameters)
        {
            var dt = new DataTable();
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                if (parameters != null && parameters.Length > 0)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                using (var da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }

        public static int ExecuteNonQuery(string query, params SqlParameter[] parameters)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                if (parameters != null && parameters.Length > 0)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public static object ExecuteScalar(string query, params SqlParameter[] parameters)
        {
            using (var conn = GetConnection())
            using (var cmd = new SqlCommand(query, conn))
            {
                if (parameters != null && parameters.Length > 0)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                conn.Open();
                return cmd.ExecuteScalar();
            }
        }

        // ==========================================
        // USER AUTHENTICATION & MANAGEMENT
        // ==========================================

        public static bool AuthenticateUser(string username, string password, out User user, out string message)
        {
            user = null;
            message = string.Empty;

            try
            {
                string sql = "SELECT * FROM Users WHERE Username = @Username";
                var dt = ExecuteQuery(sql, new SqlParameter("@Username", username.Trim()));

                if (dt.Rows.Count == 0)
                {
                    message = "Invalid username or password.";
                    return false;
                }

                var row = dt.Rows[0];
                string storedHash = row["PasswordHash"].ToString();
                bool isActive = Convert.ToBoolean(row["IsActive"]);

                if (!isActive)
                {
                    message = "Your account has been deactivated. Please contact the administrator.";
                    return false;
                }

                if (!PasswordHelper.VerifyPassword(password, storedHash))
                {
                    message = "Invalid username or password.";
                    return false;
                }

                user = MapUser(row);
                return true;
            }
            catch (Exception ex)
            {
                message = "Database connection error: " + ex.Message;
                return false;
            }
        }

        public static bool RegisterStudent(User student, string plainPassword, out string message)
        {
            message = string.Empty;
            try
            {
                // Check if username or email or roll no exists
                string checkSql = "SELECT COUNT(*) FROM Users WHERE Username = @Username OR Email = @Email OR RollNo = @RollNo";
                int count = Convert.ToInt32(ExecuteScalar(checkSql,
                    new SqlParameter("@Username", student.Username.Trim()),
                    new SqlParameter("@Email", student.Email.Trim()),
                    new SqlParameter("@RollNo", student.RollNo.Trim())));

                if (count > 0)
                {
                    message = "Username, Email, or Roll Number is already registered.";
                    return false;
                }

                string hash = PasswordHelper.HashPassword(plainPassword);
                string insertSql = @"INSERT INTO Users (Username, PasswordHash, FullName, Email, Role, RollNo, Phone, IsActive, CreatedAt)
                                     VALUES (@Username, @PasswordHash, @FullName, @Email, 'Student', @RollNo, @Phone, 1, GETDATE())";

                ExecuteNonQuery(insertSql,
                    new SqlParameter("@Username", student.Username.Trim()),
                    new SqlParameter("@PasswordHash", hash),
                    new SqlParameter("@FullName", student.FullName.Trim()),
                    new SqlParameter("@Email", student.Email.Trim()),
                    new SqlParameter("@RollNo", student.RollNo.Trim()),
                    new SqlParameter("@Phone", (object)student.Phone?.Trim() ?? DBNull.Value));

                return true;
            }
            catch (Exception ex)
            {
                message = "Registration failed: " + ex.Message;
                return false;
            }
        }

        public static List<User> GetAllStudents()
        {
            var list = new List<User>();
            string sql = "SELECT * FROM Users WHERE Role = 'Student' ORDER BY FullName ASC";
            var dt = ExecuteQuery(sql);
            foreach (DataRow row in dt.Rows)
            {
                list.Add(MapUser(row));
            }
            return list;
        }

        public static User GetUserById(int userId)
        {
            string sql = "SELECT * FROM Users WHERE UserId = @UserId";
            var dt = ExecuteQuery(sql, new SqlParameter("@UserId", userId));
            if (dt.Rows.Count > 0)
                return MapUser(dt.Rows[0]);
            return null;
        }

        public static bool UpdateStudent(User student, out string message)
        {
            message = string.Empty;
            try
            {
                string sql = @"UPDATE Users 
                               SET FullName = @FullName, 
                                   Email = @Email, 
                                   RollNo = @RollNo, 
                                   Phone = @Phone, 
                                   IsActive = @IsActive 
                               WHERE UserId = @UserId";

                ExecuteNonQuery(sql,
                    new SqlParameter("@FullName", student.FullName.Trim()),
                    new SqlParameter("@Email", student.Email.Trim()),
                    new SqlParameter("@RollNo", student.RollNo.Trim()),
                    new SqlParameter("@Phone", (object)student.Phone?.Trim() ?? DBNull.Value),
                    new SqlParameter("@IsActive", student.IsActive),
                    new SqlParameter("@UserId", student.UserId));

                return true;
            }
            catch (Exception ex)
            {
                message = "Update failed: " + ex.Message;
                return false;
            }
        }

        public static bool ResetStudentPassword(int userId, string newPassword, out string message)
        {
            message = string.Empty;
            try
            {
                string hash = PasswordHelper.HashPassword(newPassword);
                string sql = "UPDATE Users SET PasswordHash = @PasswordHash WHERE UserId = @UserId";
                ExecuteNonQuery(sql,
                    new SqlParameter("@PasswordHash", hash),
                    new SqlParameter("@UserId", userId));
                return true;
            }
            catch (Exception ex)
            {
                message = "Password reset failed: " + ex.Message;
                return false;
            }
        }

        public static bool DeleteStudent(int userId, out string message)
        {
            message = string.Empty;
            try
            {
                string sql = "DELETE FROM Users WHERE UserId = @UserId AND Role = 'Student'";
                ExecuteNonQuery(sql, new SqlParameter("@UserId", userId));
                return true;
            }
            catch (Exception ex)
            {
                message = "Delete failed: " + ex.Message;
                return false;
            }
        }

        private static User MapUser(DataRow row)
        {
            return new User
            {
                UserId = Convert.ToInt32(row["UserId"]),
                Username = row["Username"].ToString(),
                PasswordHash = row["PasswordHash"].ToString(),
                FullName = row["FullName"].ToString(),
                Email = row["Email"].ToString(),
                Role = row["Role"].ToString(),
                RollNo = row["RollNo"] != DBNull.Value ? row["RollNo"].ToString() : string.Empty,
                Phone = row["Phone"] != DBNull.Value ? row["Phone"].ToString() : string.Empty,
                IsActive = Convert.ToBoolean(row["IsActive"]),
                CreatedAt = Convert.ToDateTime(row["CreatedAt"])
            };
        }

        // ==========================================
        // EXAMS CRUD
        // ==========================================

        public static List<Exam> GetAllExams(bool activeOnly = false)
        {
            var list = new List<Exam>();
            string sql = @"SELECT e.*, 
                                  (SELECT COUNT(*) FROM Questions q WHERE q.ExamId = e.ExamId) AS ActualQuestionCount
                           FROM Exams e " +
                           (activeOnly ? "WHERE e.IsActive = 1 " : "") +
                           "ORDER BY e.ExamId DESC";

            var dt = ExecuteQuery(sql);
            foreach (DataRow row in dt.Rows)
            {
                var exam = MapExam(row);
                exam.ActualQuestionCount = Convert.ToInt32(row["ActualQuestionCount"]);
                list.Add(exam);
            }
            return list;
        }

        public static List<Exam> GetExamsForStudent(int studentId)
        {
            var list = new List<Exam>();
            string sql = @"SELECT e.*, 
                                  (SELECT COUNT(*) FROM Questions q WHERE q.ExamId = e.ExamId) AS ActualQuestionCount,
                                  ea.AttemptId, ea.Score, ea.Percentage, ea.IsPassed
                           FROM Exams e
                           LEFT JOIN ExamAttempts ea ON e.ExamId = ea.ExamId AND ea.StudentId = @StudentId
                           WHERE e.IsActive = 1
                           ORDER BY e.ExamId DESC";

            var dt = ExecuteQuery(sql, new SqlParameter("@StudentId", studentId));
            foreach (DataRow row in dt.Rows)
            {
                var exam = MapExam(row);
                exam.ActualQuestionCount = Convert.ToInt32(row["ActualQuestionCount"]);

                if (row["AttemptId"] != DBNull.Value)
                {
                    exam.IsAttemptedByStudent = true;
                    exam.ExistingAttemptId = Convert.ToInt32(row["AttemptId"]);
                    exam.ExistingScore = Convert.ToDecimal(row["Score"]);
                    exam.ExistingPercentage = Convert.ToDecimal(row["Percentage"]);
                    exam.ExistingIsPassed = Convert.ToBoolean(row["IsPassed"]);
                }
                else
                {
                    exam.IsAttemptedByStudent = false;
                }

                list.Add(exam);
            }
            return list;
        }

        public static Exam GetExamById(int examId)
        {
            string sql = @"SELECT e.*, 
                                  (SELECT COUNT(*) FROM Questions q WHERE q.ExamId = e.ExamId) AS ActualQuestionCount
                           FROM Exams e WHERE e.ExamId = @ExamId";
            var dt = ExecuteQuery(sql, new SqlParameter("@ExamId", examId));
            if (dt.Rows.Count > 0)
            {
                var exam = MapExam(dt.Rows[0]);
                exam.ActualQuestionCount = Convert.ToInt32(dt.Rows[0]["ActualQuestionCount"]);
                return exam;
            }
            return null;
        }

        public static bool SaveExam(Exam exam, out string message)
        {
            message = string.Empty;
            try
            {
                if (exam.ExamId == 0)
                {
                    string sql = @"INSERT INTO Exams (Title, SubjectCode, Description, DurationMinutes, TotalQuestions, PassPercentage, IsActive, CreatedAt)
                                   VALUES (@Title, @SubjectCode, @Description, @DurationMinutes, @TotalQuestions, @PassPercentage, @IsActive, GETDATE())";
                    ExecuteNonQuery(sql,
                        new SqlParameter("@Title", exam.Title.Trim()),
                        new SqlParameter("@SubjectCode", exam.SubjectCode.Trim()),
                        new SqlParameter("@Description", (object)exam.Description?.Trim() ?? DBNull.Value),
                        new SqlParameter("@DurationMinutes", exam.DurationMinutes),
                        new SqlParameter("@TotalQuestions", exam.TotalQuestions),
                        new SqlParameter("@PassPercentage", exam.PassPercentage),
                        new SqlParameter("@IsActive", exam.IsActive));
                }
                else
                {
                    string sql = @"UPDATE Exams 
                                   SET Title = @Title, 
                                       SubjectCode = @SubjectCode, 
                                       Description = @Description, 
                                       DurationMinutes = @DurationMinutes, 
                                       TotalQuestions = @TotalQuestions, 
                                       PassPercentage = @PassPercentage, 
                                       IsActive = @IsActive 
                                   WHERE ExamId = @ExamId";
                    ExecuteNonQuery(sql,
                        new SqlParameter("@Title", exam.Title.Trim()),
                        new SqlParameter("@SubjectCode", exam.SubjectCode.Trim()),
                        new SqlParameter("@Description", (object)exam.Description?.Trim() ?? DBNull.Value),
                        new SqlParameter("@DurationMinutes", exam.DurationMinutes),
                        new SqlParameter("@TotalQuestions", exam.TotalQuestions),
                        new SqlParameter("@PassPercentage", exam.PassPercentage),
                        new SqlParameter("@IsActive", exam.IsActive),
                        new SqlParameter("@ExamId", exam.ExamId));
                }
                return true;
            }
            catch (Exception ex)
            {
                message = "Failed to save exam: " + ex.Message;
                return false;
            }
        }

        public static bool DeleteExam(int examId, out string message)
        {
            message = string.Empty;
            try
            {
                string sql = "DELETE FROM Exams WHERE ExamId = @ExamId";
                ExecuteNonQuery(sql, new SqlParameter("@ExamId", examId));
                return true;
            }
            catch (Exception ex)
            {
                message = "Failed to delete exam: " + ex.Message;
                return false;
            }
        }

        private static Exam MapExam(DataRow row)
        {
            return new Exam
            {
                ExamId = Convert.ToInt32(row["ExamId"]),
                Title = row["Title"].ToString(),
                SubjectCode = row["SubjectCode"].ToString(),
                Description = row["Description"] != DBNull.Value ? row["Description"].ToString() : string.Empty,
                DurationMinutes = Convert.ToInt32(row["DurationMinutes"]),
                TotalQuestions = Convert.ToInt32(row["TotalQuestions"]),
                PassPercentage = Convert.ToDecimal(row["PassPercentage"]),
                IsActive = Convert.ToBoolean(row["IsActive"]),
                CreatedAt = Convert.ToDateTime(row["CreatedAt"])
            };
        }

        // ==========================================
        // QUESTIONS CRUD
        // ==========================================

        public static List<Question> GetQuestionsByExamId(int examId)
        {
            var list = new List<Question>();
            string sql = @"SELECT q.*, e.Title AS ExamTitle 
                           FROM Questions q 
                           INNER JOIN Exams e ON q.ExamId = e.ExamId 
                           WHERE q.ExamId = @ExamId 
                           ORDER BY q.QuestionId ASC";

            var dt = ExecuteQuery(sql, new SqlParameter("@ExamId", examId));
            foreach (DataRow row in dt.Rows)
            {
                list.Add(MapQuestion(row));
            }
            return list;
        }

        public static Question GetQuestionById(int questionId)
        {
            string sql = @"SELECT q.*, e.Title AS ExamTitle 
                           FROM Questions q 
                           INNER JOIN Exams e ON q.ExamId = e.ExamId 
                           WHERE q.QuestionId = @QuestionId";
            var dt = ExecuteQuery(sql, new SqlParameter("@QuestionId", questionId));
            if (dt.Rows.Count > 0)
                return MapQuestion(dt.Rows[0]);
            return null;
        }

        public static bool SaveQuestion(Question q, out string message)
        {
            message = string.Empty;
            try
            {
                if (q.QuestionId == 0)
                {
                    string sql = @"INSERT INTO Questions (ExamId, QuestionText, OptionA, OptionB, OptionC, OptionD, CorrectOption, Marks, Explanation, CreatedAt)
                                   VALUES (@ExamId, @QuestionText, @OptionA, @OptionB, @OptionC, @OptionD, @CorrectOption, @Marks, @Explanation, GETDATE())";
                    ExecuteNonQuery(sql,
                        new SqlParameter("@ExamId", q.ExamId),
                        new SqlParameter("@QuestionText", q.QuestionText.Trim()),
                        new SqlParameter("@OptionA", q.OptionA.Trim()),
                        new SqlParameter("@OptionB", q.OptionB.Trim()),
                        new SqlParameter("@OptionC", q.OptionC.Trim()),
                        new SqlParameter("@OptionD", q.OptionD.Trim()),
                        new SqlParameter("@CorrectOption", q.CorrectOption),
                        new SqlParameter("@Marks", q.Marks),
                        new SqlParameter("@Explanation", (object)q.Explanation?.Trim() ?? DBNull.Value));
                }
                else
                {
                    string sql = @"UPDATE Questions 
                                   SET ExamId = @ExamId, 
                                       QuestionText = @QuestionText, 
                                       OptionA = @OptionA, 
                                       OptionB = @OptionB, 
                                       OptionC = @OptionC, 
                                       OptionD = @OptionD, 
                                       CorrectOption = @CorrectOption, 
                                       Marks = @Marks, 
                                       Explanation = @Explanation 
                                   WHERE QuestionId = @QuestionId";
                    ExecuteNonQuery(sql,
                        new SqlParameter("@ExamId", q.ExamId),
                        new SqlParameter("@QuestionText", q.QuestionText.Trim()),
                        new SqlParameter("@OptionA", q.OptionA.Trim()),
                        new SqlParameter("@OptionB", q.OptionB.Trim()),
                        new SqlParameter("@OptionC", q.OptionC.Trim()),
                        new SqlParameter("@OptionD", q.OptionD.Trim()),
                        new SqlParameter("@CorrectOption", q.CorrectOption),
                        new SqlParameter("@Marks", q.Marks),
                        new SqlParameter("@Explanation", (object)q.Explanation?.Trim() ?? DBNull.Value),
                        new SqlParameter("@QuestionId", q.QuestionId));
                }

                // Update total questions count in Exam table to match count
                string syncSql = @"UPDATE Exams 
                                   SET TotalQuestions = (SELECT COUNT(*) FROM Questions WHERE ExamId = @ExamId)
                                   WHERE ExamId = @ExamId";
                ExecuteNonQuery(syncSql, new SqlParameter("@ExamId", q.ExamId));

                return true;
            }
            catch (Exception ex)
            {
                message = "Failed to save question: " + ex.Message;
                return false;
            }
        }

        public static bool DeleteQuestion(int questionId, int examId, out string message)
        {
            message = string.Empty;
            try
            {
                string sql = "DELETE FROM Questions WHERE QuestionId = @QuestionId";
                ExecuteNonQuery(sql, new SqlParameter("@QuestionId", questionId));

                // Update total questions count in Exam table
                string syncSql = @"UPDATE Exams 
                                   SET TotalQuestions = (SELECT COUNT(*) FROM Questions WHERE ExamId = @ExamId)
                                   WHERE ExamId = @ExamId";
                ExecuteNonQuery(syncSql, new SqlParameter("@ExamId", examId));

                return true;
            }
            catch (Exception ex)
            {
                message = "Failed to delete question: " + ex.Message;
                return false;
            }
        }

        private static Question MapQuestion(DataRow row)
        {
            return new Question
            {
                QuestionId = Convert.ToInt32(row["QuestionId"]),
                ExamId = Convert.ToInt32(row["ExamId"]),
                ExamTitle = row.Table.Columns.Contains("ExamTitle") ? row["ExamTitle"].ToString() : string.Empty,
                QuestionText = row["QuestionText"].ToString(),
                OptionA = row["OptionA"].ToString(),
                OptionB = row["OptionB"].ToString(),
                OptionC = row["OptionC"].ToString(),
                OptionD = row["OptionD"].ToString(),
                CorrectOption = Convert.ToChar(row["CorrectOption"]),
                Marks = Convert.ToInt32(row["Marks"]),
                Explanation = row["Explanation"] != DBNull.Value ? row["Explanation"].ToString() : string.Empty,
                CreatedAt = Convert.ToDateTime(row["CreatedAt"])
            };
        }

        // ==========================================
        // EXAM ATTEMPTS & FULL PERFORMANCE REPORTS
        // ==========================================

        public static bool HasStudentAttemptedExam(int studentId, int examId)
        {
            string sql = "SELECT COUNT(*) FROM ExamAttempts WHERE StudentId = @StudentId AND ExamId = @ExamId";
            int count = Convert.ToInt32(ExecuteScalar(sql,
                new SqlParameter("@StudentId", studentId),
                new SqlParameter("@ExamId", examId)));
            return count > 0;
        }

        public static bool SubmitExamAttempt(int studentId, int examId, List<Question> answeredQuestions, int durationTakenSeconds, bool isTimedOut, out int attemptId, out string message)
        {
            attemptId = 0;
            message = string.Empty;

            using (var conn = GetConnection())
            {
                conn.Open();
                using (var trans = conn.BeginTransaction())
                {
                    try
                    {
                        // 1. Double check one attempt per exam restriction
                        string checkSql = "SELECT COUNT(*) FROM ExamAttempts WHERE StudentId = @StudentId AND ExamId = @ExamId";
                        using (var checkCmd = new SqlCommand(checkSql, conn, trans))
                        {
                            checkCmd.Parameters.AddWithValue("@StudentId", studentId);
                            checkCmd.Parameters.AddWithValue("@ExamId", examId);
                            int existingCount = Convert.ToInt32(checkCmd.ExecuteScalar());
                            if (existingCount > 0)
                            {
                                message = "You have already completed this examination. Only one attempt is allowed.";
                                trans.Rollback();
                                return false;
                            }
                        }

                        // 2. Fetch Exam Pass Percentage
                        decimal passPercentage = 50.0m;
                        using (var examCmd = new SqlCommand("SELECT PassPercentage FROM Exams WHERE ExamId = @ExamId", conn, trans))
                        {
                            examCmd.Parameters.AddWithValue("@ExamId", examId);
                            object val = examCmd.ExecuteScalar();
                            if (val != null && val != DBNull.Value)
                                passPercentage = Convert.ToDecimal(val);
                        }

                        // 3. Compute score breakdown
                        int totalQuestions = answeredQuestions.Count;
                        int answeredCount = 0;
                        int correctCount = 0;
                        int wrongCount = 0;
                        decimal totalScore = 0.0m;

                        foreach (var q in answeredQuestions)
                        {
                            if (q.SelectedOption.HasValue)
                            {
                                answeredCount++;
                                if (char.ToUpper(q.SelectedOption.Value) == char.ToUpper(q.CorrectOption))
                                {
                                    correctCount++;
                                    totalScore += q.Marks;
                                }
                                else
                                {
                                    wrongCount++;
                                }
                            }
                        }

                        decimal percentage = totalQuestions > 0 ? Math.Round((decimal)correctCount / totalQuestions * 100m, 2) : 0.0m;
                        bool isPassed = percentage >= passPercentage;
                        string status = isTimedOut ? "TimedOut" : "Completed";

                        // 4. Insert ExamAttempt
                        string insertAttemptSql = @"INSERT INTO ExamAttempts 
                            (StudentId, ExamId, StartTime, EndTime, DurationTakenSeconds, TotalQuestions, AnsweredQuestions, CorrectAnswers, WrongAnswers, Score, Percentage, Status, IsPassed)
                            OUTPUT INSERTED.AttemptId
                            VALUES 
                            (@StudentId, @ExamId, DATEADD(SECOND, -@DurationSeconds, GETDATE()), GETDATE(), @DurationSeconds, @TotalQuestions, @AnsweredQuestions, @CorrectAnswers, @WrongAnswers, @Score, @Percentage, @Status, @IsPassed)";

                        using (var insertCmd = new SqlCommand(insertAttemptSql, conn, trans))
                        {
                            insertCmd.Parameters.AddWithValue("@StudentId", studentId);
                            insertCmd.Parameters.AddWithValue("@ExamId", examId);
                            insertCmd.Parameters.AddWithValue("@DurationSeconds", durationTakenSeconds);
                            insertCmd.Parameters.AddWithValue("@TotalQuestions", totalQuestions);
                            insertCmd.Parameters.AddWithValue("@AnsweredQuestions", answeredCount);
                            insertCmd.Parameters.AddWithValue("@CorrectAnswers", correctCount);
                            insertCmd.Parameters.AddWithValue("@WrongAnswers", wrongCount);
                            insertCmd.Parameters.AddWithValue("@Score", totalScore);
                            insertCmd.Parameters.AddWithValue("@Percentage", percentage);
                            insertCmd.Parameters.AddWithValue("@Status", status);
                            insertCmd.Parameters.AddWithValue("@IsPassed", isPassed);

                            attemptId = Convert.ToInt32(insertCmd.ExecuteScalar());
                        }

                        // 5. Insert individual AttemptAnswers
                        string insertAnswerSql = @"INSERT INTO AttemptAnswers 
                            (AttemptId, QuestionId, SelectedOption, CorrectOption, IsCorrect, MarksObtained)
                            VALUES 
                            (@AttemptId, @QuestionId, @SelectedOption, @CorrectOption, @IsCorrect, @MarksObtained)";

                        foreach (var q in answeredQuestions)
                        {
                            using (var ansCmd = new SqlCommand(insertAnswerSql, conn, trans))
                            {
                                ansCmd.Parameters.AddWithValue("@AttemptId", attemptId);
                                ansCmd.Parameters.AddWithValue("@QuestionId", q.QuestionId);
                                ansCmd.Parameters.AddWithValue("@SelectedOption", (object)q.SelectedOption ?? DBNull.Value);
                                ansCmd.Parameters.AddWithValue("@CorrectOption", q.CorrectOption);

                                bool isCorr = q.SelectedOption.HasValue && (char.ToUpper(q.SelectedOption.Value) == char.ToUpper(q.CorrectOption));
                                ansCmd.Parameters.AddWithValue("@IsCorrect", isCorr);
                                ansCmd.Parameters.AddWithValue("@MarksObtained", isCorr ? q.Marks : 0);

                                ansCmd.ExecuteNonQuery();
                            }
                        }

                        trans.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        message = "Error submitting exam: " + ex.Message;
                        return false;
                    }
                }
            }
        }

        public static ExamAttempt GetAttemptSummary(int attemptId)
        {
            string sql = @"SELECT ea.*, e.Title AS ExamTitle, e.SubjectCode, u.FullName AS StudentName, u.RollNo
                           FROM ExamAttempts ea
                           INNER JOIN Exams e ON ea.ExamId = e.ExamId
                           INNER JOIN Users u ON ea.StudentId = u.UserId
                           WHERE ea.AttemptId = @AttemptId";

            var dt = ExecuteQuery(sql, new SqlParameter("@AttemptId", attemptId));
            if (dt.Rows.Count > 0)
            {
                return MapAttempt(dt.Rows[0]);
            }
            return null;
        }

        public static List<AttemptAnswer> GetAttemptAnswersReview(int attemptId)
        {
            var list = new List<AttemptAnswer>();
            string sql = @"SELECT aa.*, q.QuestionText, q.OptionA, q.OptionB, q.OptionC, q.OptionD, q.Explanation
                           FROM AttemptAnswers aa
                           INNER JOIN Questions q ON aa.QuestionId = q.QuestionId
                           WHERE aa.AttemptId = @AttemptId
                           ORDER BY aa.AnswerId ASC";

            var dt = ExecuteQuery(sql, new SqlParameter("@AttemptId", attemptId));
            int qIndex = 1;
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new AttemptAnswer
                {
                    AnswerId = Convert.ToInt32(row["AnswerId"]),
                    AttemptId = Convert.ToInt32(row["AttemptId"]),
                    QuestionId = Convert.ToInt32(row["QuestionId"]),
                    SelectedOption = row["SelectedOption"] != DBNull.Value ? Convert.ToChar(row["SelectedOption"].ToString().Trim()) : (char?)null,
                    CorrectOption = Convert.ToChar(row["CorrectOption"].ToString().Trim()),
                    IsCorrect = Convert.ToBoolean(row["IsCorrect"]),
                    MarksObtained = Convert.ToInt32(row["MarksObtained"]),
                    QuestionNumber = qIndex++,
                    QuestionText = row["QuestionText"].ToString(),
                    OptionA = row["OptionA"].ToString(),
                    OptionB = row["OptionB"].ToString(),
                    OptionC = row["OptionC"].ToString(),
                    OptionD = row["OptionD"].ToString(),
                    Explanation = row["Explanation"] != DBNull.Value ? row["Explanation"].ToString() : string.Empty
                });
            }
            return list;
        }

        public static List<ExamAttempt> GetAllAttempts(int? examId = null, int? studentId = null)
        {
            var list = new List<ExamAttempt>();
            string sql = @"SELECT ea.*, e.Title AS ExamTitle, e.SubjectCode, u.FullName AS StudentName, u.RollNo
                           FROM ExamAttempts ea
                           INNER JOIN Exams e ON ea.ExamId = e.ExamId
                           INNER JOIN Users u ON ea.StudentId = u.UserId
                           WHERE (1=1) ";

            var parameters = new List<SqlParameter>();

            if (examId.HasValue && examId.Value > 0)
            {
                sql += " AND ea.ExamId = @ExamId ";
                parameters.Add(new SqlParameter("@ExamId", examId.Value));
            }

            if (studentId.HasValue && studentId.Value > 0)
            {
                sql += " AND ea.StudentId = @StudentId ";
                parameters.Add(new SqlParameter("@StudentId", studentId.Value));
            }

            sql += " ORDER BY ea.AttemptId DESC";

            var dt = ExecuteQuery(sql, parameters.ToArray());
            foreach (DataRow row in dt.Rows)
            {
                list.Add(MapAttempt(row));
            }
            return list;
        }

        private static ExamAttempt MapAttempt(DataRow row)
        {
            return new ExamAttempt
            {
                AttemptId = Convert.ToInt32(row["AttemptId"]),
                StudentId = Convert.ToInt32(row["StudentId"]),
                StudentName = row["StudentName"].ToString(),
                RollNo = row["RollNo"] != DBNull.Value ? row["RollNo"].ToString() : string.Empty,
                ExamId = Convert.ToInt32(row["ExamId"]),
                ExamTitle = row["ExamTitle"].ToString(),
                SubjectCode = row["SubjectCode"].ToString(),
                StartTime = Convert.ToDateTime(row["StartTime"]),
                EndTime = row["EndTime"] != DBNull.Value ? Convert.ToDateTime(row["EndTime"]) : (DateTime?)null,
                DurationTakenSeconds = Convert.ToInt32(row["DurationTakenSeconds"]),
                TotalQuestions = Convert.ToInt32(row["TotalQuestions"]),
                AnsweredQuestions = Convert.ToInt32(row["AnsweredQuestions"]),
                CorrectAnswers = Convert.ToInt32(row["CorrectAnswers"]),
                WrongAnswers = Convert.ToInt32(row["WrongAnswers"]),
                Score = Convert.ToDecimal(row["Score"]),
                Percentage = Convert.ToDecimal(row["Percentage"]),
                Status = row["Status"].ToString(),
                IsPassed = Convert.ToBoolean(row["IsPassed"])
            };
        }

        // ==========================================
        // ADMIN DASHBOARD STATS
        // ==========================================

        public static Dictionary<string, object> GetAdminDashboardStats()
        {
            var stats = new Dictionary<string, object>();
            try
            {
                stats["TotalExams"] = Convert.ToInt32(ExecuteScalar("SELECT COUNT(*) FROM Exams"));
                stats["TotalQuestions"] = Convert.ToInt32(ExecuteScalar("SELECT COUNT(*) FROM Questions"));
                stats["TotalStudents"] = Convert.ToInt32(ExecuteScalar("SELECT COUNT(*) FROM Users WHERE Role = 'Student'"));
                stats["TotalAttempts"] = Convert.ToInt32(ExecuteScalar("SELECT COUNT(*) FROM ExamAttempts"));
                stats["PassedAttempts"] = Convert.ToInt32(ExecuteScalar("SELECT COUNT(*) FROM ExamAttempts WHERE IsPassed = 1"));

                int total = (int)stats["TotalAttempts"];
                int passed = (int)stats["PassedAttempts"];
                stats["PassPercentage"] = total > 0 ? Math.Round((decimal)passed / total * 100m, 1) : 0m;
            }
            catch
            {
                stats["TotalExams"] = 0;
                stats["TotalQuestions"] = 0;
                stats["TotalStudents"] = 0;
                stats["TotalAttempts"] = 0;
                stats["PassedAttempts"] = 0;
                stats["PassPercentage"] = 0m;
            }
            return stats;
        }
    }
}
