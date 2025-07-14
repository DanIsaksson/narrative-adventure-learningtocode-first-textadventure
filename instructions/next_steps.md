# 🎯 Next Steps

## Phase 4: Refactoring for a Scalable World *(IN PROGRESS)*

1. **Standardize Naming Conventions**
   - Rename all properties and fields to **PascalCase** (e.g., `Door.color` ➜ `Door.Color`, `Door.lockStatus` ➜ `Door.LockStatus`).
   - Update every reference throughout the codebase.

2. **Finalize the Item Hierarchy**
   - Ensure `Item` remains `abstract` with `public abstract void Use(Player player);`.
   - Make `HealingItem` inherit from `Item` and `override` `Use` without redundant property re-assignments.
   - Migrate `Player.Inventory` to `List<Item>` everywhere (remove remaining `List<string>` usages).

3. **Interface-Driven Area Interactions**
   - Create `IInteractable` with `void Interact(Player player);`.
   - Refactor each file in `/areas` to a concrete class implementing `IInteractable` instead of static classes.
   - Replace calls like `invDrawer.drawerInvestigate(thePlayer);` with `new Drawer().Interact(thePlayer);` in the main loop.

4. **Extract the Game Loop**
   - Move the `while (currentMode != GameState.Quit)` loop from `Program.cs` into a new `GameEngine` class: `public void Run()`. Keep `Program.Main` as a thin entry point.
   - Add graceful exit by setting `currentMode = GameState.Quit` inside `GameEngine` instead of breaking from nested switches.

5. **Polish & Testing**
   - Add at least two unit tests (using `dotnet test`) that verify:
     1. `HealingItem.Use` increases `Player.Health`.
     2. `Drawer.Interact` adds one item to `Player.Inventory`.
   - Manually play-test to ensure no null-reference or input parsing crashes occur.

---

### Reading & Practice Before Next Session
- Skim C# Docs on *Properties* (`get; set;` syntax) and *Interfaces*.
- Re-read the upcoming "Chapter Outline" and prepare questions on any unclear sections.
