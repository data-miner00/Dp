# Adapter Pattern

Creates an interface to glue between two incompatible objects. Can also think of it as a wrapper class.

## Example

- I have a `INotificationService` interface that needs to send an email.
- I am using SendGrid as the email client.
- My code and SendGrid code in general is incompatible; I don't want the SendGrid code to be exposed to my program.
- I implemented Object Adapter (through dependency injection or composition)
- I implemented another Class Adapter (through inheritance) by implementing the `SendGridClient` itself.
- Reminds me of the Facade pattern.

## Usages

- Integrating with 3rd library
- Integrating with external web service (HTTP response)
- Use when you feel like it
