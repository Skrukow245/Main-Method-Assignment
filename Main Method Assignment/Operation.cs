using System;
using System.Data;


public class Operation
{
    public int Add(int data, int value)
    {
        return data + value;
    }
    public double Add(double data, double value)
    {
        return data + value;
    }
    public int Add(string input)
    {
        int stringResult = Convert.ToInt32(input) + 5;
        return stringResult;
    }
}

