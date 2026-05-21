<div align="center">

# 🏫 School Management System

**Clean backend API built to practise EF Core fundamentals — CRUD, validation, filtering, and modular structure.**

[![Language](https://img.shields.io/badge/Language-C%23-239120?style=flat-square&logo=c-sharp&logoColor=white)](https://github.com/Youssef2508/school-management-system)
[![Framework](https://img.shields.io/badge/Framework-ASP.NET%20Core-512BD4?style=flat-square&logo=dotnet&logoColor=white)](https://github.com/Youssef2508/school-management-system)
[![ORM](https://img.shields.io/badge/ORM-Entity%20Framework%20Core-CC2927?style=flat-square&logo=microsoft-sql-server&logoColor=white)](https://github.com/Youssef2508/school-management-system)
[![DB](https://img.shields.io/badge/Database-SQL%20Server-CC2927?style=flat-square&logo=microsoft-sql-server&logoColor=white)](https://github.com/Youssef2508/school-management-system)

</div>

---

## What This Is

A backend API for managing the core entities of a school — Students, Courses, and School Supplies — built with ASP.NET Core and Entity Framework Core. The focus here was on clean project structure, proper validation rules per entity, basic filtering, and getting comfortable with EF Core's migration and configuration workflow before applying these patterns in more complex systems like the [E-Commerce API](https://github.com/Youssef2508/ECommerce-System).

---

## Project Structure

```
school-management-system/
├── Controllers/
│   ├── StudentsController.cs
│   ├── CoursesController.cs
│   └── SuppliesController.cs
├── Models/
│   ├── Student.cs
│   ├── Course.cs
│   └── SchoolSupply.cs
├── Data/
│   └── AppDbContext.cs
├── Migrations/
├── Program.cs
└── appsettings.json
```

**Architecture pattern:** Controllers → EF Core DbContext → SQL Server. No repository layer — this is intentional. This project was a focused exercise in learning EF Core before abstracting it behind interfaces. The [Inventory Management System](https://github.com/Youssef2508/inventory-management-system) and [E-Commerce API](https://github.com/Youssef2508/ECommerce-System) apply the Repository + Unit of Work layer on top of what was learned here.

---

## Entities & Validation Rules

### 👨‍🎓 Student
| Field | Type | Validation |
|---|---|---|
| StudentId | int | Auto-generated PK |
| FullName | string | Required, max 100 chars |
| Age | int | Between 5 and 18 |
| GradeLevel | string | Format: "1st", "2nd", etc. |

### 📚 Course
| Field | Type | Validation |
|---|---|---|
| CourseId | int | Auto-generated PK |
| CourseName | string | Required |
| RoomNumber | string | Must contain letters and numbers |
| MaxCapacity | int | Between 10 and 30 |

### 🛒 School Supply
| Field | Type | Validation |
|---|---|---|
| ItemId | int | Auto-generated PK |
| ItemName | string | Required |
| Price | decimal | ≥ 0 |
| QuantityAvailable | int | Items with 0 quantity are filtered from responses |

---

## API Endpoints

| Method | Endpoint | Description |
|---|---|---|
| `GET` | `/api/students` | List all students |
| `GET` | `/api/students/{id}` | Get student by ID |
| `POST` | `/api/students` | Add new student |
| `PUT` | `/api/students/{id}` | Update student |
| `DELETE` | `/api/students/{id}` | Delete student |
| `GET` | `/api/courses` | List all courses |
| `POST` | `/api/courses` | Add course |
| `PUT` | `/api/courses/{id}` | Update course |
| `DELETE` | `/api/courses/{id}` | Delete course |
| `GET` | `/api/supplies` | List available supplies (qty > 0) |
| `POST` | `/api/supplies` | Add supply |
| `PUT` | `/api/supplies/{id}` | Update supply |
| `DELETE` | `/api/supplies/{id}` | Delete supply |

---

## Getting Started

**Prerequisites:** .NET 8 SDK · SQL Server or LocalDB · Visual Studio / VS Code

```bash
# 1. Clone
git clone https://github.com/Youssef2508/school-management-system.git

# 2. Set connection string in appsettings.json
# "DefaultConnection": "Server=.;Database=SchoolDB;Trusted_Connection=True;"

# 3. Apply migrations
dotnet ef database update

# 4. Run
dotnet run

# 5. Swagger UI available at https://localhost:{port}/swagger
```

---

## Why I Built It This Way

This was a deliberate first step. Before applying the Repository Pattern and Unit of Work (which I did in the [Inventory Management System](https://github.com/Youssef2508/inventory-management-system) and [E-Commerce API](https://github.com/Youssef2508/ECommerce-System)), I wanted to understand exactly what EF Core gives you out of the box — what `DbContext` does, how migrations work, how `DbSet<T>` and LINQ translate to SQL, and where the friction points are.

The three independent tables with no foreign keys between them was intentional. The goal wasn't to model a real school — it was to practice the full EF Core workflow per entity without the added complexity of relationships and navigation properties. Relationships and joins came later once the fundamentals were solid.

The modular controller structure (one controller per entity, one `DbContext`, clean `Program.cs` DI registration) reflects the same separation-of-concerns instinct that eventually led to Clean Architecture in the E-Commerce API.

---

## Author

**Youssef Hassan** — Computer Science, Cairo University (2026)
Backend & Embedded Systems Engineer · ECPC Competitor

[![LinkedIn](https://img.shields.io/badge/LinkedIn-Connect-0077B5?style=flat-square&logo=linkedin)](https://linkedin.com/in/youssef-hassan-bab3912b9)
[![GitHub](https://img.shields.io/badge/GitHub-Youssef2508-181717?style=flat-square&logo=github)](https://github.com/Youssef2508)
