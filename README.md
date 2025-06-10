# AutoFinance Platform

A full-stack automotive finance prototype built with **.NET Core Web API (C#)** and **React + TypeScript**, designed to simulate a real-world vehicle leasing quote system. This project demonstrates modern software engineering practices including **containerization**, **clean architecture**, and **CI/CD readiness**.

---

## 🚀 Features

- RESTful Lease Quote API (C# / .NET Core)
- React + TypeScript frontend for user input and quote display
- Quote calculation based on car model and lease duration
- Containerized with Docker + Docker Compose
- Configurable with `.env` for local setup
- Extensible for future cloud deployment (AWS ECS or Azure App Services)
- Unit test examples and logging with `ILogger`
- Optional GitHub Actions CI/CD workflow

---

## 🛠️ Tech Stack

| Layer        | Technology                         |
|-------------|-------------------------------------|
| Backend      | .NET Core Web API (C#), xUnit       |
| Frontend     | React, TypeScript, Axios            |
| Container    | Docker, Docker Compose              |
| DevOps       | GitHub Actions (optional)           |
| Versioning   | Git, GitHub                         |
| Config       | .env                                |

---

## 📦 Setup Instructions

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download)
- [Node.js & npm](https://nodejs.org/)
- [Docker Desktop](https://www.docker.com/products/docker-desktop)

### 1. Clone the Repository

```bash
git clone https://github.com/yourusername/autofinance-platform.git
cd autofinance-platform
