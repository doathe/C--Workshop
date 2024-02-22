string[] students = new string[3];
//string[] students = new string[3] { "Engin", "Derin", "Salih" };
students[0] = "Engin";
students[1] = "Derin";
students[2] = "Salih";

string[] students2 = {"Engin", "Derin", "Salih"};


foreach (var student in students)
{
    Console.WriteLine(student);
}
//                          satır, sütun
string[,] regions = new string[7, 3]
{
    {"İstanbul", "İzmit", "Sakarya" },
    {"Ankara", "Konya", "Kırıkkale" },
    {"Antalya", "Adana", "Mersin" },
    {"Rize", "Trabzon", "Samsun" },
    {"İzmir", "Muğla", "Manisa" },
    {"Ağrı", "Van", "Kars" },
    {"Gaziantep", "Diyarbakır", "Mardin" },
};

for (int i = 0; i <= regions.GetUpperBound(0); i++)
{
    for (int j = 0; j < regions.GetUpperBound(1); j++)
    {
        Console.WriteLine(regions[i,j]);
    }
    Console.WriteLine("**************");
}

Console.ReadLine();