string city = "Ankara";
Console.WriteLine(city[0]);

foreach (var item in city)
{
    Console.WriteLine(item);
}

string city2 = "İstanbul";
string result = city + city2;

Console.WriteLine(String.Format("{0} {1}", city, city2));

// String methods
string sentence = "My name is Engin Demiroğ";

var result2 = sentence.Length;
var result3 = sentence.Clone();
var result4 = sentence.EndsWith("ğ");   // bool döndürür
var result5 = sentence.StartsWith("M"); // bool döndürür
var result6 = sentence.IndexOf("name"); // nerede başlar
var result7 = sentence.IndexOf(" ");    // ilk bulduğunu kabul eder
var result8 = sentence.LastIndexOf(" ");    // son bulduğunu kabul eder
var result9 = sentence.Insert(0, "Hello, ");    // ekleme
var result10 = sentence.Substring(3);   // parçalamak için
var result11 = sentence.Substring(3, 4);    // parçalamak için
var result12 = sentence.ToLower();      // küçük karakter
var result13 = sentence.ToUpper();      // büyük karakter
var result14 = sentence.Replace(" ", "-");  // belirtilen karakteri değiştirir
var result15 = sentence.Remove(2);   // belirtilen konumdan sonrasını atmak için
var result16 = sentence.Remove(2, 8);   // belirtilen konum aralığını atmak için


Console.WriteLine(result2);
Console.WriteLine(result3);
Console.WriteLine(result4);
Console.WriteLine(result5);
Console.WriteLine(result6);
Console.WriteLine(result7);
Console.WriteLine(result8);
Console.WriteLine(result9);
Console.WriteLine(result10);
Console.WriteLine(result11);
Console.WriteLine(result12);
Console.WriteLine(result13);
Console.WriteLine(result14);
Console.WriteLine(result15);
Console.WriteLine(result16);

Console.ReadLine();