🎓 School Management System

📌 Overview
- This project is a simple School Management System built using ASP.NET Core & Entity Framework Core.
It demonstrates CRUD operations, basic validation, and clean architecture principles across multiple independent entities.

- Unlike complex systems, this project focuses on:
  - Simplicity
  - Data integrity
  - Clean separation of concerns

🎯 Objective
The goal of this project is to:
- Practice Entity Framework Core
- Implement CRUD operations
- Apply validation rules
- Structure a clean backend project

🧠 System Design
🔹 Key Characteristics
- Educational theme (Students, Courses, Supplies)
- No foreign keys (independent tables)
- Basic validation rules
- Simple filtering
- Each entity handles its own logic

🗃️ Database Tables
- 👨‍🎓 Students
  -Fields:
    - StudentId
    - FullName
    - Age
    - GradeLevel

  - Validation:
    - Age must be between 5 → 18
    - Grade format: "1st", "2nd", ...

- 📚 Courses
  - Fields:
    - CourseId
    - CourseName
    - RoomNumber
    - MaxCapacity
  
  - Validation:
    - Room must contain letters & numbers
    - Capacity: 10 → 30 students

- 🛒 School Supplies
  - Fields:
    - ItemId
    - ItemName
    - Price
    - QuantityAvailable
  
  - Validation:
    - Price ≥ 0
    - Hide items with 0 quantity

⚙️ Features
- Add / Update / Delete / Get data (CRUD)
- Input validation
- Basic filtering (e.g., available supplies)
- Independent modules لكل entity
- Clean separation between layers

🚀 Technologies Used
- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- LINQ

▶️ How to Run
- Open project in Visual Studio
- Configure connection string in appsettings.json
- Run migrations:
  - Add-Migration InitialCreate
  - Update-Database
- Run the project
- Test APIs using Postman / Swagger
