namespace Dp.Creational.Prototype.Excel
{
    internal class NumberCell : ICell
    {
        public int Number { get; set; }
        public ICell Clone() => new NumberCell
        {
            Number = Number,
        };

        public string Render => this.Number.ToString();
    }
}