namespace CC44_G01_Generics01
{
    internal class Program
    {

         static void BubbleSort(int[] arr)
 {
     int n = arr.Length;
     bool swapped;

     for (int i = 0; i < n - 1; i++)
     {
         swapped = false;

         for (int j = 0; j < n - i - 1; j++)
         {
             if (arr[j] > arr[j + 1])
             {
                 // Swap
                 int temp = arr[j];
                 arr[j] = arr[j + 1];
                 arr[j + 1] = temp;

                 swapped = true;
             }
         }

         if (!swapped)
             break;
     }
 }
        static void Main(string[] args)
        {

            #region Q1- Bubble Sort algorithm
int[] arr = { 5, 1, 4, 2, 8 };

Console.WriteLine("Original array:");
foreach (int item in arr)
{
    Console.Write(item + " ");
}
Console.WriteLine();

BubbleSort(arr);
Console.WriteLine("-------------------------");

Console.WriteLine("Sorted array:");
foreach (int item in arr)
{
    Console.Write(item + " ");
}
Console.WriteLine();

#endregion
            
            #region Q2-create a generic Range<T>

            // Range<int> intRange = new Range<int>(10, 20);
            // Console.WriteLine(intRange.IsInRange(15));  // True
            // Console.WriteLine(intRange.IsInRange(25));  // False
            // Console.WriteLine(intRange.Length());       // 10

            // Range<double> doubleRange = new Range<double>(5.5, 10.5);
            // Console.WriteLine(doubleRange.Length());    // 5.0


            #endregion
        }
    }
}
