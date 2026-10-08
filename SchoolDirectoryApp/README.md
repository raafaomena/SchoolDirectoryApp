# School Directory Dashboard

A Blazor Web Application that consumes the Edutots School API and displays a searchable list of schools with a details view.

## Project Description

This is the CA1 assignment for BSC30926 Full-Stack Development. The application connects to the Edutots School API, retrieves a list of schools, and provides:

- A searchable list of all schools
- A details view when a school is selected
- Loading and error states for API failures
- A clean Bootstrap-based UI

## Technologies Used

- .NET 9
- Blazor Web App (Interactive Server render mode)
- C#
- Bootstrap 5
- System.Net.Http.Json for JSON deserialization

## API Endpoint

https://edutots.net/api/school

## Project Structure

SchoolDirectoryApp/
├── Components/
│   ├── Pages/
│   │   ├── Home.razor
│   │   └── Schools.razor
│   ├── SchoolCard.razor
│   └── SchoolDetails.razor
├── Models/
│   └── School.cs
├── Services/
│   └── SchoolService.cs
└── Program.cs

## How to Run

1. Clone the repository:
   git clone https://github.com/raafaomena/SchoolDirectoryApp.git

2. Open the solution in JetBrains Rider or Visual Studio.

3. Restore dependencies:
   dotnet restore

4. Run the application:
   dotnet run

5. Open the browser at the URL shown in the terminal (usually https://localhost:7000 or similar).

6. Navigate to /schools or use the home page.

## Screenshots

### 1. School list loaded successfully
![School list](screenshot-1-school-list.png)

### 2. Search functionality
![Search](screenshot-2-search.png)

### 3. School details view
![Details](screenshot-3-details.png)

### 4. Loading state
![Loading](screenshot-4-loading.png)

### 5. Error state
![Error](screenshot-5-error.png)

## Features Implemented

- **API Integration:** The application uses HttpClient to retrieve data from the Edutots API and deserializes the JSON response into a List of School objects.
- **Reusable Component:** SchoolCard.razor is a reusable component that receives a School object via a Parameter.
- **EventCallback:** When the user clicks "View Details", the child component (SchoolCard) notifies the parent (Schools) via EventCallback of School.
- **Data Binding:** The search input uses @bind with @bind:event="oninput" for real-time filtering.
- **Loading State:** A "Loading schools..." message is shown while the data is being fetched.
- **Error Handling:** A "Unable to retrieve school data." message is shown if the API call fails.

## Notes

- The school names are displayed exactly as they come from the API. Some names are in lowercase because that is how they are stored in the API database.
- This project uses the .NET 9 Blazor Web App template with Interactive Server rendering.