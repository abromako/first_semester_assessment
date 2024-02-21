
using System.Globalization;


string[] CreateArray(int size)
{
    string[] arr = new string[size];
    var random1 = new Random();
    var random2 = new Random();
    string symbols = "qwertyuiopasdfghjklzxcvbnm1234567890!@#$%^&*()";

    for (int i = 0; i < arr.Length; i++)
    {
        int stringlen = random2.Next(1, 10);
        string random = "";

        for (int j = 0; j < stringlen; j++)
        {
            int a = random1.Next(symbols.Length);
            random = random + symbols.ElementAt(a);
            arr[i] = random;
        }
    }
    return arr;
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
}

Console.Clear();
Console.WriteLine("Please enter size of your array");
int n = Convert.ToInt32(Console.ReadLine());
string[] arr = CreateArray(n);
Console.WriteLine("Unsorted array");
PrintArray(arr);


int CountIndexForNewArray(string[] arr)
{
    int counter = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            counter++;
        }

    }
    return counter;
}

int index = CountIndexForNewArray(arr);

string[] GetArrayWithLess4Sym(string[] arr, int j)
{
    string[] newarr = new string[j];
    int c = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newarr[c] = arr[i];
            c++;
        }
    }
    return newarr;
}

string[] sorted = GetArrayWithLess4Sym(arr, index);
Console.WriteLine("\nSorted Array");
PrintArray(sorted);


