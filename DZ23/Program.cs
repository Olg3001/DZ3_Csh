// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.WriteLine();

Console.WriteLine("Programm to find cubes of a numbers for a numbers row from 1 up to N.");
Console.Write($"Input N: ");    // $ и дальше строка - интерполяция
string writeN = Console.ReadLine()!;
int N = Convert.ToInt32(writeN);    // С.TI32 использует Parse внутри себя

if (N < 1)
{
    Console.WriteLine("Wrong input");
}
else
{
int[] GetCubeTable(int N)
{
    int[] CubeArray = new int[N];

    for (int i = 0; i < N; i++)
    {
        CubeArray[i] = (i + 1) * (i + 1) * (i + 1);
    }
    return CubeArray;
}


void PrintTable(int[] Array)
{
    int number = 1;
    for (int i = 0; i < Array.Length; i++)
    {
        System.Console.WriteLine($"{number} ^ 3 = {Array[i]}");
        number++;
    }
}

int[] CubeTable = GetCubeTable(N);
PrintTable(CubeTable);
}