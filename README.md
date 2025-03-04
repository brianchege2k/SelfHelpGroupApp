# Self Help Group Ledger App

This project is a Blazor WebAssembly application with an ASP.NET Core API backend using PostgreSQL for managing self-help group members, transactions, balances, and history.

# 🚀 Features

Member management (Add, View, List members)

Deposit & Withdrawal transactions

Member balance tracking

Transaction history per member

Modern UI with Bootstrap 5


# 🏗️ Project Structure

```bash
/SelfHelpGroupSolution
 ├── SelfHelpGroupApp/    # Blazor WebAssembly frontend
 ├── SelfHelpGroupAPI/    # ASP.NET Core API backend
 ├── SelfHelpGroupSolution.sln  # Solution file
 ├── README.md
 ├── .gitignore

 ```

 # 🔧 Prerequisites

.NET 9.0.2

PostgreSQL

Visual Studio / VS Code


# 🚀 Setup Instructions

### clone this repository
```bash

git clone https://github.com/brianchege2k/SelfHelpGroupApp.git

```

### 🖥️ Backend Setup (ASP.NET Core API)
```bash
```
cd SelfHelpGroupAPI
### 1. Install dependencies
```bash

dotnet restore
```
### 2. Configure database

```bash
    "ConnectionStrings": {
      "DefaultConnection": "Host=localhost;Port=5432;Database=selfhelpXdatabase;Username=postgres;Password=your-password"
    }
  
```

### 3. Apply migrations
```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

### 4. Run the backend
``` bash
dotnet run

```
### 🌐 Frontend Setup (Blazor WebAssembly)

```bash
cd SelfHelpGroupApp

```
### 1. Install the frontend dependencies
```bash

dotnet restore

```
### 2. Run the frontend
```bash

dotnet run
```


