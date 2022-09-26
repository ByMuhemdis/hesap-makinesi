
double sayi1, sayi2, hesaplama;

Console.WriteLine("lütfen ilk sayıyı giriniz ");
sayi1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("lütfen ikinci sayıyi giriniz ");
sayi2 =Convert.ToDouble(Console.ReadLine());
Console.WriteLine("lütfen yapılacak işlemi seçiniz ");

string islem = Console.ReadLine();


if (islem == "+")
{
    hesaplama = sayi1 + sayi2;
 
    Console.WriteLine("  sonuç= " + hesaplama);
}
 else if (islem == "-")
{
    hesaplama = sayi1 - sayi2;
    Console.WriteLine("  sonuç= " + hesaplama);
}
 else if (islem == "/")
{
    hesaplama = sayi1 / sayi2;
    Console.WriteLine("  sonuç= " + hesaplama);
}
 else if (islem == "*")
{
    hesaplama = sayi1 * sayi2;
    Console.WriteLine("  sonuç= " + hesaplama);
}
else
{
    Console.WriteLine("yanlış işlm girdiniz lütfen tekrar deneyiniz");

}
Console.Read();
