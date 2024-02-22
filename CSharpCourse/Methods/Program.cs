static void Add()
{
    Console.WriteLine("Added!");
}
static int Add2(int number1 = 20, int number2 = 30)
{
    return (number1 + number2);
}

static int Add3(ref int number1, int number2)
{
    number1 = 30;
    return (number1 + number2);
}

static int Add4(out int number1, int number2)
{
    number1 = 30;
    return (number1 + number2);
}

static int Multiply(int number1, int number2)
{
    int result = number1 * number2;
    return result;
}

//static int Multiply(int number1, int number2, int number3)
//{
//    int result = number1 * number2 * number3;
//    return result;
//}

// params, birden fazla aynı tipte parametre gönderebilmemizi sağlar (dizi vari)
static int Add5(params int[] numbers)
{
    return numbers.Sum();
}

Add();

var result = Add2(2,3);
Console.WriteLine(result);

var result2 = Add2(3);
Console.WriteLine(result2);

int number1 = 20;
int number2 = 100;
var result3 = Add3(ref number1, number2);

Console.WriteLine(result3);
Console.WriteLine(number1);

// ref keyword'ü ile out keyword'ü arasındaki fark,
// ref keyword ile gönderilen değerin öncesinde değer atanmış olması gerekir, method dışında
// out'da böyle bir şeye gerek yoktur, out keyword'ü ile gönderilen değerin method içerisinde en az bir kez set edilmesi gerekir

int number3;
int number4 = 40;
var result4 = Add4(out number3, number4);

Console.WriteLine(result4);
Console.WriteLine(number3);

Console.WriteLine(Multiply(2, 3));
//Console.WriteLine(Multiply(2, 3, 4));

// params

Console.WriteLine(Add5(1,2,3,4,5,6));

Console.ReadLine();