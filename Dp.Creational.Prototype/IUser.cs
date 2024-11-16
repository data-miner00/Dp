namespace Dp.Creational.Prototype;

using System;

internal interface IUser : ICloneable
{
    string FirstName { get; set; }

    string LastName { get; set; }

    IUser DeepClone();
}
