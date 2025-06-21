🏥 Pharmacy Management System

A robust and user-friendly desktop application designed to streamline the operations of a pharmacy. This system provides comprehensive tools for managing inventory, sales, customers, and more, ensuring efficient and accurate pharmacy workflows.

✨ Features

Product Management: Easily add, update, and remove pharmaceutical products. Track stock levels, pricing, and expiration dates.

Sales & Transactions: Process sales efficiently, generate invoices, and manage customer purchases.

Inventory Control: Monitor stock in real-time, receive low-stock alerts, and manage supplier orders to prevent shortages.

Customer Management: Maintain a detailed database of customers, including purchase history and contact information.

Reporting: Generate insightful reports on sales, inventory, and other key metrics to aid in decision-making.

User Authentication: Secure login system to manage different user roles (e.g., administrator, pharmacist, sales assistant).

Intuitive User Interface: A clean and easy-to-navigate Windows Forms interface designed for quick adoption.

🚀 Getting Started

Follow these instructions to get a copy of the project up and running on your local machine for development and testing purposes.

Prerequisites

Visual Studio: Version 2019 or later (Community, Professional, or Enterprise). Download Visual Studio.

.NET Framework: The project targets a specific .NET Framework version (e.g., 4.7.2 or 4.8). Ensure you have the necessary developer packs installed with Visual Studio.

SQL Server (or LocalDB): The application likely uses SQL Server for database management.

If using SQL Server Express or a full SQL Server instance, ensure it's installed and accessible.

If using LocalDB (often installed with Visual Studio), no extra setup might be needed beyond ensuring the connection string is correct.

Installation

Clone the repository:

git clone https://github.com/abd12315/PharmacyMangementSystem.git

Navigate into the project directory:

cd PharmacyMangementSystem/WindowsFormsApp1/Pharmacy Management

Open in Visual Studio:

Locate the .sln (solution) file (e.g., Pharmacy Management.sln) within the cloned directory.

Double-click the .sln file to open the project in Visual Studio.

Restore NuGet Packages:

Visual Studio should automatically prompt you to restore any missing NuGet packages. If not, right-click on the solution in Solution Explorer and select "Restore NuGet Packages."

Database Setup (Important!):

Review the App.config or Web.config file (or connectionString in code) for database connection details. You will need to ensure your local SQL Server instance name and database name match what's expected by the application.

If a database script (.sql file) is provided in the repository, execute it on your SQL Server instance to create the necessary tables and populate initial data.

Example Connection String (check your project for the actual one):

<connectionStrings>
    <add name="DefaultConnection" connectionString="Data Source=YourSqlServerInstanceName;Initial Catalog=PharmacyDB;Integrated Security=True" providerName="System.Data.SqlClient" />
</connectionStrings>

Replace YourSqlServerInstanceName with your actual SQL Server instance name (e.g., (localdb)\MSSQLLocalDB or .\SQLEXPRESS).

Running the Application

Once the project is loaded in Visual Studio and the database is set up, press F5 or click the "Start" button in Visual Studio to build and run the application.

📸 Screenshots / Demo

(Add screenshots or GIFs here to showcase your application's interface and key functionalities. This significantly boosts the appeal of your README!)

🛠️ Technologies Used

C#

.NET Framework (e.g., 4.7.2, 4.8)

Windows Forms (WinForms)

SQL Server (for database management)

🤝 Contributing

Contributions are what make the open-source community such an amazing place to learn, inspire, and create. Any contributions you make are greatly appreciated.

Fork the Project

Create your Feature Branch (git checkout -b feature/AmazingFeature)

Commit your Changes (git commit -m 'Add some AmazingFeature')

Push to the Branch (git push origin feature/AmazingFeature)

Open a Pull Request

📄 License

Distributed under the MIT License. See LICENSE for more information.
(If you don't have a LICENSE file, you should create one! MIT is a common and permissive choice.)

✉️ Contact

Abdullah - your.email@example.com

Project Link: https://github.com/abd12315/PharmacyMangementSystem
