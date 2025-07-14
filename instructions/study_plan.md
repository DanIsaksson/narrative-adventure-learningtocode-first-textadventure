# 🎮 The Crimson Room: A C# Learning Adventure
> *"We are not 'learning C#.' We are building a cool thing. C# is simply the tool we're using to do it."*

## 📋 Progress Tracker
- [x] Phase 0: The Launchpad
- [x] Phase 1: Your Developer Cockpit
- [x] Phase 2: Building the World (Core Language & Structure)
- [x] Phase 3: Creating a Dynamic World
- [ ] Phase 4: Refactoring for a Scalable World (IN PROGRESS)
- [ ] Phase 5: Making the Game Robust
- [ ] Phase 6: Exploring the .NET Toolbox

---

## 🚀 Phase 0: The Launchpad (First 15 Minutes) - ✅ COMPLETE
> *Goal: Get your hands dirty with code immediately. No setup required.*
> 🔗 **Tool**: [.NET Fiddle](https://dotnetfiddle.net)

### 1. Your First Words: `Console.WriteLine()`
- **Concept**: Giving instructions to the computer.
- **Action**: Use `Console.WriteLine()` to print a message. Click "Run" to see the output.
```csharp
Console.WriteLine("Hello, World!");
```

### 2. Your First Conversation: `Console.ReadLine()`
- **Concept**: Getting input from the user.
- **Action**: Ask the user a question and print their answer.
```csharp
Console.WriteLine("What is your name?");
string name = Console.ReadLine();
Console.WriteLine("Welcome, " + name + ".");
```
- ✅ **Success!** You've written a program that interacts with a user.

---

## 🛠️ Phase 1: Your Developer Cockpit (Local Setup) - ✅ COMPLETE
> *Goal: Move from an online tool to a professional development environment.*

### Feature 1: Setting Up Your Project
> **Need**: A local environment to build a real application.
> **Tool**: Cursor IDE & the `dotnet` command line interface (CLI).
> **Reference**: Microsoft Docs, "Get started with C#"

#### Steps
1. Open a terminal (you can use the one inside Cursor: `Ctrl+``).
2. Navigate to a folder where you want to keep your projects.
3. Run `dotnet new console -n CrimsonRoom`. This creates a new C# project.
4. Open the `CrimsonRoom` folder in Cursor.
5. Open `Program.cs`. This is where your code will live.
6. Run `dotnet run` in the terminal. You should see "Hello, World!" printed.
- ✅ **Success!** You've set up a professional C# development environment.

### Feature 2: Game World Blueprints
> **Need**: A way to define what a "Room" and a "Player" are.
> **Tool**: The `class` keyword, Properties, and Constructors.
> **Reference**: C# Docs: "Classes", "Properties", "Constructors"

#### Create
- Create a `Player` class in a new `Player.cs` file.
- Give the `Player` a `Name` property (string) and a `Health` property (int).
- Create a constructor for the `Player` class.
- **Repetition Exercise**: Write two more simple classes (e.g. `Potion`, `Door`), each with ≥2 properties and a constructor. Instantiate them in `Program.cs` and print their property values.

### Feature 3: Organizing Logic with Methods
> **Need**: To create reusable blocks of code.
> **Tool**: Methods (Functions inside a class).
> **Reference**: C# Docs: "Methods"

#### Use
```csharp
// Inside your Player class
public void TakeDamage(int amount)
{
    Health -= amount;
    Console.WriteLine($"You took {amount} damage! You have {Health} health remaining.");
}
```

#### Create
- Create a `DisplayRoomInfo(Room room)` method in `Program.cs` that prints a room's name and description.
- (Optional) Write a `Heal(int amount)` method on `Player` that increases health and logs the result.

---

## 🏗️ Phase 2: Building the World (Core Language & Structure) - ✅ COMPLETE
> *Goal: Learn the fundamental building blocks of C# by creating the game's core.*

### You have learned:
- **Game Loop**: Using `while` to keep the game running.
- **Classes & Properties**: Defining blueprints for `Player`, `Item`, and `Door`.
- **Methods**: Organizing code into reusable blocks.
- **Enums**: Creating a set of named constants for `GameState`.
- **Static Classes**: Creating utility classes like `ChoiceHelper` and area managers.

### Feature 4: The Game Loop
> **Need**: To repeatedly ask the player for commands.
> **Tool**: The `while` loop and `if/else` statements.
> **Reference**: C# Docs: "while loop", "if-else statement"

#### Create
- In `Program.cs`, create a `while(true)` loop.
- Inside the loop, prompt the player for a command using `Console.ReadLine()`.
- Use an `if` statement to check if the command is "look". If it is, call your `DisplayRoomInfo` method.
- Use an `else if` to check for "quit". If it is, use the `break;` keyword to exit the loop.
- Use an `else` to print "I don't understand that command."

---

## 🧩 Phase 3: Creating a Dynamic World (Collections & Control Flow) - ✅ COMPLETE
> *Goal: Make the world interactive with items and inventories.*

### You have learned:
- **`List<T>`**: Using `List<Item>` to create a dynamic inventory for the `Player`.
- **`switch` statement**: Handling player commands and game states efficiently.
- **Method Parameters**: Passing objects like the `Player` instance into methods to modify them.

### Feature 5: The Player's Inventory
> **Need**: A place to store the items the player picks up.
> **Tool**: `List<T>`, a versatile collection for storing multiple objects.
> **Reference**: C# Docs: "List<T> Class"

#### Use
- Add an `Inventory` property to your `Player` class.
```csharp
// In Player.cs
public List<string> Inventory { get; set; } = new List<string>();

// In Program.cs, when handling a "take" command
player.Inventory.Add("a rusty key");
Console.WriteLine("You picked up a rusty key.");
```

### Feature 6: A Universal Item Blueprint
> **Need**: A common, enforceable template for all items in the game.
> **Tool**: `abstract` classes and `virtual`/`abstract` methods.
> **Reference**: C# Docs: "Abstract Classes", "Inheritance"

#### Create
```csharp
// In a new file: Item.cs
public abstract class Item
{
    public string Name { get; set; }
    public abstract void Use(Player player); // Every item MUST have a Use method.
}

// In a new file: Key.cs
public class Key : Item // Key inherits from Item
{
    public override void Use(Player player)
    {
        Console.WriteLine("You wave the key around. It doesn't seem to do anything here.");
    }
}
```
> **Note**: We've now moved from `List<string>` for inventory to `List<Item>`. Update your `Player` class!

### Feature 7: Handling Many Commands
> **Need**: A cleaner way to handle different commands than long `if-else` chains.
> **Tool**: The `switch` statement.
> **Reference**: C# Docs: "switch statement"

#### Create
- Replace your `if/else if/else` command handler with a `switch` statement.
- Add cases for "look", "inventory", "use [item]", and "quit".

---

## 🧠 Phase 4: Refactoring for a Scalable World (OOP Principles)
> *Goal: Apply Object-Oriented principles to make the code more organized, flexible, and scalable.*
> **Reference**: C# Player's Guide, Part 2: Object-Oriented Programming

### Feature 1: A Universal Item Blueprint
> **Need**: A common, enforceable template for all items in the game.
> **Tool**: `abstract` classes and `virtual`/`abstract` methods.
> **Reference**: C# Docs: "Abstract Classes", "Inheritance"

#### Create
```csharp
// In a new file: Item.cs
public abstract class Item
{
    public string Name { get; set; }
    public abstract void Use(Player player); // Every item MUST have a Use method.
}

// In a new file: Key.cs
public class Key : Item // Key inherits from Item
{
    public override void Use(Player player)
    {
        Console.WriteLine("You wave the key around. It doesn't seem to do anything here.");
    }
}
```

### Feature 2: A Common Language for Actions
> **Need**: A contract that guarantees different kinds of objects can perform a similar action.
> **Tool**: Interfaces (`interface`).
> **Reference**: C# Docs: "Interfaces"

#### Use
```csharp
// In a new file: IInteractable.cs
public interface IInteractable
{
    void Interact(Player player);
}

// Update your area classes (e.g., invBed) to implement this interface.
public class Bed : IInteractable
{
    public void Interact(Player player)
    {
        // Logic for investigating the bed goes here.
    }
}
```
> **Concept**: Interfaces define *what* an object can do, not *what* an object is. This will allow us to treat all interactive objects in the room uniformly, cleaning up the main game loop significantly.

---

## 🛡️ Phase 5: Making the Game Robust (Advanced Topics)
> *Goal: Add polish and reliability to your application.*

### Feature 3: Preventing Crashes
> **Need**: To handle unexpected user input gracefully.
> **Tool**: `int.TryParse()` and `try-catch` blocks for error handling.
> **Reference**: C# Docs: "Exception Handling"

### Feature 4: Saving and Loading
> **Need**: To let the player save their progress.
> **Tool**: File I/O (`System.IO.File`).
> **Reference**: C# Docs: "File I/O"

---

## 📚 Phase 6: Exploring the .NET Toolbox (BCL)
> *Goal: Leverage the vast library of pre-built code in .NET.*

### Exploration Areas
- `System.Random`: For randomizing item locations or puzzle outcomes.
- `System.Text.StringBuilder`: For efficiently building long, complex room descriptions from multiple parts.
- `System.DateTime`: For time-based puzzles or events.
- `System.Linq`: For querying collections. Example: `player.Inventory.FirstOrDefault(item => item.Name == "rusty key");` to find an item without a loop.