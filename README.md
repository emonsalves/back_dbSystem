# dbSystem Solution

This solution is a .NET 8 project that includes multiple projects to manage a database system. The solution is structured into different layers: API, Application, Domain, and Infrastructure.

## Projects

### dbSystem.Api

This is the main entry point of the application, exposing RESTful APIs.

- **Target Framework**: .NET 8
- **Dependencies**:
  - `dotenv.net` (v3.2.1)
  - `Swashbuckle.AspNetCore` (v6.6.2)
- **Project References**:
  - `dbSystem.Application`
  - `dbSystem.Domain`
  - `dbSystem.Infrastructure`

#### Configuration

The `appsettings.Development.json` file includes configuration settings for logging and database connection.

{ "Logging": { "LogLevel": { "Default": "Information", "Microsoft.AspNetCore": "Warning" } }, "AllowedHosts": "*", "ConnectionStrings": { "DefaultConnection": "Server=.;Database=MyDb;Trusted_Connection=True;MultipleActiveResultSets=true" } }

Additionally, the application uses a `.env` file to manage environment variables. Ensure you have a `.env` file in the root of your project with the following content:

POSTGRES_CONNECTION_STRING=Host=localhost;Database=MyDb;Username=myuser;Password=mypassword

### dbSystem.Application

This project contains the application logic and services.

- **Target Framework**: .NET 8

### dbSystem.Domain

This project contains the domain models and interfaces.

- **Target Framework**: .NET 8

### dbSystem.Infrastructure

This project contains the data access logic and repository implementations.

- **Target Framework**: .NET 8
- **Dependencies**:
  - `Microsoft.EntityFrameworkCore.SqlServer` (v9.0.0)
  - `Microsoft.Extensions.Configuration.Json` (v9.0.0)
  - `Npgsql.EntityFrameworkCore.PostgreSQL` (v9.0.2)
- **Project References**:
  - `dbSystem.Application`
  - `dbSystem.Domain`

## Getting Started

### Prerequisites

- .NET 8 SDK
- SQL Server or PostgreSQL

### Setup

1. Clone the repository.
2. Navigate to the `dbSystem.Api` directory.
3. Create a `.env` file in the root of your project with the following content:

POSTGRES_CONNECTION_STRING=Host=localhost;Database=MyDb;Username=myuser;Password=mypassword

4. Update the connection string in `appsettings.Development.json` if necessary.
5. Run the following command to restore dependencies and build the solution:

dotnet build

6. Run the application:

dotnet run


### Running Tests

To run the tests, navigate to the test project directory and use the following command:


## Contributing

Contributions are welcome! Please open an issue or submit a pull request.

## License

This project is licensed under the MIT License.
