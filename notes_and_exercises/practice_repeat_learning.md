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
