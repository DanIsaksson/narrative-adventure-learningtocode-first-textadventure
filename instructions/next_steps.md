# 🎯 Next Steps

## Phase 2: Building the World
- [ ] Implement the `Player` class in `Player.cs` with `Name` and `Health` properties and a constructor.
- [ ] Write two additional simple classes (`Potion`, `Door`), each with ≥2 properties and a constructor; instantiate them in `Program.cs` and print their property values.

## Phase 2: Methods Practice
- [ ] Create a `DisplayRoomInfo(Room room)` method in `Program.cs` and call it from `Main`.
- [ ] (Optional) Add a `Heal(int amount)` method on `Player` and invoke it in your game loop.

## Preparing for Phase 3
- [ ] Read about abstract classes and inheritance (e.g. `Item`/`Key`) so you're ready to build the inventory system next.

## Phase 4: Refactoring for a Scalable World (OOP)

Your next goal is to apply Object-Oriented Programming (OOP) principles. This will make your game's code more organized and easier to expand. We will start with `abstract` classes.

**Reading:** C# Player's Guide, Part 2: Object-Oriented Programming

### Tasks
1.  **Refactor `Item.cs` into an `abstract` class.**
    -   An `abstract` class provides a base definition but cannot be instantiated itself. It's a perfect blueprint.
    -   Add an `abstract` method to it called `public abstract void Use(Player player);`. This forces any class that inherits from `Item` to define how it is "used".

2.  **Create a specific item that inherits from `Item`.**
    -   Create a new file, `Key.cs`.
    -   The `Key` class should inherit from your new `abstract Item` class.
    -   You will be required to `override` the `Use` method. For now, just have it print a message like `"You wave the key around uselessly."`

3.  **Update `invDrawer.cs` to give the Player a `Key` instead of a `Small Potion`.**
    - This will allow us to test the new system. You will need to change this line:
    `thePlayer.PlayerInventory.Add(new Item("Small Potion", ...));`
    - To this:
    `thePlayer.PlayerInventory.Add(new Key("Old Rusty Key", "An old, heavy iron key."));`

Once these steps are done, the foundation for a much more robust item system will be in place.
