namespace Dp.Behavioral.Memento;

internal struct Position
{
    private int Cell {  get; set; }

    public class Piece
    {
        public Position pos = new();

        public void Move(int n)
        {
            this.pos.Cell += n;
            Console.WriteLine("Moving To " + this.pos.Cell);
        }

        public Position GetPosition()
        {
            return new Position { Cell = this.pos.Cell };
        }

        public void SetPosition(Position that)
        {
            this.pos.Cell = that.Cell;
            Console.WriteLine("Getting back to " + that.Cell);
        }
    }
}
