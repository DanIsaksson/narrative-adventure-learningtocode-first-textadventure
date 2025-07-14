=== IN THIS DOCUMENT THE LLM/AI HAS AUTHORITY TO ENTER NEW PRACTICE EXERCISES AS WE PROGRESS ===
- The goal of these exercises is to repeat patterns, code logic, specific methods, class orientation, and all things more specifically related to the practical function of C# / .NET code.




========== STUDENT EXERCISES ==========

### Exercise 1: Classes, Enums, and Switch Statements

**Goal**: Reinforce your understanding of creating classes, defining enums for state, and using switch statements for logic.

1.  **Create an Enum**:
    -   Define an `enum` named `MonsterType` that includes the following types: `Goblin`, `Skeleton`, `Orc`, `Slime`.

2.  **Create a Class**:
    -   Create a class named `Monster`.
    -   Give it three properties:
        -   `Name` (string)
        -   `Health` (int)
        -   `Type` (using your `MonsterType` enum)
    -   Add a constructor that accepts values for these three properties.

3.  **Write a Method with a `switch`**:
    -   Create a static method `public static void Announce(Monster monster)`.
    -   Inside this method, use a `switch` statement on `monster.Type`.
    -   For each `MonsterType`, write a different line to the console. For example:
        -   `Goblin`: "A nasty goblin appears, clutching a rusty dagger!"
        -   `Skeleton`: "A skeleton rattles its bones as it approaches."
        -   `Orc`: "An enormous orc bellows a challenge!"
        -   `Slime`: "A green slime gurgles menacingly."
        -   `default`: "A creature of unknown origin has appeared."

4.  **Test it**:
    -   In your `Program.cs` `Main` method (or a temporary new project), create a few different `Monster` instances and pass them to your `Announce` method to see the output.

### Exercise 2: Blueprint vs. Cookie

**Goal**: Cement the mental model of **class vs. instance** and the role of the **constructor**.

1.  Create a `CookieCutter` class with one property `Shape` (string).
2.  Create a constructor that sets `Shape`.
3.  In `Program.cs`, instantiate three different cutters ("Star", "Circle", "Heart").
4.  Print each instance's `Shape` to show they share the *blueprint* but hold their *own* data.
5.  (Stretch) Add a static field `public static int TotalCuttersMade` and increment it inside the constructor. Print the total to see static vs. instance in action.

### Exercise 3: Naming Make-over

**Goal**: Practice spotting and correcting naming issues.

1.  Copy the following snippet into a scratch file:
    ```csharp
    public class door {
        public string color;
        public bool islocked;
    }
    ```
2.  Fix every naming violation based on C# conventions **without** changing functionality.
3.  Explain (in comments) *why* each change was made (e.g., "Classes use PascalCase").
