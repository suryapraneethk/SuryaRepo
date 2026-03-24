# Student Management API

A RESTful Web API built with **ASP.NET Core 8** for managing student records. Supports full CRUD operations with **Entity Framework Core** for data access and **SQL Server** as the database backend. API endpoints are documented and testable via **Swagger UI**.

---

## Tech Stack

| Layer | Technology |
|---|---|
| Framework | ASP.NET Core 8 Web API |
| ORM | Entity Framework Core 8 |
| Database | Microsoft SQL Server |
| API Docs | Swagger / Swashbuckle |
| Language | C# |

---

## Features

- Get all students
- Get student by ID
- Create a new student record
- Update existing student details
- Delete a student record
- EF Core Code-First migrations for database setup
- Swagger UI for interactive API testing

---

## Project Structure

```
StudentManagementAPI/
├── Controllers/
│   └── StudentsController.cs
├── Models/
│   └── Student.cs
├── Data/
│   └── SuryaDbContext.cs
├── appsettings.json
└── Program.cs
```

---

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (or SQL Server Express)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or VS Code

### Setup

1. **Clone the repository**
   ```bash
   git clone https://github.com/your-username/student-management-api.git
   cd student-management-api
   ```

2. **Update the connection string** in `appsettings.json`
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=YOUR_SERVER;Database=StudentDB;Trusted_Connection=True;TrustServerCertificate=True"
   }
   ```

3. **Apply EF Core migrations**
   ```bash
   dotnet ef database update
   ```

4. **Run the project**
   ```bash
   dotnet run
   ```

5. **Open Swagger UI**
   ```
   https://localhost:{port}/swagger
   ```

---

## API Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/api/students` | Get all students |
| GET | `/api/students/{id}` | Get student by ID |
| POST | `/api/students` | Create new student |
| PUT | `/api/students/{id}` | Update student |
| DELETE | `/api/students/{id}` | Delete student |

---

## Sample Payload

**POST /api/students**
```json
{
  "name": "Surya Praneeth",
  "gender": "Male",
  "department": "Computer Science"
}
```

**Response**
```json
{
  "id": 1,
  "name": "Surya Praneeth",
  "gender": "Male",
  "department": "Computer Science"
}
```

---

## Database Schema

**Students Table**

| Column | Type | Nullable | Description |
|--------|------|----------|-------------|
| Id | int (PK) | No | Auto-incremented primary key |
| Name | nvarchar | Yes | Student full name |
| Gender | nvarchar | Yes | Student gender |
| Department | nvarchar | Yes | Department / branch of study |

---

## Future Enhancements

- Repository Pattern implementation
- JWT Authentication & Authorization
- Input validation with Data Annotations
- Pagination and filtering on GET endpoints
- Docker support

---

## Author

**Surya Praneeth Chandra Konda**  
[LinkedIn](https://www.linkedin.com/in/suryapraneethchandra/) | [GitHub](https://github.com/suryapraneethk)
