from fastapi import FastAPI, HTTPException

app = FastAPI()

# Example data
data = {
    "India": ["Delhi", "Mumbai", "Bangalore"],
    "USA": ["New York", "Los Angeles", "Chicago"],
    "France": ["Paris", "Lyon", "Marseille"]
}

@app.get("/cities/{country}")
def get_cities(country: str):
    country = country.title()
    if country in data:
        return {"country": country, "cities": data[country]}
    else:
        raise HTTPException(status_code=404, detail="Country not found")
