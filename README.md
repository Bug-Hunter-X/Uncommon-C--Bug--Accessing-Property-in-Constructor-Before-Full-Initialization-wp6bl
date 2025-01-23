# Uncommon C# Bug: Accessing Property in Constructor Before Full Initialization

This repository demonstrates a subtle bug in C# that can occur when accessing a property within a constructor before the property is fully initialized.  While not always immediately problematic, it can lead to unexpected behavior or exceptions in certain scenarios.

The `bug.cs` file showcases the issue. The `bugSolution.cs` file provides a solution to avoid this potential problem. 

**Explanation:**

The problem arises because the constructor might not have fully assigned all the property values before other code within the constructor attempts to access them.  This is especially relevant with more complex constructors or properties with dependencies on other internal states.

**Solution:**

The recommended approach is to avoid accessing uninitialized properties within the constructor.  If necessary, initialize the property immediately within the constructor or utilize a helper method that ensures initialization is complete.