-- ==================================================================================
-- NETWORKED EXAMINATION & ASSESSMENT ENGINE
-- Database Setup Script for SQL Server 2022 / SSMS
-- Project: MCA Final Year / Mini Project
-- Database: ExamEngineDB
-- ==================================================================================

IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'ExamEngineDB')
BEGIN
    CREATE DATABASE ExamEngineDB;
    PRINT 'Database ExamEngineDB created successfully.';
END
ELSE
BEGIN
    PRINT 'Database ExamEngineDB already exists.';
END
GO

USE ExamEngineDB;
GO

-- 1. USERS TABLE (Admins and Students)
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Users]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[Users] (
        [UserId] INT IDENTITY(1,1) PRIMARY KEY,
        [Username] NVARCHAR(50) NOT NULL UNIQUE,
        [PasswordHash] NVARCHAR(256) NOT NULL,
        [FullName] NVARCHAR(100) NOT NULL,
        [Email] NVARCHAR(100) NOT NULL UNIQUE,
        [Role] NVARCHAR(20) NOT NULL DEFAULT 'Student', -- 'Admin' or 'Student'
        [RollNo] NVARCHAR(50) NULL,                     -- Required for Students
        [Phone] NVARCHAR(20) NULL,
        [IsActive] BIT NOT NULL DEFAULT 1,
        [CreatedAt] DATETIME NOT NULL DEFAULT GETDATE()
    );
    PRINT 'Table Users created.';
END
GO

-- 2. EXAMS TABLE
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Exams]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[Exams] (
        [ExamId] INT IDENTITY(1,1) PRIMARY KEY,
        [Title] NVARCHAR(150) NOT NULL,
        [SubjectCode] NVARCHAR(50) NOT NULL,
        [Description] NVARCHAR(500) NULL,
        [DurationMinutes] INT NOT NULL DEFAULT 15,
        [TotalQuestions] INT NOT NULL DEFAULT 10,
        [PassPercentage] DECIMAL(5,2) NOT NULL DEFAULT 50.00,
        [IsActive] BIT NOT NULL DEFAULT 1,
        [CreatedAt] DATETIME NOT NULL DEFAULT GETDATE()
    );
    PRINT 'Table Exams created.';
END
GO

-- 3. QUESTIONS TABLE (MCQ Only: A, B, C, D)
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Questions]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[Questions] (
        [QuestionId] INT IDENTITY(1,1) PRIMARY KEY,
        [ExamId] INT NOT NULL,
        [QuestionText] NVARCHAR(MAX) NOT NULL,
        [OptionA] NVARCHAR(500) NOT NULL,
        [OptionB] NVARCHAR(500) NOT NULL,
        [OptionC] NVARCHAR(500) NOT NULL,
        [OptionD] NVARCHAR(500) NOT NULL,
        [CorrectOption] CHAR(1) NOT NULL, -- 'A', 'B', 'C', or 'D'
        [Marks] INT NOT NULL DEFAULT 1,
        [Explanation] NVARCHAR(MAX) NULL,
        [CreatedAt] DATETIME NOT NULL DEFAULT GETDATE(),
        CONSTRAINT FK_Questions_Exams FOREIGN KEY ([ExamId]) REFERENCES [dbo].[Exams]([ExamId]) ON DELETE CASCADE,
        CONSTRAINT CHK_CorrectOption CHECK ([CorrectOption] IN ('A', 'B', 'C', 'D'))
    );
    CREATE INDEX IX_Questions_ExamId ON [dbo].[Questions]([ExamId]);
    PRINT 'Table Questions created.';
END
GO

-- 4. EXAM ATTEMPTS TABLE (Records each student's exam attempt - Exactly one attempt per exam)
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ExamAttempts]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[ExamAttempts] (
        [AttemptId] INT IDENTITY(1,1) PRIMARY KEY,
        [StudentId] INT NOT NULL,
        [ExamId] INT NOT NULL,
        [StartTime] DATETIME NOT NULL DEFAULT GETDATE(),
        [EndTime] DATETIME NULL,
        [DurationTakenSeconds] INT NOT NULL DEFAULT 0,
        [TotalQuestions] INT NOT NULL DEFAULT 0,
        [AnsweredQuestions] INT NOT NULL DEFAULT 0,
        [CorrectAnswers] INT NOT NULL DEFAULT 0,
        [WrongAnswers] INT NOT NULL DEFAULT 0,
        [Score] DECIMAL(5,2) NOT NULL DEFAULT 0.00,
        [Percentage] DECIMAL(5,2) NOT NULL DEFAULT 0.00,
        [Status] NVARCHAR(20) NOT NULL DEFAULT 'Completed', -- 'Completed' or 'TimedOut'
        [IsPassed] BIT NOT NULL DEFAULT 0,
        CONSTRAINT FK_ExamAttempts_Users FOREIGN KEY ([StudentId]) REFERENCES [dbo].[Users]([UserId]) ON DELETE CASCADE,
        CONSTRAINT FK_ExamAttempts_Exams FOREIGN KEY ([ExamId]) REFERENCES [dbo].[Exams]([ExamId]) ON DELETE CASCADE,
        CONSTRAINT UQ_Student_Exam_Attempt UNIQUE ([StudentId], [ExamId]) -- Enforces one attempt per exam
    );
    CREATE INDEX IX_ExamAttempts_StudentId ON [dbo].[ExamAttempts]([StudentId]);
    CREATE INDEX IX_ExamAttempts_ExamId ON [dbo].[ExamAttempts]([ExamId]);
    PRINT 'Table ExamAttempts created.';
END
GO

-- 5. ATTEMPT ANSWERS TABLE (Stores student answer vs correct answer for detailed question-by-question review)
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AttemptAnswers]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[AttemptAnswers] (
        [AnswerId] INT IDENTITY(1,1) PRIMARY KEY,
        [AttemptId] INT NOT NULL,
        [QuestionId] INT NOT NULL,
        [SelectedOption] CHAR(1) NULL, -- 'A', 'B', 'C', 'D', or NULL if unanswered
        [CorrectOption] CHAR(1) NOT NULL,
        [IsCorrect] BIT NOT NULL DEFAULT 0,
        [MarksObtained] INT NOT NULL DEFAULT 0,
        CONSTRAINT FK_AttemptAnswers_ExamAttempts FOREIGN KEY ([AttemptId]) REFERENCES [dbo].[ExamAttempts]([AttemptId]) ON DELETE CASCADE,
        CONSTRAINT FK_AttemptAnswers_Questions FOREIGN KEY ([QuestionId]) REFERENCES [dbo].[Questions]([QuestionId])
    );
    CREATE INDEX IX_AttemptAnswers_AttemptId ON [dbo].[AttemptAnswers]([AttemptId]);
    PRINT 'Table AttemptAnswers created.';
END
GO

-- ==================================================================================
-- SEED DATA
-- Default Passwords (SHA-256 Hashed):
-- 'admin123'   -> 240BE518FABD2724DDB6F04EEB1DA5967448D7E831C08C8FA822809F74C720A9
-- 'student123' -> 703B0A3D6AD75B649A28ADDE7D83C6251DA457549263BC7FF45EC709B0A8448B
-- ==================================================================================

-- Insert Admin Account
IF NOT EXISTS (SELECT 1 FROM [dbo].[Users] WHERE [Username] = 'admin')
BEGIN
    INSERT INTO [dbo].[Users] ([Username], [PasswordHash], [FullName], [Email], [Role], [RollNo], [Phone], [IsActive])
    VALUES ('admin', '240BE518FABD2724DDB6F04EEB1DA5967448D7E831C08C8FA822809F74C720A9', 'System Administrator', 'admin@examengine.local', 'Admin', 'ADMIN-01', '9876543210', 1);
    PRINT 'Admin account inserted (admin / admin123).';
END
GO

-- Insert Sample Students
IF NOT EXISTS (SELECT 1 FROM [dbo].[Users] WHERE [Username] = 'student1')
BEGIN
    INSERT INTO [dbo].[Users] ([Username], [PasswordHash], [FullName], [Email], [Role], [RollNo], [Phone], [IsActive])
    VALUES ('student1', '703B0A3D6AD75B649A28ADDE7D83C6251DA457549263BC7FF45EC709B0A8448B', 'Rahul Sharma', 'rahul.sharma@college.edu', 'Student', 'MCA2026-001', '9812345678', 1);
END
ELSE
BEGIN
    UPDATE [dbo].[Users] SET [PasswordHash] = '703B0A3D6AD75B649A28ADDE7D83C6251DA457549263BC7FF45EC709B0A8448B' WHERE [Username] = 'student1';
END

IF NOT EXISTS (SELECT 1 FROM [dbo].[Users] WHERE [Username] = 'student2')
BEGIN
    INSERT INTO [dbo].[Users] ([Username], [PasswordHash], [FullName], [Email], [Role], [RollNo], [Phone], [IsActive])
    VALUES ('student2', '703B0A3D6AD75B649A28ADDE7D83C6251DA457549263BC7FF45EC709B0A8448B', 'Priya Patel', 'priya.patel@college.edu', 'Student', 'MCA2026-002', '9823456789', 1);
    PRINT 'Sample student accounts inserted (student1, student2 / student123).';
END
ELSE
BEGIN
    UPDATE [dbo].[Users] SET [PasswordHash] = '703B0A3D6AD75B649A28ADDE7D83C6251DA457549263BC7FF45EC709B0A8448B' WHERE [Username] = 'student2';
END
GO

-- Insert Sample Exams
IF NOT EXISTS (SELECT 1 FROM [dbo].[Exams] WHERE [SubjectCode] = 'MCA-NET-501')
BEGIN
    INSERT INTO [dbo].[Exams] ([Title], [SubjectCode], [Description], [DurationMinutes], [TotalQuestions], [PassPercentage], [IsActive])
    VALUES (
        N'C# & .NET Framework 4.8 Architecture',
        N'MCA-NET-501',
        N'Assessment on CLR, CTS, Garbage Collection, Delegates, LINQ, WinForms, and ADO.NET internals.',
        15,
        10,
        50.00,
        1
    );
END

IF NOT EXISTS (SELECT 1 FROM [dbo].[Exams] WHERE [SubjectCode] = 'MCA-DBMS-502')
BEGIN
    INSERT INTO [dbo].[Exams] ([Title], [SubjectCode], [Description], [DurationMinutes], [TotalQuestions], [PassPercentage], [IsActive])
    VALUES (
        N'Database Management Systems & SQL Server',
        N'MCA-DBMS-502',
        N'Testing normalization, ACID properties, indexing, triggers, stored procedures, and execution plans.',
        15,
        10,
        50.00,
        1
    );
END

IF NOT EXISTS (SELECT 1 FROM [dbo].[Exams] WHERE [SubjectCode] = 'MCA-DSA-503')
BEGIN
    INSERT INTO [dbo].[Exams] ([Title], [SubjectCode], [Description], [DurationMinutes], [TotalQuestions], [PassPercentage], [IsActive])
    VALUES (
        N'Data Structures & Algorithm Design',
        N'MCA-DSA-503',
        N'Evaluating asymptotic analysis, graph algorithms, dynamic programming, and balanced binary search trees.',
        15,
        10,
        50.00,
        1
    );
END

IF NOT EXISTS (SELECT 1 FROM [dbo].[Exams] WHERE [SubjectCode] = 'MCA-NET-504')
BEGIN
    INSERT INTO [dbo].[Exams] ([Title], [SubjectCode], [Description], [DurationMinutes], [TotalQuestions], [PassPercentage], [IsActive])
    VALUES (
        N'Computer Networks & Distributed Systems',
        N'MCA-NET-504',
        N'Core exam on OSI and TCP/IP stack, routing protocols, TLS/SSL cryptography, and socket programming.',
        15,
        10,
        50.00,
        1
    );
END
GO

-- Insert Questions for Exam 1: C# & .NET
DECLARE @Exam1Id INT;
SELECT @Exam1Id = [ExamId] FROM [dbo].[Exams] WHERE [SubjectCode] = 'MCA-NET-501';

IF NOT EXISTS (SELECT 1 FROM [dbo].[Questions] WHERE [ExamId] = @Exam1Id)
BEGIN
    INSERT INTO [dbo].[Questions] ([ExamId], [QuestionText], [OptionA], [OptionB], [OptionC], [OptionD], [CorrectOption], [Marks], [Explanation])
    VALUES
    (@Exam1Id, N'Which component in the .NET Framework is responsible for translating Intermediate Language (IL) into native CPU machine instructions?',
     N'Common Language Specification (CLS)', N'Just-In-Time (JIT) Compiler', N'Common Type System (CTS)', N'Garbage Collector (GC)',
     'B', 1, N'The JIT (Just-In-Time) compiler within the CLR compiles CIL (Common Intermediate Language) code into platform-native machine instructions right before execution.'),

    (@Exam1Id, N'In C#, which keyword is utilized to explicitly release unmanaged resources deterministically via the IDisposable interface?',
     N'finally', N'using', N'dispose', N'destructor',
     'B', 1, N'The "using" statement ensures that Dispose() is called on an IDisposable object immediately when execution exits the using scope, even if an exception occurs.'),

    (@Exam1Id, N'What is the fundamental difference between a value type and a reference type in C#?',
     N'Value types are stored on the Heap; Reference types are on the Stack',
     N'Value types inherit from System.ValueType and store actual data; Reference types store pointers to memory on the Managed Heap',
     N'Value types cannot implement interfaces; Reference types can',
     N'Value types are always mutable; Reference types are strictly immutable',
     'B', 1, N'Value types derive from System.ValueType and contain the direct data (typically stored on the stack), whereas reference types store memory references pointing to objects allocated on the managed heap.'),

    (@Exam1Id, N'What type-safe function pointer in C# encapsulates a method signature and enables event handling?',
     N'Pointer', N'Delegate', N'Interface', N'Indexer',
     'B', 1, N'A delegate is a type-safe object that references one or more methods with a matching signature and return type.'),

    (@Exam1Id, N'In ADO.NET, which disconnected architecture component acts as an in-memory relational database cache containing tables and relations?',
     N'SqlDataReader', N'SqlCommand', N'DataSet', N'SqlTransaction',
     'C', 1, N'DataSet is a disconnected, in-memory representation of data that can hold multiple DataTables, relations, and constraints without maintaining an open database connection.'),

    (@Exam1Id, N'Which collection in System.Collections.Generic is implemented as a hash table providing average O(1) time complexity for lookup and insertion?',
     N'List<T>', N'LinkedList<T>', N'SortedList<TKey, TValue>', N'Dictionary<TKey, TValue>',
     'D', 1, N'Dictionary<TKey, TValue> provides O(1) amortized lookup, addition, and removal time using an internal hash table algorithm.'),

    (@Exam1Id, N'Which Generation in the .NET Generational Garbage Collector collects short-lived objects such as temporary local variables?',
     N'Generation 0', N'Generation 1', N'Generation 2', N'Large Object Heap (LOH)',
     'A', 1, N'Generation 0 contains newly allocated, short-lived objects. Garbage collection occurs most frequently in Gen 0 because most objects die young.'),

    (@Exam1Id, N'What is boxing in C#?',
     N'Converting a string to an integer',
     N'Converting a value type to the type object or to any interface type implemented by this value type',
     N'Converting a class reference to a struct',
     N'Serializing an object into a binary format',
     'B', 1, N'Boxing is the process of converting a value type to System.Object or an interface type, which copies the value from the stack to an allocated wrapper on the heap.'),

    (@Exam1Id, N'Which access modifier makes a class member accessible only within its containing assembly or derived types in other assemblies?',
     N'internal', N'protected internal', N'private protected', N'protected',
     'B', 1, N'"protected internal" allows access from any code in the same assembly OR from derived classes located in any other assembly.'),

    (@Exam1Id, N'Which LINQ operator is used to perform projection, transforming elements of a sequence into a new form?',
     N'Where', N'Select', N'GroupBy', N'Aggregate',
     'B', 1, N'The "Select" operator in LINQ performs a projection that maps each element into a desired shape or transformed object.');
END
GO

-- Insert Questions for Exam 2: DBMS & SQL Server
DECLARE @Exam2Id INT;
SELECT @Exam2Id = [ExamId] FROM [dbo].[Exams] WHERE [SubjectCode] = 'MCA-DBMS-502';

IF NOT EXISTS (SELECT 1 FROM [dbo].[Questions] WHERE [ExamId] = @Exam2Id)
BEGIN
    INSERT INTO [dbo].[Questions] ([ExamId], [QuestionText], [OptionA], [OptionB], [OptionC], [OptionD], [CorrectOption], [Marks], [Explanation])
    VALUES
    (@Exam2Id, N'Which Normal Form eliminates transitive functional dependencies between non-prime attributes?',
     N'First Normal Form (1NF)', N'Second Normal Form (2NF)', N'Third Normal Form (3NF)', N'Boyce-Codd Normal Form (BCNF)',
     'C', 1, N'3NF requires the relation to be in 2NF and that no non-prime attribute is transitively dependent on any candidate key.'),

    (@Exam2Id, N'In transaction processing, what does the "I" in the ACID properties guarantee?',
     N'Integrity: Constraints are never violated',
     N'Isolation: Concurrent execution of transactions yields the same state as if executed serially',
     N'Immutability: Committed records cannot be modified',
     N'Idempotence: Executing a query multiple times produces identical side-effects',
     'B', 1, N'Isolation guarantees that concurrent transactions operate independently without interference, preventing dirty reads, non-repeatable reads, or phantom reads based on isolation levels.'),

    (@Exam2Id, N'How many Clustered Indexes can a single SQL Server table possess?',
     N'Only 1', N'Up to 16', N'Up to 999', N'Unlimited',
     'A', 1, N'A table can have only one Clustered Index because the clustered index dictates the physical sorting order of the data rows on disk pages.'),

    (@Exam2Id, N'Which SQL Server JOIN type returns all records from the left table and matched records from the right table, filling with NULL where no match exists?',
     N'INNER JOIN', N'LEFT OUTER JOIN', N'FULL OUTER JOIN', N'CROSS JOIN',
     'B', 1, N'LEFT OUTER JOIN retains every row from the left table regardless of whether a matching record exists in the right table.'),

    (@Exam2Id, N'What is the primary operational distinction between DELETE and TRUNCATE in SQL Server?',
     N'DELETE cannot have a WHERE clause; TRUNCATE can',
     N'TRUNCATE is a minimally logged DDL operation that deallocates entire pages, while DELETE logs individual row removals and supports WHERE clauses',
     N'TRUNCATE fires AFTER DELETE triggers; DELETE does not',
     N'TRUNCATE can be executed on a table referenced by a FOREIGN KEY constraint without removing the foreign key',
     'B', 1, N'TRUNCATE TABLE deallocates pages rather than recording row deletions in the transaction log, cannot take a WHERE clause, and does not fire row-level triggers.'),

    (@Exam2Id, N'Which database lock level prevents phantom reads in SQL Server?',
     N'READ UNCOMMITTED', N'READ COMMITTED', N'REPEATABLE READ', N'SERIALIZABLE',
     'D', 1, N'SERIALIZABLE is the highest isolation level and uses range locks to prevent phantom rows from being inserted into the range evaluated by a query.'),

    (@Exam2Id, N'What type of trigger in SQL Server replaces the triggering INSERT/UPDATE/DELETE statement instead of executing after it?',
     N'AFTER Trigger', N'INSTEAD OF Trigger', N'DDL Trigger', N'LOGON Trigger',
     'B', 1, N'An INSTEAD OF trigger executes in place of the DML action, allowing custom validation or updating complex non-updatable views.'),

    (@Exam2Id, N'Which aggregate function in SQL Server calculates the ranking of rows within a window partition without gaps in ranking values?',
     N'ROW_NUMBER()', N'RANK()', N'DENSE_RANK()', N'NTILE()',
     'C', 1, N'DENSE_RANK() assigns consecutive rank integers without gaps when values are tied.'),

    (@Exam2Id, N'In SQL Server, what virtual table is accessible inside a trigger to inspect rows that were just inserted or updated?',
     N'INSERTED', N'NEW_ROWS', N'ADDED_DATA', N'TEMP_INSERT',
     'A', 1, N'The INSERTED logical table contains copies of affected rows during INSERT and UPDATE operations.'),

    (@Exam2Id, N'What index feature in SQL Server allows non-key columns to be added to the leaf level of a Non-Clustered index to produce a covering index?',
     N'FILTERED INDEX', N'INCLUDE clause', N'PARTITION BY', N'COMPRESSION',
     'B', 1, N'The INCLUDE clause appends non-key columns directly into leaf-level nodes, covering the query without widening the B-Tree index key.');
END
GO

-- Insert Questions for Exam 3: DSA
DECLARE @Exam3Id INT;
SELECT @Exam3Id = [ExamId] FROM [dbo].[Exams] WHERE [SubjectCode] = 'MCA-DSA-503';

IF NOT EXISTS (SELECT 1 FROM [dbo].[Questions] WHERE [ExamId] = @Exam3Id)
BEGIN
    INSERT INTO [dbo].[Questions] ([ExamId], [QuestionText], [OptionA], [OptionB], [OptionC], [OptionD], [CorrectOption], [Marks], [Explanation])
    VALUES
    (@Exam3Id, N'What is the worst-case time complexity of standard QuickSort when a naive pivot selection (first or last element) is applied to an already sorted array?',
     N'O(N)', N'O(N log N)', N'O(N^2)', N'O(log N)',
     'C', 1, N'When the array is already sorted and extreme pivots are picked, QuickSort partitions into subproblems of size 0 and N-1, degrading to O(N^2) quadratic time.'),

    (@Exam3Id, N'Which self-balancing Binary Search Tree guarantees that the height difference (balance factor) between left and right subtrees never exceeds 1 for any node?',
     N'Red-Black Tree', N'AVL Tree', N'B-Tree', N'Splay Tree',
     'B', 1, N'An AVL tree strictly enforces that for every node, the height difference between the left and right subtrees is at most 1, triggering rotations when breached.'),

    (@Exam3Id, N'Which algorithm is used to find the Shortest Path from a single source node to all other nodes in a directed graph with non-negative edge weights?',
     N'Prim''s Algorithm', N'Kruskal''s Algorithm', N'Dijkstra''s Algorithm', N'Floyd-Warshall Algorithm',
     'C', 1, N'Dijkstra''s algorithm finds the shortest paths from a single source vertex using a priority queue (min-heap) in O((V + E) log V) time.'),

    (@Exam3Id, N'Which data structure is intrinsically used to perform a Breadth-First Search (BFS) on a graph or tree?',
     N'Stack', N'Queue', N'Priority Queue', N'Hash Table',
     'B', 1, N'BFS explores vertices level by level in First-In-First-Out (FIFO) order using a Queue.'),

    (@Exam3Id, N'What is the maximum number of nodes in a complete binary tree of height H (where height of root is 0)?',
     N'2^H', N'2^(H+1) - 1', N'2^H - 1', N'H^2 + 1',
     'B', 1, N'A binary tree of height H has at most 1 + 2 + 4 + ... + 2^H = 2^(H+1) - 1 nodes.'),

    (@Exam3Id, N'Which algorithmic paradigm is applied in solving the 0/1 Knapsack Problem efficiently?',
     N'Greedy Approach', N'Dynamic Programming', N'Divide and Conquer', N'Backtracking only',
     'B', 1, N'The 0/1 Knapsack Problem exhibits optimal substructure and overlapping subproblems, making 2D/1D Dynamic Programming the optimal O(N*W) solution.'),

    (@Exam3Id, N'What collision resolution technique in Hash Tables stores colliding elements in linked lists attached to each bucket slot?',
     N'Linear Probing', N'Quadratic Probing', N'Separate Chaining', N'Double Hashing',
     'C', 1, N'Separate Chaining maintains an independent linked list or dynamic list at each hash bucket to handle collisions.'),

    (@Exam3Id, N'Which asymptotic notation provides a tight mathematical bound (both upper and lower) on the growth rate of an algorithm''s running time?',
     N'Big O (O)', N'Big Omega (Ω)', N'Big Theta (Θ)', N'Little o',
     'C', 1, N'Theta (Θ) notation denotes a asymptotically tight bound, sandwiching f(N) between c1*g(N) and c2*g(N) for large N.'),

    (@Exam3Id, N'Which tree traversal sequence visits nodes in the exact order: Left Subtree, Root, Right Subtree?',
     N'Pre-order', N'In-order', N'Post-order', N'Level-order',
     'B', 1, N'In-order traversal visits the left subtree, then current node, then right subtree. For a BST, it produces sorted ascending keys.'),

    (@Exam3Id, N'What is the minimum number of queues required to implement a standard Last-In-First-Out (LIFO) Stack?',
     N'1', N'2', N'3', N'4',
     'B', 1, N'A stack can be simulated using two queues by either making the push operation costly or the pop operation costly.');
END
GO

-- Insert Questions for Exam 4: Computer Networks
DECLARE @Exam4Id INT;
SELECT @Exam4Id = [ExamId] FROM [dbo].[Exams] WHERE [SubjectCode] = 'MCA-NET-504';

IF NOT EXISTS (SELECT 1 FROM [dbo].[Questions] WHERE [ExamId] = @Exam4Id)
BEGIN
    INSERT INTO [dbo].[Questions] ([ExamId], [QuestionText], [OptionA], [OptionB], [OptionC], [OptionD], [CorrectOption], [Marks], [Explanation])
    VALUES
    (@Exam4Id, N'At which OSI model layer does the Address Resolution Protocol (ARP) primarily operate to map IP addresses to MAC addresses?',
     N'Application Layer', N'Transport Layer', N'Network / Data Link Boundary (Layer 2/3)', N'Physical Layer',
     'C', 1, N'ARP resolves IPv4 addresses into physical link-layer addresses (MAC addresses), operating at the interface between the Network (Layer 3) and Data Link (Layer 2) layers.'),

    (@Exam4Id, N'Which TCP flag is used to initiate a three-way handshake connection establishment between client and server?',
     N'ACK', N'SYN', N'FIN', N'RST',
     'B', 1, N'TCP connection establishment begins with the client sending a SYN packet, followed by SYN-ACK from the server, and concluded with an ACK from the client.'),

    (@Exam4Id, N'What is the default subnet mask for an IPv4 Class B network address?',
     N'255.0.0.0', N'255.255.0.0', N'255.255.255.0', N'255.255.255.255',
     'B', 1, N'Class B IP addresses reserve 16 bits for the network ID and 16 bits for host IDs, yielding the default subnet mask 255.255.0.0 (/16).'),

    (@Exam4Id, N'Which transport protocol is connectionless, unreliable, and chosen for low-latency streaming and DNS queries?',
     N'TCP', N'UDP', N'SCTP', N'ICMP',
     'B', 1, N'User Datagram Protocol (UDP) provides lightweight, stateless message delivery without handshake overhead or retransmission delays.'),

    (@Exam4Id, N'Which application layer protocol uses TLS over port 443 to secure hypermedia document exchange across the World Wide Web?',
     N'HTTP', N'HTTPS', N'FTP', N'SSH',
     'B', 1, N'HTTPS (HyperText Transfer Protocol Secure) encrypts HTTP traffic over TLS/SSL on standard TCP port 443.'),

    (@Exam4Id, N'In routing protocols, what metric does the Routing Information Protocol (RIP) use to determine the best path to a destination?',
     N'Bandwidth', N'Latency', N'Hop Count', N'Reliability',
     'C', 1, N'RIP uses hop count as its sole routing metric, with a maximum allowable hop count of 15 (16 is considered unreachable).'),

    (@Exam4Id, N'What is the primary function of the Network Address Translation (NAT) router mechanism in IPv4 networking?',
     N'Encrypt payload data packets',
     N'Map multiple private RFC 1918 IP addresses into a single or pool of public IP addresses',
     N'Generate dynamic IP leases for connecting laptops',
     N'Filter malicious packet payloads at Layer 7',
     'B', 1, N'NAT enables private internal network hosts to share one or more globally routable public IPv4 addresses, mitigating IPv4 exhaustion.'),

    (@Exam4Id, N'Which cryptographic protocol operates at the Transport layer to provide authentication and confidentiality for web browsing, email, and APIs?',
     N'IPsec', N'TLS (Transport Layer Security)', N'WPA3', N'MD5',
     'B', 1, N'TLS (the modern successor to SSL) provides end-to-end cryptographic security at the transport layer for protocols like HTTPS, FTPS, and SMTPS.'),

    (@Exam4Id, N'What is the purpose of the Time to Live (TTL) field in an IPv4 packet header?',
     N'To specify packet retransmission timeout',
     N'To prevent packets from endlessly looping in the network due to routing loops',
     N'To synchronize client and server system clocks',
     N'To determine overall socket throughput',
     'B', 1, N'Each router decrements the TTL by 1. When TTL reaches 0, the router drops the packet and transmits an ICMP Time Exceeded message back to the sender.'),

    (@Exam4Id, N'Which protocol is responsible for dynamically leasing IP addresses, subnet masks, default gateways, and DNS servers to client machines?',
     N'DNS', N'DHCP', N'SNMP', N'NTP',
     'B', 1, N'Dynamic Host Configuration Protocol (DHCP) automatically assigns and manages network parameter configurations for network clients via DORA exchange.');
END
GO

-- Insert a sample completed exam attempt for student1 (Rahul Sharma) on Exam 1 to demonstrate reporting capabilities
DECLARE @Stud1Id INT, @NetExamId INT;
SELECT @Stud1Id = [UserId] FROM [dbo].[Users] WHERE [Username] = 'student1';
SELECT @NetExamId = [ExamId] FROM [dbo].[Exams] WHERE [SubjectCode] = 'MCA-NET-501';

IF @Stud1Id IS NOT NULL AND @NetExamId IS NOT NULL AND NOT EXISTS (SELECT 1 FROM [dbo].[ExamAttempts] WHERE [StudentId] = @Stud1Id AND [ExamId] = @NetExamId)
BEGIN
    DECLARE @NewAttemptId INT;
    
    INSERT INTO [dbo].[ExamAttempts] 
        ([StudentId], [ExamId], [StartTime], [EndTime], [DurationTakenSeconds], [TotalQuestions], [AnsweredQuestions], [CorrectAnswers], [WrongAnswers], [Score], [Percentage], [Status], [IsPassed])
    VALUES 
        (@Stud1Id, @NetExamId, DATEADD(MINUTE, -12, GETDATE()), GETDATE(), 720, 10, 10, 8, 2, 8.00, 80.00, 'Completed', 1);

    SET @NewAttemptId = SCOPE_IDENTITY();

    -- Populate attempt answers from Question pool
    DECLARE @qId INT, @cOpt CHAR(1);
    DECLARE q_cursor CURSOR FOR 
        SELECT [QuestionId], [CorrectOption] FROM [dbo].[Questions] WHERE [ExamId] = @NetExamId ORDER BY [QuestionId];

    OPEN q_cursor;
    FETCH NEXT FROM q_cursor INTO @qId, @cOpt;
    DECLARE @qIndex INT = 1;

    WHILE @@FETCH_STATUS = 0
    BEGIN
        -- Make 8 questions correct, 2 questions incorrect for realistic student demonstration
        DECLARE @selOpt CHAR(1);
        DECLARE @isCorrect BIT;
        DECLARE @mark INT;

        IF @qIndex IN (3, 7) -- student made mistake on question 3 and 7
        BEGIN
            SET @selOpt = CASE WHEN @cOpt = 'A' THEN 'B' ELSE 'A' END;
            SET @isCorrect = 0;
            SET @mark = 0;
        END
        ELSE
        BEGIN
            SET @selOpt = @cOpt;
            SET @isCorrect = 1;
            SET @mark = 1;
        END

        INSERT INTO [dbo].[AttemptAnswers] ([AttemptId], [QuestionId], [SelectedOption], [CorrectOption], [IsCorrect], [MarksObtained])
        VALUES (@NewAttemptId, @qId, @selOpt, @cOpt, @isCorrect, @mark);

        SET @qIndex = @qIndex + 1;
        FETCH NEXT FROM q_cursor INTO @qId, @cOpt;
    END

    CLOSE q_cursor;
    DEALLOCATE q_cursor;

    PRINT 'Demo attempt for student1 inserted successfully with full review data.';
END
GO

PRINT '==================================================================================';
PRINT 'ExamEngineDB Database Setup Completed Successfully!';
PRINT 'Admin:    Username: admin    | Password: admin123';
PRINT 'Student1: Username: student1 | Password: student123';
PRINT 'Student2: Username: student2 | Password: student123';
PRINT '==================================================================================';
GO
