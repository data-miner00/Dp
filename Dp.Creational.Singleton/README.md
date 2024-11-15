# Singleton Pattern

Ensures that only 1 instance of a class can exist throughout the lifetime of the program. Need to make sure it is thread safe.

## Example 1

The bare minimum of a Singleton pattern.

## Example 2

Same as Example 1 but with lazy loading instead.

## Use Case

- Managing a database connection pool
- Caching frequently used data (avoid redundant cache)
- Stores application settings

## Impact

Antipattern. Not unit testable. Lifetime should be controlled by IoC container.
