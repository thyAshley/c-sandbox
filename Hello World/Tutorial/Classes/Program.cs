using System;

namespace Classes
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var sentence = "Very long test fsdfs dsfdsa sdsfdfsfsfsd ds Vereeeey long texteeeee ";
            Console.WriteLine(StringUtils.SummarizeText(sentence, 15));
        }
    } 
}
