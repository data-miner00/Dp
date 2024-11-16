# Builder

Creates a concrete object step by step. The example are based on my experience and may not necessary be compliant with the original builder pattern.

## Scenario

- I have a complex object that is troublesome to initialize with constructor.
- The complex object may have several optional parameters for its construction.
- I can hide them away and let the caller to provide info that is necessary only.

## Thoughts

Just an epiphany, I think I understand the builder pattern more now. I can use the existing `User` and `UserBuilder`, extend the builder to have `InternalUserBuilder`, `ExternalUserBuilder` etc to have each concrete builder to fill in the relevant information and create a concrete user. Just still have doubts on why a Director class is needed. Is it necessary?

Todo
- [ ] Implement `InternalUserBuilder` and `ExternalUserBuilder`

## Use Case

- Generating document
- SQL Query builder
- Customizable game avatar (eyes, hair, complexion, etc)
- Construct UI
