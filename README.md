# 🌦️ Weather App – Infrastructure with Redis, RabbitMQ, Azure Key Vault and Serilog 

This repository demonstrates infrastructure-focused patterns using **Redis for caching**, **RabbitMQ for messaging**, **Azure Key Vault for secrets**, and **Serilog for logging** in .NET REST APIs and Blazor Server Apps. These are built around a simplified Weather App use case, showing how infrastructure concerns can be modularized and cleanly integrated.

---
# Authors

## Vishwa Kumar

- **Email:** vishwa@vishwa.me
- **GitHub:** [Vishwam](https://github.com/vishwamkumar)
- **LinkedIn:** [Vishwa Kumar](https://www.linkedin.com/in/vishwamohan)

Vishwa is the primary developer and architect of this example app, responsible for the architecture and implementation of these features.


## 📦 Projects

| Project | Description |
|--------|-------------|
| `WeatherApp.RestApi.UsingBackgroundService` | Implements a background service for polling weather data at configurable intervals, with optional API-based triggering. |
| `WeatherApp.RestApi.UsingCache` | Implements Redis caching to store and retrieve weather data for optimized performance. |
| `WeatherApp.RestApi.UsingRabbitMQ`   | Implements RabbitMQ-based message queueing to asynchronously publish and process weather updates. |
| `WeatherApp.RestApi.UsingSerilog`   | Implements Serilog to log app log, transaction log and custom logs in a REST API. |
| `WeatherApp.BlazorServer.UsingSerilog`   | Implements Serilog to log app log, transaction log and custom logs in a Blazor Server App. |
| `WeatherApp.BlazorServer.UsingKeyVault`   | Implements Azure Key Vault to get stored secrets, to be used in a sample Blazor Server App. |


Each project is **self-contained** and includes its own `.sln` file for independent testing.

---

## ▶️ Getting Started

### 📋 Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) or later
- For `WeatherApp.RestApi.UsingCache`: Redis server (local or remote)
- For `WeatherApp.RestApi.UsingRabbitMQ`: RabbitMQ server (local or remote)
- For `WeatherApp.BlazorServer.UsingKeyVault`: Azure subscription with Key Vault configured

### 🔁 Clone the Repository

```bash
git clone https://github.com/VishwamKumar/WeatherApp.RestApi.UsingRedisCache.git
cd WeatherApp.RestApi.UsingRedisCache
```

## 🚀 Run a Project

Pick one of the projects to test. For example:

```bash
cd src/WeatherApp.RestApi.UsingCache
dotnet run
```

Replace `UsingCache` with `UsingRabbitMQ`, `UsingSerilog`, `UsingBackgroundService`, or navigate to the Blazor projects (`WeatherApp.BlazorServer.UsingSerilog` or `WeatherApp.BlazorServer.UsingKeyVault`) to test other patterns.


## 🧪 Test Scenarios

Each REST API project includes a `Docs/TestMe.md` file with example queries and test scenarios specific to that project's functionality.


## 📂 Folder Structure

```
infra.patterns.examples/
└── src/
    ├── WeatherApp.RestApi.UsingBackgroundService/
    ├── WeatherApp.RestApi.UsingCache/
    ├── WeatherApp.RestApi.UsingRabbitMQ/
    ├── WeatherApp.RestApi.UsingSerilog/
    ├── WeatherApp.BlazorServer.UsingSerilog/
    └── WeatherApp.BlazorServer.UsingKeyVault/
```


## 🛠️ Tech Stack

  1. .NET 9
  2. ASP.NET Core Web API
  3. Redis (via StackExchange.Redis)
  4. RabbitMQ (via RabbitMQ.Client)
  5. Serilog
  6. Azure Key Vault

---
## License
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
