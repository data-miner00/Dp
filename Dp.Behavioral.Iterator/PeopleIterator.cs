namespace Dp.Behavioral.Iterator;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

internal sealed class PeopleIterator
{
    private readonly PeopleCollection peopleCollection;
    private int current = 0;

    public PeopleIterator(PeopleCollection peopleCollection)
    {
        this.peopleCollection = peopleCollection;
    }

    public Person Current => this.peopleCollection.OrderBy(static p => p.Name).ToList()[this.current];

    public bool IsDone => this.current >= this.peopleCollection.Count;

    public Person First() => this.peopleCollection.OrderBy(p => p.Name).ToList()[this.current];

    public Person? Next()
    {
        this.current++;
        if (!this.IsDone)
        {
            return this.peopleCollection.OrderBy(p => p.Name).ToList()[this.current];
        }

        return null;
    }
}
