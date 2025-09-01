# TKT Internship Project - Task Management System Backend

This project was developed for my internship at **Tarım Kredi Teknoloji**. 
It is a backend API application for a **Task Management System**, built with **C# and .NET 9**.

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
```bash
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
- **Users**: 3 users per department. 1 m-> List all tasks

### Department
- `Get departments/all`          --> List all 

### Task
- `Get tasks/all`                --> List all tasks
- `Get tasks/createdByMe `       --> List tasks created by user 
- `Get tasks/mydepartment`       --> List tasks assigned to esuers department
- `Post tasks/creeate`           --> Create new task
- `Patch tasks updatetaskbyme`   --> Update tasks created by user.
- `Delete tasks/deletetasksbyme` --> Delete tasks created by user.

### Users
- `Post users/login`             --> Login and receive JWT token.
- `Get users/all`                --> List all users
