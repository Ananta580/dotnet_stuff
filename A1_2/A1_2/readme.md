# A1_2 : Resource Management Software (RMS)

## Overview
RMS is an ASP.NET Core MVC web application that showcases a Bootstrap-powered site with multiple routes. The site includes pages for 
Home, Resources, Projects with CRU operations for both of these properties.

## Technologies Used
- **ASP.NET Core MVC**
- **C#**
- **Bootstrap 5**
- **Entity Framework Core** (for migrating database)

## Setup Instructions

### Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download) (version 8.0 or later)
- [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.microsoft.com/)
- A web browser (e.g., Chrome, Firefox)

### Steps to Set Up the Project
1. **Open the project**:
    - Launch Visual Studio or Visual Studio Code.
    - Open the project folder (`A1_2`).

2. **Restore dependencies**:
    - If you are using Visual Studio, dependencies will be restored automatically.
    - If using the command line, run:
   ```bash
   dotnet restore
   ```

3. **Run migration**:
   - If you have visual studio, goto `Tools > Nuget Package Manager > Package Manager Console` and
run the following command:
   ```bash
   update-database
   ```
   - Otherwise, open command prompt and run these command one by one:
   ```
   dotnet tool install --global dotnet-ef
   dotnet add package Microsoft.EntityFrameworkCore.Design
   dotnet ef database update 
   ```
   
3. **Build the project**:
    - In Visual Studio, you can build the project by clicking on Build > Build Solution or pressing `Ctrl + Shift + B`.
    - If using the command line, run:
   ```bash
    dotnet build
   ```
4. **Run the application**:
    - In Visual Studio, press `F5` or click the green play button to start the project.
    - Alternatively, run the following command in the terminal:
   ```bash
    dotnet run

5. **Access the application**:
   - If your browser open automatically, that's perfect. Otherwise,
   - Open your web browser and navigate to http://localhost:5000 or http://localhost:5001 for HTTPS.

6. **Verify functionality**:
   - Navigate through the various pages (Home, Resources, Projects) to ensure everything is functioning as expected.
   - Resources: Check Create, Edit, Detail pages
   - Projects: Check Create, Edit, Detail pages
7. **API Routes**:
   - /Home or /
   - /Resources
   - /Resources/Create
   - /Resources/Edit/{id}
   - /Resources/Details/{id}
   - /Projects
   - /Projects/Create
   - /Projects/Edit/{id}
   - /Projects/Details/{id}
