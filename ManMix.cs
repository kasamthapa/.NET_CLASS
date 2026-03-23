using System;
class MaxMin{
    int[] numbers = {10,30,40};
  

    static void Main(string[] args)
    {
        MaxMin cal = new MaxMin();
        Console.WriteLine("max ="+cal.numbers.Max());
         Console.WriteLine("min ="+cal.numbers.Min());
    }
   
}
