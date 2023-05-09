using System;
class Project
{
    static void Main(string[] args)
    {
        int num = 3;
        Hi(num);
    }
    static void Hi(int num)
    {
        num += 2;
        Console.WriteLine(num);
    }

}