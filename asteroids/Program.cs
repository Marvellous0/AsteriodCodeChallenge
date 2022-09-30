// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

int[] num = new int[] {  8, -8 };

foreach (var item in Asteroids(num))
{
    Console.Write(item);
}

static int[] Asteroids(int[] numbers)
{
    List<int> numberList = new List<int>();
    string reminant = "";

    for (int i = 0; i < numbers.Length -1; i++)
    {
        if(i == 0) continue;
        for (int j = i - 1; j < numbers.Length; j++)
        {
        
            if(Math.Abs(numbers[i]) > 0 && Math.Abs(numbers[i+1]) > 0)
            {
                reminant = numbers[i].ToString();
                continue;
            }

            else if (Math.Abs(numbers[i]) <  Math.Abs(numbers[j]))
            {
                reminant = numbers[i].ToString();
                break;     
            }

            else if(Math.Abs(numbers[i]) ==  Math.Abs(numbers[j]))
            {
                reminant = "";
            }

            else
            {
                if (numbers[i] < 0 && numbers[j] < numbers[i])
                {
                    reminant = numbers[i].ToString();
                }

                else{
                    reminant = "";
                }
            }

        }
        numberList.Add(int.Parse(reminant)); 
    }

    return numberList.ToArray();
}