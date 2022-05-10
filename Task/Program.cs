﻿string[] CreateNewArray(string[] initialArray, int lengthOfWord)
{
    int length = new int();
    for (int i = 0; i < initialArray.Length; i++)
    {
       if(initialArray[i].Length <= lengthOfWord)
       {
           length ++;
       } 
    }
    string[] newArray = new string[length];
    int count = new int();
    for (int j = 0; j < initialArray.Length; j++)
    {
        if (initialArray[j].Length <= lengthOfWord)
        {
            newArray[count] = initialArray[j];
            count++;
        }
    }
    return newArray;
}

void PrintArray(string[] arrayToPrint)
{
    Console.Write("[ ");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write($"\"{arrayToPrint[i]}\" ");
        if(i < arrayToPrint.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

string[] myArray = { "1234", "ask", "sun", "hello", "world", "sea", "12" };
string[] newArray = CreateNewArray(myArray, 3);
PrintArray(newArray);
