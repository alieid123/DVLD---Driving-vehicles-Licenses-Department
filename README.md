🚗 Driving & Vehicle License Department (DVLD) – Management System

A Driving License Management System that simulates the real-world operations of a governmental driving and vehicle licensing department.
This project was developed as part of the ProgrammingAdvices.com DVLD Project Series to apply real-world software engineering concepts, database design, and system architecture.

🧩 Overview

The DVLD System is a comprehensive application that handles the process of:

Registering applicants

Managing driving license requests

Handling various services (first-time issue, renewals, replacements, etc.)

Managing tests (medical, theory, and practical)

Issuing, renewing, suspending, or reactivating licenses

🛠️ Main Features
🧑‍💼 User & Person Management

Add, edit, delete, and search for system users.

Assign roles and permissions.

Manage personal information (National No., name, birth date, address, etc.).

🧾 License Services

First-Time License Issue

Choose the license class (motorcycle, car, truck, etc.)

Check eligibility based on age and previous licenses.

Complete all required tests.

Re-Test Request

Allows applicants who failed a test to retake it.

License Renewal

Renew expired licenses after passing a vision test.

Replace Lost License

Issue a replacement for a lost license.

Replace Damaged License

Issue a replacement for a damaged license.

Unblock Suspended License

Unlock a held license after paying fines.

International License Issue

Issue an international license for holders of valid local car licenses.

📚 License Classes

| Class | Description           | Min Age | Validity | Fees |
| ----- | --------------------- | ------- | -------- | ---- |
| 1     | Small Motorcycle      | 18      | 5 years  | $15  |
| 2     | Heavy Motorcycle      | 21      | 5 years  | $30  |
| 3     | Private Car           | 18      | 10 years | $20  |
| 4     | Taxi / Limousine      | 21      | 10 years | $200 |
| 5     | Agricultural Vehicles | 21      | 10 years | $50  |
| 6     | Medium Buses          | 21      | 10 years | $250 |
| 7     | Heavy Trucks          | 21      | 10 years | $300 |

🧪 Required Tests

Applicants must pass the following tests in order:

Vision Test – $10

Verifies eyesight health.

Theoretical Test – $20

Questions about driving rules and road safety.

Practical Test – Fee varies by license class.

Real-world driving skills evaluation.

⚙️ System Management

Manage Users – Add, update, freeze, or delete accounts.

Manage Persons – Maintain unique records based on National Number.

Manage Requests – Filter and view all license-related requests.

Manage Tests & Classes – Update fees, durations, and requirements.

Audit Logs – Track all system actions with timestamps and user info.

🧱 Technologies Used

C# / .NET Framework

Windows Forms (WinForms)

ADO.NET for Database Connectivity

SQL Server Database

3-Tier Architecture (Presentation – Business Logic – Data Access)

🧠 Key Learning Outcomes

Designing a realistic government workflow system

Implementing multi-tier architecture

Building dynamic forms and database-driven UIs

Applying CRUD operations and validation rules

Managing user permissions and roles


🚀 How to Run the Application

Follow these steps to set up and run the project locally:
1. Clone the Repository
git clone https://github.com/alieid123/DVLD---Driving-vehicles-Licenses-Department
cd DVLD---Driving-vehicles-Licenses-Department

2. Import the Database

Inside the project folder, locate the SQL backup file (e.g., DVLD.bak).

Restore it in SQL Server Management Studio (SSMS).

Right-click on Databases → Restore Database → From Device...

Select the .bak file and restore it.

3. Update the Connection String

Open the project in Visual Studio.

Go to the Data Access Layer and open the file:

/DataAccessLayer/clsDVLDSettings.cs

Find the connection string line and modify it according to your local SQL Server setup, for example

Save the changes.

4. Build and Run

Build the solution (Ctrl + Shift + B).

Run the application (F5 or ▶ button).

The system will load the login screen and connect to your configured database.

📜 Author

Ali Eid
📧 [ydly429@gmail.com]
💼 [https://www.linkedin.com/in/aly-eid-867583345?utm_source=share&utm_campaign=share_via&utm_content=profile&utm_medium=android_app]


