# Ohm resistor calculator
Application to calculate ohm values based on resistor color bands. This application consists of 2 projects: a front end app built with ReactJS and a Backend REST API built with .NET 5. The database used on this project is SQLite.

## Requirements

1. Have the .NET 5 SDK installed in your machine.

### Running the Application
Open a terminal (or powershell) window inside the project's folder and then execute the following commands:

    cd ./OhmCalculatorApi
    dotnet run --project OhmCalculatorApi
    
Wait until the application starts. This process could take a few seconds (maybe a couple of minutes) since it will be doing the following:
1. Installing all nuget packages needed by the REST API.
2. Installing all the dependencies used by the front end application.
3. Creating the database and generating the necessary data.

When the application has been started, you should be able to see something like this:

    Building...
    info: Microsoft.Hosting.Lifetime[0]
          Now listening on: https://localhost:5001
    info: Microsoft.Hosting.Lifetime[0]
          Now listening on: http://localhost:5000
    info: Microsoft.Hosting.Lifetime[0]
          Application started. Press Ctrl+C to shut down.
    info: Microsoft.Hosting.Lifetime[0]
          Hosting environment: Development
    info: Microsoft.Hosting.Lifetime[0]
    
Next, open your browser and navigate to `https://localhost:5001`. You will see the application running.

### Testing the REST API
There's a REST API visualizer included in this application, which you can access by navigating to `https://localhost:5001/swagger`. There, you can test the REST API's endpoints.

### Visualizing the Database
A Sqlite database file is automatically generated when the application starts. This file is generated using Entity Framework and a code-first approach. The file is located in `./OhmCalculatorApi/OhmCalculatorApi/ohmcalculator.db` which can be opened by many applications that you can find in the internet, but I recommend to use DB Browser for SQLite (`https://sqlitebrowser.org/`).

### Running the tests
Open a terminal (or powershell) window inside the project's folder and then execute the following commands:

    cd ./OhmCalculatorApi
    dotnet test

If all tests were successful, you should be able to see something like this:

    Passed!  - Failed:     0, Passed:    23, Skipped:     0, Total:    23, Duration: 974 ms - /Users/arturorodriguez/Documents/Repositories/ohmcalculatorcsharp/OhmCalculatorApi/OhmCalculatorApiTests/bin/Debug/net5.0/OhmCalculatorApiTests.dll (net5.0)

    Passed!  - Failed:     0, Passed:     5, Skipped:     0, Total:     5, Duration: 1 s - /Users/arturorodriguez/Documents/Repositories/ohmcalculatorcsharp/OhmCalculatorApi/OhmCalculatorApiIntegrationTests/bin/Debug/net5.0/OhmCalculatorApiIntegrationTests.dll (net5.0)
