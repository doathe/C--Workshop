// for loop
for (int i = 1; i <= 100; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine("Finished!!");

for (int i = 100; i >= 0; i = i - 2)
{
    Console.WriteLine(i);
}
Console.WriteLine("Finished!!");

// while loop
int number = 10;
while (number >= 0)
{
    Console.WriteLine(number);
    number--;
}
Console.WriteLine("Now number is {0}", number);

// do-while loop (Şart sağlanmasa bile bir kere çalışır.)
number = 10;
do
{
    Console.WriteLine(number);
    number--;
} while (number >= 0);

// foreach loop
string[] students = { "Engin", "Derin", "Salih" };
foreach (string student in students)
{
    Console.WriteLine(student);
}

// Prime number example
static bool IsPrimeNumber(int number)
{
    bool result = true;
    for(int i = 2; i < number-1; i++)
    {
        if (number % i == 0)
        {
            result = false;
            i = number;
        }
    }
    return result;
}

if (IsPrimeNumber(10))
{
    Console.WriteLine("This is a prime number");
}
else
{
    Console.WriteLine("This is not a prime number");
}

Console.ReadLine();