# A2 : Authentication & Authorization (Shoppers)

## Overview
To demonstrate the authentication and authorization, I have created a simple web application for a shopping website. The website has two types of users: Admin and Customer. Admin can add, edit, and delete products, while customers can only view the products. The website has the following pages:

## Technologies Used
- **ASP.NET Core MVC**
- **C#**
- **Tailwind CSS (using CDN)**
- **Entity Framework Core** (for migrating database)

## Setup Instructions

### Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download) (version 8.0 or later)
- [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.microsoft.com/)
- A web browser (e.g., Chrome, Firefox)

### Steps to Set Up the Project
1. **Open the project**:
    - Launch Visual Studio or Visual Studio Code.
    - Open the project folder (`A2`).

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
    - Create 3 new user by clicking on the `Register` link with 3 different roles.
    - Log in with the each user.
    - Navigate through the various pages (Home, Products, Inventory, Admin Panel) to ensure everything is functioning as expected.
    - Home: Index page (Anonymous access)
    - Product: List of products, Detail of Product (Accessible to User, Editor and Admin)
    - Inventory: List of products, Detail of Product, Create, Edit and Delete Product (Accessible to Editor and Admin)
    - Admin Panel: Dashboard, Add User (Accessible to Admin)
7. **API Routes**:
    - /Home or /
    - /Products
    - /Products/Details/{id}
    - /Inventory
    - /Inventory/Create
    - /Inventory/Edit/{id}
    - /Inventory/Delete/{id}
    - /Admin
    - /Admin/AddUser
