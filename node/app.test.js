const request = require('supertest');
const express = require('express');
const app = require('./app');

// If app.js exports the app instance, use it directly. Otherwise, refactor app.js to export the app for testing.
describe('GET /cities/:country', () => {
  it('should return 200 and cities for France', async () => {
    const res = await request(app).get('/cities/France');
    expect(res.statusCode).toEqual(200);
    expect(res.body.cities).toContain('Paris');
  });

  it('should return 404 for Spain', async () => {
    const res = await request(app).get('/cities/Spain');
    expect(res.statusCode).toEqual(404);
    expect(res.body.detail).toBe('Country not found');
  });
});
