# Chain of Responsibility

Two implementations

1. From the pipeline of handlers, go through each of them (seems like decorator to me)
1. From the pipeline of handlers, check if the current pipeline can handle the request or not, if not, move on the the next, if yes, handle and stop.

## When to use?

When a method have a lot of checks before perfoming an action. Separate each checks into its own handler.
