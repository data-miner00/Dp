namespace Dp.Behavioral.Memento;

internal class Player
{
    private readonly List<Position> positionMemory = [];
    private readonly Position.Piece piece = new();

    public void GoForward()
    {
        var position = piece.GetPosition();
        positionMemory.Add(position);

        int n = new Random().Next(1, 6);
        piece.Move(n);
    }

    public void GoBackward()
    {
        var position = positionMemory.Last();
        positionMemory.Remove(position);
        piece.SetPosition(position);
    }
}
