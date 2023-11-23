namespace Dp.Structural.Bridge
{
    internal static class RealWorldExamples
    {
        public static void Main(string[] args)
        {
            List<string> stringList = new List<string>();
            ICollection<string> stringCollection = new List<string>();
            IEnumerable<string> stringEnumerable = new List<string>();

            List<int> intList = new List<int>();
            ICollection<int> intCollection = new List<int>();
            IEnumerable<int> intEnumerable = new List<int>();
        }
    }
}
