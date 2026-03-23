///2D-ArraY
using System;
class Calculator{
    int[,] numbers = {{10,30,40},{
        50,60,70
    }};
    int sum =0;
    int max =0;

    static void Main(string[] args)
    {
        Calculator cal = new Calculator();
        foreach(int num in cal.numbers){

            Console.WriteLine(num);
        
        }
        Console.WriteLine("Max="+cal.max);
    }
   
}

