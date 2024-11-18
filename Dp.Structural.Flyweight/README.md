# Flyweight Pattern

Separates out some of the state, so that it is reusable, and takes less memory.

## Considerations

- Does the app use large no of objects? yes
- Are storage high costs high due to large no of objects? yes
- Can most of the state be made extrinsic? yes
- If remove extrinsic state, can large group of objects being replaced with few objects? yes
- Does app require identity? No

## Question

- Requires a factory? A cache such as dictionary?
- Shared? Unshared?
