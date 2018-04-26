## Singleton Design Pattern

### Intent
Ensure a class has only one instance, and provide a global point of access to it.

### Problem
Application needs one, and only one, instance of an object. Additionally, lazy initialization and global access are necessary.

### Structure
Make the class of the single instance object responsible for creation, initialization, access, and enforcement. Declare the instance as a private static data member. Provide a public static member function that encapsulates all initialization code, and provides access to the instance.

The client calls the accessor function (using the class name and scope resolution operator) whenever a reference to the single instance is required.

![Singleton](Singleton.png)

### Participants
* Singleton
    * Defines an Instance operation that lets clients access its unique instance.
	* Responsible for creating and maintaining its own unique instance.

### Check List
* Define a private static attribute in the "single instance" class.
* Define a public static accessor function in the class.
* Do "lazy initialization" (creation on first use) in the accessor function.
* Define all constructors to be protected or private.
* Clients may only use the accessor function to manipulate the Singleton.

---
### References
* [Source Making - Design Patterns](https://sourcemaking.com/design_patterns/singleton)
* [dofactory](http://www.dofactory.com/net/singleton-design-pattern)