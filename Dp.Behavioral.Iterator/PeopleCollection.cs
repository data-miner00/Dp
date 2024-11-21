namespace Dp.Behavioral.Iterator;

using System.Collections.Generic;

internal sealed class PeopleCollection : List<Person>
{
    public PeopleIterator CreateIterator()
    {
        return new PeopleIterator(this);
    }
}
