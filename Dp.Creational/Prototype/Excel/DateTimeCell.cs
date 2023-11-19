namespace Dp.Creational.Prototype.Excel
{
    internal class DateTimeCell : ICell
    {
        public DateTime DateTime { get; set; }
        public string Format { get; set; }
        public ICell Clone() => new DateTimeCell
        {
            Format = Format,
            DateTime = DateTime,
        };

        public string Render => DateTime.ToString(this.Format);
    }
}