# Networked Examination & Assessment Engine
**MCA Final Year / Major Project**  
**Technology Stack:** C# .NET Framework 4.8, Windows Forms, SQL Server 2022, SSMS 2022, Visual Studio 2026 / 2022

---

## 📌 Project Overview
The **Networked Examination & Assessment Engine** is an enterprise-grade desktop examination platform designed for multi-candidate, network-based academic assessments. It enables educational institutions to author multi-subject MCQ exams, configure timed sessions, manage student registrations, and automatically grade test attempts with instant, in-depth performance analysis.

### ✨ Key Features
* **Role-Based Authentication:**
  * **Administrator Console:** Create/Edit/Delete Exams, manage MCQ question banks with explanations, register/edit/activate students, reset passwords, and inspect student scorecards.
  * **Student Examination Portal:** Self-registration, multi-exam catalog, live examination with interactive question palette, countdown timer with auto-submit, and immediate performance review.
* **Strict Exam Governance:**
  * **One Attempt Per Exam:** Guaranteed by database constraint (`UNIQUE(StudentId, ExamId)`) and application logic.
  * **Automated Time Management:** Dynamic visual countdown (MM:SS) that warns candidates when under 5 minutes and auto-submits on expiration.
  * **MCQ Architecture:** 4 distinct answer choices (A, B, C, D) per question with single correct key and automated scoring.
* **Full-Detail Performance Reporting:**
  * Visual Scorecard: Total Marks, Percentage, Result Status (PASSED/FAILED banner), Time Elapsed, and Submission Timestamp.
  * Question-by-Question Breakdown: Displays every question, candidate's selected choice, official correct answer, correctness indicator, marks awarded, and solution explanations.
* **100% Visual Studio Designer Friendly:**
  * Every Form is constructed with standard C# partial classes (`.cs`, `.Designer.cs`, `.resx`) adhering strictly to standard WinForms architecture. Double-clicking any form in Visual Studio 2026 / 2022 opens the WYSIWYG Form Designer immediately.

---

## 🗄️ Database Architecture & Pre-loaded Subjects
The database **`ExamEngineDB`** is normalized with primary keys, foreign keys (`ON DELETE CASCADE`), indexes, and check constraints:
1. **`Users`**: Stores Admin and Student credentials (SHA-256 hashed), Roll Numbers, contact details, and account status.
2. **`Exams`**: Holds test subjects, subject codes, duration in minutes, pass percentage, and active status.
3. **`Questions`**: MCQ pool with Question Text, Option A, Option B, Option C, Option D, Correct Option ('A'-'D'), Marks, and Concept Explanations.
4. **`ExamAttempts`**: Records candidate test sessions, duration taken, total score, percentage, and pass/fail results.
5. **`AttemptAnswers`**: Detailed log of selected option vs correct option for post-exam review.

### Pre-loaded Exams & Question Banks (40 Academic Questions Included)
* **MCA-NET-501:** *C# & .NET Framework 4.8 Architecture* (10 Questions, 15 Mins, 50% Pass)
* **MCA-DBMS-502:** *Database Management Systems & SQL Server* (10 Questions, 15 Mins, 50% Pass)
* **MCA-DSA-503:** *Data Structures & Algorithm Design* (10 Questions, 15 Mins, 50% Pass)
* **MCA-NET-504:** *Computer Networks & Distributed Systems* (10 Questions, 15 Mins, 50% Pass)

---

## 🚀 Setup & Execution Guide

### Step 1: Database Setup in SSMS 2022
1. Open **SQL Server Management Studio (SSMS 2022)**.
2. Connect to your SQL Server instance (e.g. `.` or `localhost` or `.\SQLEXPRESS`).
3. Click **File -> Open -> File...** and select `DatabaseSetup.sql`.
4. Click **Execute** (or press `F5`).
5. The script will automatically create `ExamEngineDB`, all 5 relational tables, constraints, and seed data.

### Step 2: Configure Database Connection
* Open `App.config` inside the `NetworkedExamEngine` folder:
  ```xml
  <connectionStrings>
    <add name="ExamEngineDB" 
         connectionString="Data Source=.;Initial Catalog=ExamEngineDB;User Id=sa;Password=your_password;TrustServerCertificate=True;" 
         providerName="System.Data.SqlClient" />
  </connectionStrings>
  ```
  *(Replace `your_password` with your actual SQL Server `sa` password or server instance)*
* **Built-in Configuration Utility:** If the credentials differ, the application will prompt you on startup, or you can click **"⚙ Database Settings"** on the Login screen to test and update the connection string with 1-click feedback.

### Step 3: Open and Run in Visual Studio 2026 / 2022
1. Double-click **`NetworkedExamEngine.sln`** to load the project in Visual Studio.
2. Ensure the Solution Configuration is set to **`Debug`** or **`Release`** and **`Any CPU`**.
3. Press **`F5`** (or click **Start Debugging**) to run.
4. To edit any UI, double-click any `.cs` file in the `Forms\` folder in Solution Explorer to open the Visual Studio Form Designer.

---

## 🔑 Default User Credentials

| Role | Username | Default Password | Details |
| :--- | :--- | :--- | :--- |
| **Administrator** | `admin` | `admin123` | Full access to exams, question banking, and candidate records |
| **Student 1** | `student1` | `student123` | Rahul Sharma (Roll: `MCA2026-001`) - Has 1 pre-loaded completed test review |
| **Student 2** | `student2` | `student123` | Priya Patel (Roll: `MCA2026-002`) - Fresh candidate ready to take any exam |
| **New Candidate** | *Custom* | *Custom* | Click **"Register Now Here"** on the login screen to self-register |

---

## 📂 Project Directory Structure
```
NetworkedExamEngine/
├── NetworkedExamEngine.sln                 # Visual Studio Solution File
├── DatabaseSetup.sql                       # SSMS 2022 Complete SQL Database Setup Script
├── README.md                               # Project Documentation & Setup Guide
└── NetworkedExamEngine/                    # Application Project Folder
    ├── App.config                          # SQL Server Connection Configuration
    ├── Program.cs                          # Application Entry Point & Connectivity Check
    ├── NetworkedExamEngine.csproj          # C# Project File (.NET Framework 4.8)
    ├── Properties/                         # Assembly info and resources
    ├── Models/                             # Domain Entities
    │   ├── User.cs                         # Student & Admin account model
    │   ├── Exam.cs                         # Exam metadata & status model
    │   ├── Question.cs                     # MCQ Question & Answer key model
    │   ├── ExamAttempt.cs                  # Attempt score & duration model
    │   └── AttemptAnswer.cs                # Detailed answer review model
    ├── Data/
    │   └── DatabaseHelper.cs               # Centralized ADO.NET SQL Helper with Transactions
    ├── Helpers/
    │   ├── PasswordHelper.cs               # SHA-256 Hashing & Verification
    │   └── UITheme.cs                      # Modern Color Palette & UI Utilities
    └── Forms/                              # WinForms Windows (Designer-backed)
        ├── LoginForm.cs                    # Multi-Role Authentication Screen
        ├── StudentRegisterForm.cs          # Student Self-Registration Dialog
        ├── DatabaseConfigForm.cs           # SQL Server Connection Config & Test Screen
        ├── AdminMainForm.cs                # Admin Control Center & KPI Dashboard
        ├── ExamEditForm.cs                 # Add/Edit Examination Modal
        ├── QuestionEditForm.cs             # Add/Edit MCQ Question & Options Modal
        ├── StudentEditForm.cs              # Admin Student Management & Password Reset
        ├── StudentMainForm.cs              # Student Portal & Exam Catalog
        ├── ExamTakingForm.cs               # Live Exam Engine, Timer, & Question Palette
        └── ExamResultReportForm.cs         # Full Detail Performance Scorecard & Review
```

---

## 🎓 Viva & Project Presentation Highlights
1. **Security:** Passwords are never stored in plaintext; they are hashed using cryptographic SHA-256.
2. **SQL Injection Prevention:** All SQL queries and stored procedures utilize parameterized `SqlParameter` collections.
3. **Data Integrity:** ACID-compliant `SqlTransaction` handles multi-table insertions when submitting tests, ensuring atomicity across `ExamAttempts` and `AttemptAnswers`.
4. **Resilient Network Time Tracking:** The countdown timer maintains local second-level precision, warning candidates in red when under 5 minutes and triggering an automatic submit transaction on zero.
5. **Enforced Rules:** One-attempt restriction is guaranteed both at the UI layer (buttons disabled) and database layer (`UNIQUE(StudentId, ExamId)`).
