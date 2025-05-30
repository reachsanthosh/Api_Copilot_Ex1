# FastAPI Cities API Project

## Overview

This project demonstrates a simple API to retrieve cities by country/region, implemented in three different technologies: Python (FastAPI), Node.js (Express), and .NET (ASP.NET Core Minimal API). Each section below provides setup, run, and test instructions for its respective stack.

---

## Python (FastAPI)

### Files

- `main.py`: FastAPI app exposing `/cities/{country}`
- `test_main.py`: Pytest tests for the API

### Setup & Run

```powershell
# Install dependencies
pip install fastapi uvicorn pytest httpx

# Run the API server
uvicorn main:app --reload
```

- API: http://127.0.0.1:8000
- Docs: http://127.0.0.1:8000/docs

### Test

```powershell
pytest test_main.py
```

---

## Node.js (Express)

### Files

- `node/app.js`: Express app exposing `/cities/:country`
- `node/app.test.js`: Jest/Supertest tests for the API
- `node/package.json`: Project config and scripts

### Setup & Run

```powershell
# Change directory to node folder
cd node

# Install dependencies
npm install

# Start the server
node app.js
```

- API: http://localhost:3000/cities/India

### Test

```powershell
# If you see a script execution policy error, run this first:
Set-ExecutionPolicy -Scope Process -ExecutionPolicy Bypass

# Then run tests
npm test
```

---

## .NET (ASP.NET Core Minimal API)

### Files

- `dotnet/Program.cs`: Minimal API exposing `/cities/{country}`
- `dotnet/CitiesApiTests.cs`: xUnit integration tests
- `dotnet/CitiesApi.csproj`: Project file

### Setup & Run

```powershell
# Change directory to dotnet folder
cd dotnet

# Restore dependencies
 dotnet restore

# Run the API server
 dotnet run
```

- API: http://localhost:5000/cities/India (or as shown in console)

### Test

```powershell
# If you get a file lock error, ensure no server is running (Ctrl+C), or delete the exe in bin/Debug/net8.0
# Run tests
 dotnet test
```

---

## General

- `.gitignore` is set up to ignore build, cache, and dependency folders for all stacks.
- Each stack is self-contained; follow the section relevant to your technology.

Feel free to extend or modify any section as needed for your use case!
