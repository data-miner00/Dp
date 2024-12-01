# Null Object Pattern

Handling null or non-existent objects.

Instead of letting the non-mandatory field to have `null` or any undefined reference, we create a null/void/stub object for that.

## Scenario

Handling optional logger with Null Object instead of `null`.

```diff
- public ILogger? Logger { get; set; } = null;
+ public ILogger Logger { get; set; } = new NullLogger();
```

## Benefits

- the need for explicit null checks is eliminated
- no more null reference exception

## Down side

- may unknowingly using the null object because no more null reference exception
- not compatible with IoC principle? Feel like gonna have hiccups when using DI.

## Experience

Rare to encounter based on my experience. Usually `null` works just fine.

## Reference

- https://www.geeksforgeeks.org/null-object-design-pattern/
