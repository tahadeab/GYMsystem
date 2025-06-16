GYM System Management Application
This repository contains a C# based desktop application for managing a GYM system. It provides functionalities for handling various aspects of a gym's operations, including client management, subscriptions, human resources, and user authentication.
Table of Contents
•	Features
•	Technologies Used
•	Getting Started
o	Prerequisites
o	Installation
•	Project Structure
•	Usage
•	Contributing
•	License
Features
•	User Authentication: Secure login system for different user roles.
•	Client Management: Add, view, update, and delete client information.
•	Subscription Management: Handle different types of subscriptions, renewals, and payments.
•	Human Resources: Manage staff information and roles.
•	Data Access Layer: Efficient and organized data handling.
•	Business Logic Layer: Separation of business rules from data access.
Technologies Used
•	C#: Primary programming language for the application logic.
•	Windows Forms (WinForms): For building the graphical user interface.
•	SQL Server (or similar database): For data storage and management (database setup is assumed).
Getting Started
Follow these instructions to get a copy of the project up and running on your local machine for development and testing purposes.
Prerequisites
•	Visual Studio (2019 or newer recommended)
•	.NET Framework (version compatible with the project, likely 4.7.2 or newer)
•	SQL Server Management Studio (or any compatible database client)
•	A configured database for the GYM system.
Installation
1.	Clone the repository or extract the ZIP file: If you have the .zip file (GymSystem.zip), extract it to your desired location.
2.	Open the Solution in Visual Studio: Navigate to the extracted folder and open GymSystemFinal Project.sln using Visual Studio.
3.	Configure Database Connection:
o	Open App.config file in the project.
o	Update the connection string (<connectionStrings>) to point to your SQL Server database. Make sure the database schema matches the application's requirements (refer to GYMsystem analysis.pdf for details).
4.	Restore NuGet Packages (if any): Visual Studio should automatically restore any necessary NuGet packages. If not, right-click on the solution in Solution Explorer and select "Restore NuGet Packages."
5.	Build the Project: From the Visual Studio menu, select Build > Build Solution (or press Ctrl+Shift+B).
Project Structure
The project is organized into several folders, reflecting a layered architecture:
•	BusinessLayer_FinalProject: Contains the business logic and rules of the application.
•	Clients: Modules related to client management.
•	DataAcciss_GymSystem: Handles all database interactions (Data Access Layer).
•	GlobalClasses: Contains common classes and utilities used throughout the application.
•	HumanResorcies: Modules for human resources management.
•	Login: Components related to user authentication and login.
•	Resources: Application resources.
•	Subscribtions: Modules for managing gym subscriptions.
•	Users: User management functionalities.
•	bin/Debug & obj/Debug: Compiled output and intermediate files.
•	App.config: Application configuration file, including database connection string.
•	Form1.cs, Form1.Designer.cs, Form1.resx: Main application form files.
•	GYMsystem analysis.pdf / تحليل نظام نادي رياضي.pdf: Design and analysis documents for the system.
•	GymSystem.zip: The complete project in a compressed archive.
•	GymSystemFinal Project.csproj: C# project file.
•	GymSystemFinal Project.sln: Visual Studio solution file.
•	Program.cs: Entry point of the application.
Usage
After successfully building the project:
1.	Run the application: Press F5 in Visual Studio or click the Start button.
2.	Login: Use the login interface to access the system.
3.	Navigate: Explore the different modules (Clients, Subscriptions, HR, etc.) to perform various management tasks.
Contributing
If you wish to contribute to this project, please fork the repository and create a pull request with your changes.
License
[Specify your license here, e.g., MIT License]
Note: The GymSystem.zip file contains the complete system, making it easy to share and deploy. Refer to GYMsystem analysis.pdf for a detailed understanding of the system's design and functionalities.
Contact
If you like the project or have suggestions, feel free to reach out! 
tahadeab201@gmail.com


