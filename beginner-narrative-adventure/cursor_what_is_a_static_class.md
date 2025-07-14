# What is a static class?
_Exported on 7/14/2025 at 15:07:09 GMT+2 from Cursor (1.2.4)_

---

**User**

What is a static class?

---

**Cursor**

A static class serves as a container for methods and properties that are not tied to any specific object instance. You cannot create an instance of a static class using the `new` keyword, and all of its members must also be static. You access these members directly through the class name.

For example: `Console.WriteLine("text")` calls the static `WriteLine` method on the static `Console` class.

Considering your project, what is the purpose of a "helper" class like `ChoiceHelper.cs`, and would its methods need to be associated with a specific object instance to function?

