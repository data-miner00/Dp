# Proxy Pattern

Surrogate?

## Types of Proxy

- Remote proxy: Communicate with the proxy and feels like the object itself
- Virtual proxy: Create expensive object on demand
- Smart proxy: Allow adding additional logic around the subject (e.g. cache)
- Protection proxy: Limit access to an object

## Takeaways

- Decorator uses dependency injection
- Proxy just **new** the object

## Use cases

- Feature toggle
- Rate limiting
