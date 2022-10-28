// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да


// Console.Clear();
// Console.WriteLine();

Console.WriteLine("Programm to check if five-digit number is a palindrome.");
Console.Write("Input number: ");
int input = int.Parse(Console.ReadLine()!);

while (input < 0)
{
    input = input * -1;
}

void Result(int input)
{
    if (input > 9999 && input < 100000)
    {
        int FrstDgt = 0;
        int ScndDgt = 0;
        int FrthDgt = 0;
        int FthDgt = 0;
        if (input > 9999)
        {
            FrstDgt = input / 10000 % 10;
            ScndDgt = input / 1000 % 10;
            FrthDgt = input / 10 % 10;
            FthDgt = input % 10;
            if (Palindrome(FrstDgt, ScndDgt, FrthDgt, FthDgt))
            {
                Console.WriteLine("Input is a palindrome");
            }
            else
            {
                Console.WriteLine("Input is not a palindrome");
            }
        }
    }
    else
    {
        Console.WriteLine("Wrong input");
    }
}



bool Palindrome(int FrstDgt, int ScndDgt, int FrthDgt, int FthDgt)
{
    return FrstDgt == FthDgt && ScndDgt == FrthDgt;
}

Result(input);
