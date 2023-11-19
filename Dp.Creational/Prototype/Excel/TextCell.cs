namespace Dp.Creational.Prototype.Excel
{
    internal class TextCell : ICell
    {
        public string Content { get; set; }

        public ICell Clone() => new TextCell
        {
            Content = Content,
        };

        public string Render => this.Content;
    }
}