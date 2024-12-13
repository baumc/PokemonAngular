# Angular C# Competency Project

This repository demonstrates proficiency in **Angular**, **C#**, **Bootstrap**, and integration with external APIs. The project is a web application that utilizes the **PokeAPI** to fetch and display Pokémon data, features a **Bootstrap-based frontend** for styling, and implements **ASP.NET Core Identity** for user authentication and management.

## Features

- **Angular Frontend**:
  - Responsive design powered by **Bootstrap**.
  - Integration with the **PokeAPI** to display Pokémon data dynamically.
  - Organized component-based architecture.
  
- **C# Backend**:
  - ASP.NET Core backend for handling API requests and managing user authentication.
  - Implements **ASP.NET Core Identity** for secure login, registration, and role management.

- **API Integration**:
  - Fetches data from the **PokeAPI** using HTTP client services in Angular.
  - Displays Pokémon details (e.g., name, type, abilities).

- **Authentication**:
  - Users can register, log in, and log out securely.
  - Password hashing and role-based access control using **ASP.NET Core Identity**.

## Technology Stack

### Frontend
- **Angular**: TypeScript-based frontend framework.
- **Bootstrap**: CSS framework for responsive design.
- **TypeScript**: Typed JavaScript superset for scalable code.

### Backend
- **C# / ASP.NET Core**: Backend framework for building APIs and handling business logic.
- **ASP.NET Core Identity**: Secure user management system.
- **Entity Framework Core**: ORM for data persistence.

### External API
- **PokeAPI**: Public RESTful API for Pokémon data.

## Prerequisites

- **Node.js**: For Angular CLI and frontend dependencies.
- **.NET SDK**: To run and develop the backend.
- **SQL Server**: For ASP.NET Core Identity data storage (or another supported database).
- **Angular CLI**: For managing and building the Angular frontend.

## Setup

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/your-username/angular-csharp-competency-project.git
   cd angular-csharp-competency-project
   ```

2. **Backend Setup**:
   - Navigate to the backend project folder:
     ```bash
     cd Backend
     ```
   - Update the `appsettings.json` file with your database connection string.
   - Apply database migrations:
     ```bash
     dotnet ef database update
     ```
   - Run the backend:
     ```bash
     dotnet run
     ```

3. **Frontend Setup**:
   - Navigate to the Angular project folder:
     ```bash
     cd Frontend
     ```
   - Install dependencies:
     ```bash
     npm install
     ```
   - Run the Angular development server:
     ```bash
     ng serve
     ```

4. Open a web browser and navigate to `http://localhost:4200`.

## Usage

- **Authentication**:
  
- **Pokémon Data**:
  - Browse and search for Pokémon details using the PokeAPI integration.

## Future Enhancements

- Add more advanced features like Pokémon filtering and sorting.
- Register or log in to access the application features.
- Expand authentication to include third-party login providers (e.g., Google, Facebook).
- Improve styling and interactivity using advanced Bootstrap components.
- Implement unit tests for both backend and frontend.


---

Feel free to reach out for questions or suggestions!