# A1_1

## Overview
A1_1 is an ASP.NET Core MVC web application that showcases a Bootstrap-powered site with multiple routes. The site includes pages for Home, Products, Services, About (with Google Maps), and Contact (with a form).

## Technologies Used
- **ASP.NET Core MVC**
- **C#**
- **Bootstrap 5**
- **Google Maps API** (for the About page)

## Setup Instructions

### Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download) (version 5.0 or later)
- [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.microsoft.com/)
- A web browser (e.g., Chrome, Firefox)

### Steps to Set Up the Project
1. **Open the project**:
    - Launch Visual Studio or Visual Studio Code.
    - Open the project folder (`A1_1`).

2. **Restore dependencies**:
    - If you are using Visual Studio, dependencies will be restored automatically.
    - If using the command line, run:
   ```bash
   dotnet restore
   
3. **Build the project**:
    - In Visual Studio, you can build the project by clicking on Build > Build Solution or pressing `Ctrl + Shift + B`.
    - If using the command line, run:
   ```bash
    dotnet build

4. **Run the application**:
    - In Visual Studio, press `F5` or click the green play button to start the project.
    - Alternatively, run the following command in the terminal:
   ```bash
    dotnet run

5. **Access the application**:
   - Open your web browser and navigate to http://localhost:5000 or http://localhost:5001 for HTTPS.

6. **Verify functionality**:
   - Navigate through the various pages (Home, Products, Services, About, Contact) to ensure everything is functioning as expected.
   - Test the Contact form by filling it out and submitting it to verify the form submission process.
