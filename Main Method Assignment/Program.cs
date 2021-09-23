using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        //var operatorObject = new Operation();
        //var result = operatorObject.Add(5, 4);                        //pulls from first method
        //Console.WriteLine(result);
        //Console.ReadLine();

        //var operatorObject = new Operation();
        //var result = operatorObject.Add(.5, .9);                      //pulls from second method
        //Console.WriteLine(result);
        //Console.ReadLine();

        var operatorObject = new Operation();
        var result = operatorObject.Add(v1:"one", 2);                        //pull from third method
        Console.WriteLine(result);
        Console.ReadLine();
    }
}

