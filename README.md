# ProjectBoardApp

A simple project management web application designed for organizing tasks within projects. The application utilizes the Model-View-Controller (MVC) architectural approach and incorporates .NET's default front-end page layout.

The application has been deployed to an AWS EC2 instance using Nginx. The instance is currently in a stopped state to avoid costs but can be activated for demonstration purposes.

## Technologies Used

- ASP.NET Core MVC
- PostgreSQL
- Docker & Docker Desktop
- AWS EC2
- Nginx

## Local Execution

Two options are available for running the application locally:

### 1. Dockerized Setup (simpler)

This method allows you to run the application and its database using Docker, without the need for local installations of .NET and PostgreSQL.

**Prerequisites:**
- Docker Desktop

**Steps:**
1.  Clone or download this repository to your local machine.
2.  Navigate to the project's root directory (where `docker-compose.yml` is located) in your terminal.
3.  **Start services:**
    For the initial run, use:
    ```bash
    docker-compose up --build -d
    ```
    For subsequent runs:
    ```bash
    docker-compose up -d
    ```
    This process builds the application image and starts both the web application and the PostgreSQL database service in the background. The database schema will be automatically applied upon application startup.
4.  **Access the application:** Open your web browser and navigate to: [http://localhost:5000](http://localhost:5000)

### 2. Local Environment Setup

**Prerequisites:**
- PostgreSQL
- .NET 8

**Steps:**
1.  Clone or download this repository.
2.  Ensure PostgreSQL is running and accessible. You may need to configure the database connection string in `appsettings.json` (e.g., set `Host` to `localhost` or your local PostgreSQL host) to point to your local PostgreSQL instance, as the default configuration targets the Docker network.
3.  **Apply database migrations:**
    Navigate to the project directory containing your `.csproj` file and run:
    ```bash
    dotnet ef database update
    ```
4.  **Run the application:**
    ```bash
    dotnet run
    ```
5.  **Access the application:** The application will typically be available at `http://localhost:5000` or a port specified by ASP.NET Core during startup.
