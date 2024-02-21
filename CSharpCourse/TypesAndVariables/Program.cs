//Console.WriteLine("Hello, World!");

// Value Types

int number1 = 2147483647;           // 32 bit
long number2 = 9223372036854775807; // 64 bit
short number3 = 32767;              // 16 bit
byte number4 = 255;                 // 8 bit

double number5 = 10.4;              // Virgülden sonra 15,16 değer alıyorsa decimal virgülden sonra 28,29 değer alır.
decimal number6 = 10.4m;            // Sonuna m/M ekliyoruz

bool condition = false;

char character = 'A';               // char tek tırnak, string çift tırnak

var number7 = 10;                   // Atamaya çalıştığımız değerin tipini alır.
number7 = 'A';

Console.WriteLine("Number1 is {0}", number1);
Console.WriteLine("Number2 is {0}", number2);
Console.WriteLine("Number3 is {0}", number3);
Console.WriteLine("Number4 is {0}", number4);
Console.WriteLine("Number5 is {0}", number5);
Console.WriteLine("Number6 is {0}", number6);


Console.WriteLine("Character is {0}", character);
Console.WriteLine("Character is {0}", (int)character);

Console.WriteLine("Condition is {0}", condition);

Console.WriteLine("Number7 is {0}", number7);

// enum
Console.WriteLine(Days.Friday);
Console.WriteLine((int)Days.Friday);
Console.WriteLine((int)Day.Friday);




Console.ReadLine();

// 0'dan başlar
enum Days
{
    Monday, 
    Tuesday, 
    Wednesday, 
    Thursday, 
    Friday, 
    Saturday, 
    Sunday
}

enum Day
{
    Monday = 20, 
    Tuesday, 
    Wednesday, 
    Thursday, 
    Friday, 
    Saturday, 
    Sunday
}