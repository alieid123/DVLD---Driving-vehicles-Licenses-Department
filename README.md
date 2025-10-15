<h1 align="center">🚗 Driving & Vehicle License Department (DVLD)</h1> <p align="center"> 🧠 A complete <strong>Driving License Management System</strong> built with <strong>C# (.NET Framework)</strong>, <strong>WinForms</strong>, <strong>ADO.NET</strong>, and <strong>SQL Server</strong>. </p> <p align="center"> ⚙️ Realistic Workflow | 🧾 Multi-Service System | 🔐 User Roles & Permissions </p>
💡 Overview

The DVLD Management System simulates the real-world workflow of a governmental department that handles the issuance, renewal, suspension, and management of driving licenses.

It was developed as part of the ProgrammingAdvices.com Project Series, implementing a 3-Tier Architecture (Presentation, Business Logic, Data Access) to ensure scalability, modularity, and maintainability.

🚀 Features
---
✅ Core Modules
---
Applicant registration & license request management

Full license lifecycle (issue, renew, replace, suspend, unblock)

Multi-level test system (medical, theoretical, and practical)

User & Person management (unique National Number)

License class management and fee configuration

✅ 3-Tier Architecture
---
Clear separation between UI, business logic, and data access layers

Easier maintenance and scalability

✅ License Services
---
🆕 First-Time License Issue

🔁 Re-Test Request

♻️ License Renewal

📄 Replace Lost/Damaged License

🔓 Unblock Suspended License

🌍 International License Issue


| Test                | Description                           | Fees            |
| ------------------- | ------------------------------------- | --------------- |
| 👁️ Vision Test     | Ensures applicant’s visual capability | $10             |
| 📘 Theoretical Test | Covers road rules and safety          | $20             |
| 🚗 Practical Test   | Real driving evaluation               | Varies by class |


| Class | Description           | Min Age | Validity | Fees |
| :---: | --------------------- | :-----: | :------: | :--: |
|   1   | Small Motorcycle      |    18   |  5 years |  $15 |
|   2   | Heavy Motorcycle      |    21   |  5 years |  $30 |
|   3   | Private Car           |    18   | 10 years |  $20 |
|   4   | Taxi / Limousine      |    21   | 10 years | $200 |
|   5   | Agricultural Vehicles |    21   | 10 years |  $50 |
|   6   | Medium Buses          |    21   | 10 years | $250 |
|   7   | Heavy Trucks          |    21   | 10 years | $300 |

✅ System Management
---
👥 Manage Users (add, update, delete, freeze)

🧍 Manage Persons (unique national records)

🗃 Manage Requests (filter & view all license requests)

🧾 Manage Tests & Classes (update fees & requirements)

🕓 Audit Logs (track user actions and timestamps)

| Technology             | Description                        |
| ---------------------- | ---------------------------------- |
| 💻 C#                  | Application logic & business rules |
| 🪟 Windows Forms       | Desktop user interface             |
| 🔗 ADO.NET             | Data access & database operations  |
| 🗄️ SQL Server         | Backend database                   |
| 🧩 3-Tier Architecture | UI, BLL, and DAL structure         |

Follow these steps to set up and run the project locally 👇

1️⃣ Clone the Repository
---
git clone https://github.com/alieid123/DVLD---Driving-vehicles-Licenses-Department.git
cd DVLD---Driving-vehicles-Licenses-Department

2️⃣ Import the Database
---
Locate the SQL backup file (e.g., DVLD.bak).

In SQL Server Management Studio (SSMS) → Right-click Databases → Restore Database → From Device...

Select the .bak file and restore it.

3️⃣ Update the Connection String
---
Open the project in Visual Studio.

Go to:

/DataAccessLayer/clsDVLDSettings.cs

Find and edit the connection string based on your local setup:

4️⃣ Build & Run
---
Build the solution → Ctrl + Shift + B

Run the app → F5 or ▶ button

The login screen will load and connect to your configured database

👨‍💻 About the Developer
---
Hi, I'm Ali Eid — a passionate .NET Developer and Computer Science student.
This project reflects my learning journey in software architecture, database systems, and desktop development.
I'm always improving and building new projects — stay tuned!

📧 ydly429@gmail.com

🔗 https://www.linkedin.com/in/aly-eid-867583345?utm_source=share&utm_campaign=share_via&utm_content=profile&utm_medium=android_app

🖼️ UI Preview
---
Here are some screenshots of the DVLD Management System in action 👇
### 🔐 Login Form
![Main](screenshorts/Main.png)

