namespace Dp.Behavioral.ChainOfResponsibility;

internal interface IHandler
{
    void Handle(Request request);
}
