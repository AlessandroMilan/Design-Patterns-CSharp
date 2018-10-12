## Prototype Design Pattern

### Intent

* Specify the kinds of objects to create using a prototypical instance, and create new objects by copying this prototype.

### Problem

Application "hard wires" the class of object to create in each "new" expression.

### Structure

The Factory knows how to find the correct Prototype, and each Product knows how to spawn new instances of itself.

![Prototype](prototype.gif)

### Participants

 The classes and objects participating in this pattern are:

* Prototype 
    * Declares an interface for cloning itself
* ConcretePrototype 
    * Implements an operation for cloning itself
* Client  
    * Creates a new object by asking a prototype to clone itself
