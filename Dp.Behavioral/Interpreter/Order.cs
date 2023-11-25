using System.Text.RegularExpressions;

namespace Dp.Behavioral.Interpreter;

/// <summary>
/// Interpreter keyword: Parse
/// It maps some human language to some sort of computation.
/// </summary>
/// <param name="qty"></param>
/// <param name="product"></param>
/// <param name="source"></param>
internal class Order(int qty, string product, string source)
{
    static readonly string RegexOptionalSpace = " ?";
    static readonly string RegexQuantity = "x(?<qty>\\d+)" + RegexOptionalSpace;
    static readonly string RegexProduct = "'(?<product>[\\w ]+)'" + RegexOptionalSpace;
    static readonly string RegexSource = "from (?<source>\\w+)";
    static readonly string RegexOrderCommand = "order" + RegexOptionalSpace + RegexQuantity + RegexProduct + RegexSource;
    
    static readonly Regex regex = new(RegexOrderCommand);

    public int Qty => qty;
    public string Product => product;
    public string Source => source;


    public static void Main()
    {
        var domainLanguage = "order x10 '2L water bottles' from Tesco";
        var order = Order.Parse(domainLanguage);
    }

    public static Order? Parse(string command)
    {
        var match = regex.Match(command);
        if (!match.Success)
        {
            return null;
        }

        var qty = int.Parse(match.Groups["qty"].Value);
        var product = match.Groups["product"].Value;
        var source = match.Groups["source"].Value;

        return new(qty, product, source);
    }
}
