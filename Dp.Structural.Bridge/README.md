# Bridge Pattern

Seperating Abstraction with its Implementation. What does it means?

It means abstraction can have their own hierarchy, while implementation have their own hierarchy as well.
And abstraction uses the implementation through composition (dependency injection)

## Scenario

| | Circle | Square | Triangle |
|--- | --- | --- | --- |
| Red | Red Circle | Red Square | Red Triangle |
| Blue | Blue Circle | Blue Square | Blue Triangle |
| Green | Green Circle | Green Square | Green Triangle |

If we introduce another shape like Quadrilateral or a new color Yellow, we will need to implement 4 new subclasses

Instead of creating subclass for every single variation, use composition instead.

From experience, I never came to the situation where I implemented above lol.

## Reference

- https://refactoring.guru/design-patterns/bridge
