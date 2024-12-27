# C# Property Access and Modification Bug

This repository demonstrates a potential issue with property access and modification in C#. The `Bug.cs` file contains code that illustrates the problem.  The solution is provided in `BugSolution.cs`.

The bug can occur when a property's setter has validation or constraints that are not enforced consistently. If code that modifies the property internally bypasses the property's setter, it might not honor the intended constraints.

## How to reproduce

1. Clone the repository.
2. Open the solution in Visual Studio.
3. Run the program and observe the output.
4. Compare the behavior to the solution provided in `BugSolution.cs`

## Solution

The solution addresses the issue by ensuring the `Value` property is properly updated and validated within the `DoSomething` method.  This prevents the unintended value assignments that could lead to unexpected errors.