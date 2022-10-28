// Напишите программу, которая принимает на вход целое число любой разрядности
// и проверяет, является ли оно палиндромом. Через строку нельзя решать само собой. 

Console.WriteLine("Programm to check if number is a palindrome");
Console.Write("Input number: ");
int input = int.Parse(Console.ReadLine()!);

if (input < 0)
{
    input = input * -1;
}

void Result(int input)
{
    int old = input;
    int newValue = 0;

    while (input > 0)
    {
        int temp = input % 10;
        newValue = newValue * 10 + temp;
        input = input / 10;
    }

    if (newValue == old)
    {
        Console.WriteLine("Input is a palindrome");
    }
    
    else
    {
        Console.WriteLine("Input is not a palindrome");
    }
}

Result(input);
