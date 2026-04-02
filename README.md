# Tabela_teste

A simple C# console application that demonstrates basic SQLite database operations.

## Description

This project shows how to:
- Connect to a SQLite database
- Create a table
- Insert data
- Read and display data

## Requirements

- .NET 10.0 SDK or later
- SQLite

## Dependencies

- `Microsoft.Data.Sqlite` - SQLite database provider for .NET

## How to Build and Run

1. **Restore dependencies:**
   ```bash
   dotnet restore
   ```

2. **Build the project:**
   ```bash
   dotnet build
   ```

3. **Run the application:**
   ```bash
   dotnet run
   ```

## What It Does

When you run the application, it:

1. Creates a SQLite database file called `users.db` (if it doesn't exist)
2. Creates a `USERS` table with the following structure:
   - `ID` - Auto-incrementing primary key
   - `Name` - Text field (required)
   - `Age` - Integer field
3. Inserts two sample records:
   - Ana, 25 years old
   - Rui, 40 years old
4. Reads all records from the table and displays them in the console

## Expected Output

```
Id: 1, Nome: Ana, Idade: 25
Id: 2, Nome: Rui, Idade: 40
```

## Project Structure

```
Tabela_teste/
├── Program.cs           # Main application code
├── Tabela_teste.csproj  # Project file
├── Tabela_teste.sln     # Solution file
├── users.db             # SQLite database (created after first run)
└── README.md            # This file
```

## License

This project is for educational purposes.