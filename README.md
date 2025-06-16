# HabitTracker

This is the backend API for a personal habit-tracking application, built with:

- ASP.NET Core Web API (.NET 8)
- SQL Server (EF Core Code-First)
- Angular frontend (coming soon)

---

## 🔧 Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/)
- SQL Server
- Visual Studio 2022+ or VS Code

### Setup

1. **Clone the repository:**

    ```bash
     git clone https://github.com/yourusername/HabitTracker.git
     cd HabitTracker
    ```
    
2. **Set up the connection string:**

    > 💡 This project uses [User Secrets](https://learn.microsoft.com/en-us/aspnet/core/security/app-secrets/) for local configuration.
    > You can find required keys in `appsettings.json`, and override them using `dotnet user-secrets` or update the strings directly in `appsettings.json`.
   
    ```bash
    dotnet user-secrets init
    dotnet user-secrets set "ConnectionStrings:DefaultConnection" "your-sql-connection-string"
    ```
    
4. Apply database migrations:

    ```bash
    dotnet ef database update --project HabitTracker.Infrastructure --startup-project HabitTracker
    ```
    
### Running The Application

  ```bash
  dotnet run --project HabitTracker
  ```

Navigate to https://localhost:5001/swagger to explore the API.

---

## 📄 License

This project is licensed under the [MIT License](License.txt).
