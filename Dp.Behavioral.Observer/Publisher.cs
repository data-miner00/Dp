namespace Dp.Behavioral.Observer;

using System;
using System.Collections.Generic;

internal sealed class Publisher
{
    private string content;
    private readonly List<Action<string>> actions = [];

    public Publisher(string initialContent)
    {
        this.content = initialContent;
    }

    public string Content
    {
        get => this.content;
        set
        {
            this.content = value;
            this.PublishEvents();
        }
    }

    public void Subscribe(Action<string> action)
    {
        this.actions.Add(action);
    }

    // Implement Unsubscribe

    private void PublishEvents()
    {
        foreach (var action in this.actions)
        {
            action(this.content);
        }
    }
}
