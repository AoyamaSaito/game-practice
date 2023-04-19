using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private void Start()
    {
        Sum();
        MultiplicationTable();
    }

    private void Sum()
    {
        int a = 0;

        for(int i = 1; i < 101; i++)
        {
            a += i;
        }

        Console.WriteLine(a);
    }

    private void MultiplicationTable()
    {
        for(int i = 1; i < 10; i++)
        {
            for(int j = 1; j < 10; j++)
            {
                Console.Write(i * j + " ");
            }
            Console.WriteLine();
        }
    }

    private void FizzBuzz()
    {
        for(int i = 1; i < 16; i++)
        {
            if(i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine(i + "FizzBuzz");
            }
            else if(i % 3 == 0)
            {
                Console.WriteLine(i + "Fizz");
            }
            else if(i % 5 == 0)
            {
                Console.WriteLine(i + "Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}
