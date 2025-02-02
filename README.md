# SeunDanielOmatsola-MergeIntervals

# Merge Intervals - C# Console Application

## Description
This is a simple C# console application that implements the Merge Intervals algorithm. It takes an array of interval pairs, merges overlapping intervals, and returns a new list of non-overlapping intervals. The program also includes test cases to validate the implementation.

## Prerequisites
- .NET 8 SDK installed on your machine
- A terminal or command prompt to run the application

## Steps to Run the Application

### 1. Clone the Repository
To get started, clone the project from your GitHub repository:
```sh
git clone https://github.com/yourusername/MergeIntervalsApp.git
cd MergeIntervalsApp
```

### 2. Build and Run the Application
To build and run the application, execute the following command:
```sh
dotnet run
```
This will compile and execute the program, displaying the test results in the console.

## Expected Output
The program will print test cases, expected output, actual output, and whether each test case passed or failed.

Example:
```
Test 1:
Input: [[1, 3], [2, 6], [8, 10], [15, 18]]
Expected Output: [[1, 6], [8, 10], [15, 18]]
Actual Output: [[1, 6], [8, 10], [15, 18]]
✅ Passed
---------------------------------
```

## Modifying the Code
To modify the test cases, edit the `RunTests` method inside `Program.cs` and adjust the `testCases` list as needed.

## Troubleshooting
- Ensure you are using .NET 8 by running `dotnet --version`.
- If errors occur, try running `dotnet build` to check for compilation issues.
- If issues persist, ensure that `Program.cs` is correctly placed inside the project directory.

# Author
Seun Daniel Omatsola


