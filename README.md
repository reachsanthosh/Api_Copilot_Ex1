# FastAPI Cities API Project

## Overview

This project is a simple FastAPI application that exposes an API endpoint to retrieve the cities of a given country or region. It also includes automated tests to verify the API's behavior.

## Project Structure

- `main.py`: The main FastAPI application. Defines a single route `/cities/{country}` that returns a list of cities for the specified country if available.
- `test_main.py`: Contains automated tests for the API using pytest and FastAPI's TestClient.

## Requirements

- Python 3.7+
- FastAPI
- Uvicorn
- pytest
- httpx

## Installation

1. Open PowerShell and navigate to the project directory:
   ```powershell
   cd "Application path"
   ```
2. Install the required packages:
   ```powershell
   pip install fastapi uvicorn pytest httpx
   ```

## Running the API Server

Start the FastAPI server with Uvicorn:

```powershell
uvicorn main:app --reload
```

- The API will be available at: http://127.0.0.1:8000
- Interactive API docs: http://127.0.0.1:8000/docs

## Example Usage

- To get cities in France:
  - Visit: http://127.0.0.1:8000/cities/France
- To get cities in a country not in the data (e.g., Spain):
  - Visit: http://127.0.0.1:8000/cities/Spain (returns 404)

## Running Tests

Run the automated tests with:

```powershell
pytest test_main.py
```

## Summary

- `main.py` exposes a REST API for cities by country.
- `test_main.py` contains tests for both existing and non-existing countries.
- All dependencies can be installed with pip.
- The project is ready for extension and experimentation with FastAPI.
