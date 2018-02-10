## Builder Design Pattern

### Intent
* Separate the construction of a complex object from its representation so that the same construction process can create different representations.
* Parse a complex representation, create one of several targets.

### Problem
An application needs to create the elements of a complex aggregate. The specification for the aggregate exists on secondary storage and one of many representations needs to be built in primary storage.

### Participants

* Builder
    * Specifies an abstract interface for creating parts of a Product object
* ConcreteBuilder
    * Constructs and assembles parts of the product by implementing the Builder interface
    * Defines and keeps track of the representation it creates
    * Provides an interface for retrieving the product
* Director
    * Constructs an object using the Builder interface
* Product 
    * Represents the complex object under construction. ConcreteBuilder builds the product's internal representation and defines the process by which it's assembled
    * Includes classes that define the constituent parts, including interfaces for assembling the parts into the final result

![Builder](BUilder.gif)

---
### References
* [Source Making - Design Patterns](https://sourcemaking.com/design_patterns/builder)
* [dofactory](http://www.dofactory.com/net/builder-design-pattern)