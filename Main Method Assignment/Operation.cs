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
    internal object Add(string v1, int v2)
    {
        return v1 + v2;
    }
}

