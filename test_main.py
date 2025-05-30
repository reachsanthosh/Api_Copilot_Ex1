import pytest
from fastapi.testclient import TestClient
from main import app

client = TestClient(app)

def test_get_cities_spain():
    response = client.get("/cities/Spain")
    assert response.status_code == 404
    assert response.json()["detail"] == "Country not found"

def test_get_cities_paris():
    response = client.get("/cities/France")
    assert response.status_code == 200
    assert "Paris" in response.json()["cities"]
