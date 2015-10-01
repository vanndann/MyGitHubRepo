using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SortArrayOfNumbers
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ').ToArray();
        int[] numInput = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            numInput[i] = int.Parse(input[i]);
        }

        int temp;
        for (int p = 0; p < input.Length - 1; p++)
        {
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (numInput[i] > numInput[i + 1])
                {
                    temp = numInput[i + 1];
                    numInput[i + 1] = numInput[i];
                    numInput[i] = temp;
                }

            }

        }
        foreach (var elements in numInput)
        {
            Console.Write("{0} ", elements);

        }
        
        Console.WriteLine();
        string text = "Кирилица";
        var fileStream = new FileStream("../../log.txt", FileMode.Create);
        try
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            fileStream.Write(bytes, 0, bytes.Length);
        }
        finally
        {
            fileStream.Close();
        }

    }
}
