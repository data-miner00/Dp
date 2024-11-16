# Factory Method Pattern

Factory Method (aka Virtual Constructor) is a creational design pattern that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created.

However, this I still couldn't understand what's the point of this pattern. The examples are provided based on my understandings and is a simplified version that might not be fully compliant with the original factory method pattern.

## Scenario

- I have a couple of different `ILogger` implementation, namely `ConsoleLogger`, `FileLogger` and `CloudLogger`.
- I want to dynamically use the logger based on config settings
- I want to decouple the if else statement used to create the logger in the Main method.

## Original Pattern

```
IProduct -> Product A & Product B
               ^           ^
               |           |
ICreator -> Creator A & Creator B
```
