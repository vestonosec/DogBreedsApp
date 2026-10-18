# DogBreedsApp - ASP.NET Core MVC Application

## 🐾 Project Overview
**DogBreedsApp** is a web application designed for dog lovers, owners, and enthusiasts to explore, manage, and learn about various dog breeds, their breed groups, and specific care requirements.

This project is developed as an assignment for the **ASP.NET Fundamentals** course, demonstrating core MVC architecture, Entity Framework Core integration, 3-tier structure principles, and full CRUD operations.

---

## 🛠️ Technologies Used
- **Framework:** .NET 9.0 (ASP.NET Core MVC)
- **Database:** Microsoft SQL Server (LocalDB)
- **ORM:** Entity Framework Core 9.0
- **Frontend:** Razor Views, HTML5, CSS3, Bootstrap 5
- **Tooling & VCS:** Visual Studio 2022, Git & GitHub

---

## 🏗️ Domain Models & Architecture
The application is built around 3 main domain entities:
1. **`DogBreed` (Main Entity):** Represents individual dog breeds with attributes such as Name, Short Description, Origin, Average Lifespan, Energy Level, Image URL, and relationships to Breed Group and Care Requirement.
2. **`BreedGroup`:** Categorizes breeds into groups (e.g., Sporting & Retrievers, Herding, Companion / Toy).
3. **`CareRequirement`:** Stores detailed care guidelines (grooming needs, daily exercise requirements, training ease, special diet notes).

---

## 🌟 Key Features
- **Explore Breeds:** Interactive catalog displaying dog breeds in structured Bootstrap cards.
- **Breed Details:** Deep-dive view showing origin, energy level, lifespan, and full care requirements.
- **Full CRUD Operations:** Create, Read, Update, and Delete capabilities for dog breeds with server-side and client-side validation.
- **Breed Groups Overview:** Grouped view showing categories and registered breed counts.

---

## 🚀 Getting Started & Setup Instructions

### Prerequisites
- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) with the **ASP.NET and web development** workload.
- **SQL Server Express LocalDB** (included with Visual Studio).

### Installation & Local Setup

1. **Clone / Open Repository:**
   Open the solution in Visual Studio 2022.

2. **Configure Database Connection String:**
   The connection string is pre-configured in `appsettings.json` using LocalDB:
   ```json
   "ConnectionStrings":
   {
     "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=DogBreedsDb;Trusted_Connection=True;MultipleActiveResultSets=true"
   }
3.  **Apply Migrations & Seed Database:**
   Open the **Package Manager Console** in Visual Studio and run:
   ```powershell
   Update-Database
   ```
   This will create the database schema and seed initial data.
   4. **Run the Application:**