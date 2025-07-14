# Transfer potion instance to player
_Exported on 7/14/2025 at 15:05:27 GMT+2 from Cursor (1.2.4)_

---

**User**

Question regarding object logic for inventory and such. If I instance a version of the potion in invDrawer, is there a way to then transfer that into the Player.cs file (once we have the proper inventory code there)? @Player.cs @Potion.cs @Door.cs @Program.cs @invExitDoor.cs @invDrawer.cs 

---

**Cursor**

Excellent question. It touches upon a fundamental concept of managing state and interactions between different parts of your program.

Yes, you can absolutely create an instance of a `Potion` within the `invDrawer` logic and have it added to your `Player`'s inventory. The key is to give the `invDrawer`'s logic access to the `Player` object.

Currently, your `Player` object (once created) will exist in `Program.cs`, but your `invDrawer.cs` file has no knowledge of it.

Here is a diagram of the current situation:

```
[ Program.cs (Main) ]          [ invDrawer.cs ]
   |                               |
   - 'player' object lives here    - drawerInvestigate() method
   |                               |
   - Calls drawerInvestigate() --->- (Has no access to 'player')
```

To solve this, you can pass the `Player` object as an argument to the investigation method. This gives the method a direct reference to the player it should modify.

Here is a diagram of the proposed change:

```
[ Program.cs (Main) ]          [ invDrawer.cs ]
   |                               |
   - Player player = new Player()  - Investigate(Player p)
   |                /--------------|
   - Calls Investigate(player)
                      \------------> - Can now access p.Inventory
```

Here are the steps to implement this:

### 1. Create the Player Instance
In `Program.cs`, you should create an instance of the `Player` after you get their name.

```csharp:dotnetfiddle/CrimsonRoom/Program.cs
// ... existing code ...
					}
					Console.WriteLine("Well then... welcome" + playerName + ".");
					
					// Create the player object
					Player player = new Player(playerName, 100);

					currentMode = GameState.Center;
					break;
				
				case GameState.Center:
// ... existing code ...
```

### 2. Update the Investigation Methods
Modify the methods in your `inv...` classes to accept a `Player` object. While doing so, it is good practice to make your method names consistent. The errors you are seeing are because you are calling a method named `Investigate` in `Program.cs`, but the method in `invDrawer.cs` is named `drawerInvestigate`. Let's fix that and add the parameter.

Here is the change for `invDrawer.cs`:

```csharp:dotnetfiddle/CrimsonRoom/areas/invDrawer.cs
using System;

public static class invDrawer
{
    public static void Investigate(Player currentPlayer)
    {
        Console.WriteLine("There's a small, unassuming wooden drawer set into a nearby desk. It looks like it hasn't been opened in years, covered in a thick layer of dust.");

        switch(Console.ReadLine())
        {
            case "Open Drawer":
                Console.WriteLine("You tug at the handle. It's stuck. With a sharp pull, it jerks open with a loud crack. Inside, you find a single, red potion.");
                // Create the potion and add its name to the player's inventory
                Potion foundPotion = new Potion("Health Potion", 20);
                currentPlayer.Inventory.Add(foundPotion.Name);
                Console.WriteLine($"You added a {foundPotion.Name} to your inventory.");
                break;

            case "Dust":
// ... existing code ...
```
You can apply this same change to the other `inv...` files, such as `invExitDoor.cs`, renaming `exitDoorInvestigate` to `Investigate` and adding the `Player` parameter.

### 3. Update the Method Calls in `Program.cs`
Finally, update the calls in `Program.cs` to pass the `player` object you created.

```csharp:dotnetfiddle/CrimsonRoom/Program.cs
// ... existing code ...
					break;

				case GameState.eDrawer:
					invDrawer.Investigate(player);
					currentMode = GameState.Center;
					break;

				case GameState.eWindow:
					invWindow.Investigate(player);
					currentMode = GameState.Center;
					break;

				case GameState.eCloset:
					invCloset.Investigate(player);
					currentMode = GameState.Center;
					break;

				case GameState.eMirror:
					invMirror.Investigate(player);
					currentMode = GameState.Center;
					break;

				case GameState.eClock:
					invClock.Investigate(player);
					currentMode = GameState.Center;
					break;

				case GameState.eExitDoor:
					invExitDoor.Investigate(player);
					currentMode = GameState.Center;
					break;

				case GameState.Quit:
// ... existing code ...
```

By making these changes, your `Investigate` methods will be able to directly modify the player's state, such as adding items to their inventory.

```plaintext
[ Program.cs (Main) ]          [ invDrawer.cs ]
   |                               |
   - 'player' object lives here    - drawerInvestigate() method
   |                               |
   - Calls drawerInvestigate() --->- (Has no access to 'player')
```

```plaintext
[ Program.cs (Main) ]          [ invDrawer.cs ]
   |                               |
   - Player player = new Player()  - Investigate(Player p)
   |                /--------------|
   - Calls Investigate(player)
                      \------------> - Can now access p.Inventory
```

```csharp
// ... existing code ...
					}
					Console.WriteLine("Well then... welcome" + playerName + ".");
					
					// Create the player object
					Player player = new Player(playerName, 100);

					currentMode = GameState.Center;
					break;
				
				case GameState.Center:
// ... existing code ...
```

```csharp
using System;

public static class invDrawer
{
    public static void Investigate(Player currentPlayer)
    {
        Console.WriteLine("There's a small, unassuming wooden drawer set into a nearby desk. It looks like it hasn't been opened in years, covered in a thick layer of dust.");

        switch(Console.ReadLine())
        {
            case "Open Drawer":
                Console.WriteLine("You tug at the handle. It's stuck. With a sharp pull, it jerks open with a loud crack. Inside, you find a single, red potion.");
                // Create the potion and add its name to the player's inventory
                Potion foundPotion = new Potion("Health Potion", 20);
                currentPlayer.Inventory.Add(foundPotion.Name);
                Console.WriteLine($"You added a {foundPotion.Name} to your inventory.");
                break;

            case "Dust":
// ... existing code ...
```

```csharp
// ... existing code ...
					break;

				case GameState.eDrawer:
					invDrawer.Investigate(player);
					currentMode = GameState.Center;
					break;

				case GameState.eWindow:
					invWindow.Investigate(player);
					currentMode = GameState.Center;
					break;

				case GameState.eCloset:
					invCloset.Investigate(player);
					currentMode = GameState.Center;
					break;

				case GameState.eMirror:
					invMirror.Investigate(player);
					currentMode = GameState.Center;
					break;

				case GameState.eClock:
					invClock.Investigate(player);
					currentMode = GameState.Center;
					break;

				case GameState.eExitDoor:
					invExitDoor.Investigate(player);
					currentMode = GameState.Center;
					break;

				case GameState.Quit:
// ... existing code ...
```

