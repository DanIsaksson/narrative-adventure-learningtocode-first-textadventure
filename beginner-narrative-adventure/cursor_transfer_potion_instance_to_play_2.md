# Transfer potion instance to player
_Exported on 7/14/2025 at 15:05:38 GMT+2 from Cursor (1.2.4)_

---

**User**

Question regarding object logic for inventory and such. If I instance a version of the potion in invDrawer, is there a way to then transfer that into the Player.cs file (once we have the proper inventory code there)? @Player.cs @Potion.cs @Door.cs @Program.cs @invExitDoor.cs @invDrawer.cs 

---

**Cursor**

That is an excellent question. It gets to the heart of how different objects in a program interact with each other. The short answer is yes, it is absolutely possible for a `Potion` created in one part of your code to be given to the `Player`.

The mechanism for this "transfer" is a fundamental concept: a method's ability to return a value.

Before we address that, I see several compiler errors in `Program.cs`. For example, you call `invDrawer.Investigate()`, but the method defined in `invDrawer.cs` is named `drawerInvestigate`. This same issue applies to your other `inv...` classes. You will need to correct these method calls to match their definitions.

After you've fixed those, let's return to your question. Look at the method signature in your `invDrawer.cs` file: `public static void drawerInvestigate()`.

What does the `void` keyword indicate about what this method can give back to the `Main` method that calls it?

