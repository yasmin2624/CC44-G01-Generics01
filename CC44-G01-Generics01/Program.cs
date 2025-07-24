namespace CC44_G01_Generics01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q2-create a generic Range<T>

            Range<int> intRange = new Range<int>(10, 20);
            Console.WriteLine(intRange.IsInRange(15));  // True
            Console.WriteLine(intRange.IsInRange(25));  // False
            Console.WriteLine(intRange.Length());       // 10

            Range<double> doubleRange = new Range<double>(5.5, 10.5);
            Console.WriteLine(doubleRange.Length());    // 5.0


            #endregion
        }
    }
}
