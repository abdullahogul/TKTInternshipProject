# TKT Internship Project - Task Management System Backend

This project was developed for my internship at **Tarım Kredi Teknoloji**. 
It is a backend API application for a **Task Management System**, built with **C#** and **.NET 9**.

The project allows users to create, update, delete, and manage tasks within departments. 
JWT authentication is implemented for secure access to the API.

---

## Features
This backend application is a basic task management system. 
- Users can assign tasks to any department. 
- Users can edit tasks they create.
- Users can delete tasks they create.
- Users can reject or complete the tasks assigned to their department.
- Users can list tasks they create or all tasks.
- JWT authentication for secure access.
- Seed data for users and departments is provided for quick testing.

## Technologies
- **Backend:** C# and .NET 9  
- **Database:** SQL Server (Entity Framework Core)  
- **Authentication:** JWT  
- **ORM:** Entity Framework Core  
- **Testing:** Postman Collection included  
- **Version Control:** Git / GitHub

## Setup Instructions

### 1. Clone The Repository
Clone repository to your own computer. 
```bash
git clone https://github.com/abdullahogul/TKTInternshipProject.git
```

### 2. Configure Database
- Open appsetting.json and check the connection string.
```
"DefaultSQLConnection": "Server=(localdb)\\MSSQLLocalDB;Database=TaskMs;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True"
```
- Make sure SQL Server running locally.

### 3. Build And Run
```bash
dotnet restore
dotnet build
dotnet run
```
## Seed Data
- **Departments**: Human Resources, Marketing, Sales
- **Users**: 3 users per department. 1 manager 2 employees

### Users
- `Post users/login`                       --> Login and receive JWT token.
- `Get users/all`                          --> List all users

### Tasks
- `Get Tasks/All`                          --> List all tasks
- `Get Tasks/CreatedByMe `                 --> List tasks created by user 
- `Get Tasks/MyDepartment`                 --> List tasks assigned to users department
- `Post Tasks/Create`                      --> Create new task
- `Patch Tasks/UpdateTaskByMe`             --> Update tasks created by user.
- `Patch Tasks/UpdateStatusByDepartment`   --> Update task status assigned to users department.
- `Delete Tasks/DeleteTaskByMe`            --> Delete tasks created by user.

### Department
- `Get departments/all`                     --> List all departments

## Postman Collection
- Postman collection and enviroment files are in docs folder.
- Import into postman to test all API endpoints
