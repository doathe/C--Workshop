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

Console.ReadLine();