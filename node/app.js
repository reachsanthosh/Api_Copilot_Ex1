const express = require('express');
const app = express();
const port = 3000;

// Example data
const data = {
  India: ['Delhi', 'Mumbai', 'Bangalore'],
  USA: ['New York', 'Los Angeles', 'Chicago'],
  France: ['Paris', 'Lyon', 'Marseille']
};

app.get('/cities/:country', (req, res) => {
  const country = req.params.country.charAt(0).toUpperCase() + req.params.country.slice(1).toLowerCase();
  if (data[country]) {
    res.json({ country, cities: data[country] });
  } else {
    res.status(404).json({ detail: 'Country not found' });
  }
});

app.listen(port, () => {
  console.log(`Server running at http://localhost:${port}`);
});

module.exports = app;
