using System.Text;

namespace Dp.Creational.Builder;

public class QueryBuilder : IPrimitiveBuilder<string>
{
    private readonly StringBuilder sb = new();

    public QueryBuilder AddQuery(string key, string value)
    {
        this.sb.Append(this.sb.Length == 0 ? '?' : '&');
        this.sb.Append(key);
        this.sb.Append('=');
        this.sb.Append(Uri.EscapeDataString(value));

        return this;
    }

    public string Build()
    {
        return this.sb.ToString();
    }
}
