using System;

class Program{
    static void Modify(ref int a){
        a = a * 2;
    }

    static void Main(string[] args){
        int a = 2;
        Modify(ref a);
        Console.WriteLine(a);
    }
}