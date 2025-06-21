# 💊 Pharmacy Management System (C#)

A fully functional Pharmacy Management System developed in **C#**, designed to streamline day-to-day operations in a pharmacy, including managing medicines, handling sales, and maintaining inventory.

---

## 🖥️ Technology Stack

- **Language**: C#
- **Framework**: .NET (Windows Forms or WPF)
- **Database**: MS SQL Server / LocalDB (confirm based on implementation)
- **UI**: Windows Forms (WinForms)

---

## 🎯 Key Features

- 🧾 **Medicine Management**: Add, update, delete medicines with quantity, expiry, and price.
- 📦 **Inventory Tracking**: Automatic updates when stock is sold or added.
- 💳 **Billing Module**: Generate printable invoices for sales.
- 📈 **Reporting**: View daily sales, stock levels, and expired medicine reports.
- 🔐 **Authentication**: Login system with role-based access (Admin/Staff).

---

## 📁 Project Structure

```

PharmacyManagementSystem/
├── bin/
├── obj/
├── Forms/
│   ├── LoginForm.cs
│   ├── Dashboard.cs
│   └── MedicineForm.cs
├── Program.cs
├── Database.cs
└── README.md

````

---

## 🛠️ Setup Instructions

1. **Clone the repository**

```bash
git clone https://github.com/abd12315/PharmacyMangementSystem.git
````

2. **Open the solution in Visual Studio**

* Double-click the `.sln` file or open it via **File > Open > Project/Solution**.

3. **Restore NuGet Packages** (if applicable)

* Right-click the solution > **Restore NuGet Packages**

4. **Configure Database**

* Open `Database.cs` and configure your SQL connection string.
* Run the provided SQL script (if available) to create necessary tables.

5. **Build & Run**

* Press `F5` or click **Start Debugging**.

---

## 📸 Screenshots *(Optional)*

*Add screenshots of your UI here to make your project stand out.*

---

## 🚀 Future Improvements

* [ ] Expiry date alerts and reminders
* [ ] Backup and restore functionality
* [ ] Barcode scanner integration
* [ ] Switch to WPF for modern UI
* [ ] Add testing and logging features

---

## 🤝 Contributing

1. Fork the repo
2. Create a new branch: `feature/YourFeature`
3. Commit your changes
4. Open a Pull Request

---

## 📄 License

MIT License — see [LICENSE](LICENSE) for more information.

---

## 🙌 Credits

Made with 💙 by [Abdullah Shaheer](https://github.com/abd12315)
