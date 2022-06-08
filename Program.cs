using System;

namespace Graus CF
{
    class Program
    {
        static void Main(string[] args)
        {
double temperaturaC, temperaturaF;
Console.Writeline("Qual a temperatura C:");
temperaturaC = Convert.ToDouble(Console.Readline())
temperaturaF = temperaturaC * 1.8 + 32
Console.Writeline($"{temperaturaC}C = {temperaturaF}F");
        }
    }
}
