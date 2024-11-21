# Mediator Pattern

Forces all communication to happen in this middleman. Also known as: Intermediary, Controller

## Example

In this example, I have a mediator object, that depends on what `type` of the log passed in, invoke appropriate class that implements `ILogger`.

The front-end, in the case are buttons (Component), will log appropriate message when clicked.

Notice that the Component does not have direct reference to the underlying logger class.

## Disadvantage

- God object, tight coupling for mediator
- Communication overhead
