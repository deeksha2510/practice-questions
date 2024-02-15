using System;
class Program
{
    static void Main()
    {
        int n = 110;
        int i;
        int x = 1;
        int b = 120;
       
        for (i = 101; i <= n; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine($"'{new string('a',x)}'+101'={x}''{new string('a',x)}{b}'");
            }
            else
            {
                Console.WriteLine($"'{new string('a',x)}'+{i}'={x}''{new string('a',x)}{b}'");
            }
            x++;
            b++;
        }
    }
}
