/*
HAFTA -1 : Değişken kullanımı ve Değer Okuma - Yazma İşlemleri (6 Uygulama)
1-İki sayının farkını bulan c# kodu
2-5 sayısının karesini bulan c# kodu 
3-10 sayısının 3 ' e bölümünden kalanını bulan  c# kodu 
4-Klavyeden girilen 4 sayının toplamını ve çarpımını bulan c# kodu 
5-Klavyeden girilen 2 sayının bölümünü bulan c# kodu
6-Klavyeden kenarları girilen dikdörtgenler prizmasının hacmini hesaplayan   c# kodu 
 */
//1. örnek-iki sayının farkı
//--------------------------------------------------------------------------------------------------------------------------------
int fark(int s1, int s2)
{
    return s1 - s2;
}


Console.WriteLine("7-4 işleminin sonucu");
Console.WriteLine(fark(7, 4));



Console.WriteLine("-------------------------");
//2. örnek-5 sayının karesi
//--------------------------------------------------------------------------------------------------------------------------------
void kareal()
{
    string strlist = "";
    string sayi;
    int sayiint;
    for (int i = 1; i < 6; i++)
    {
        Console.WriteLine("karesini almak istediğiniz " + Convert.ToString(i) + ". sayiyi giriniz.");
        sayi = Console.ReadLine();
        strlist += sayi + "--->";
        sayiint = Convert.ToInt32(sayi);
        sayiint *= sayiint;
        sayi = Convert.ToString(sayiint);
        strlist += sayi + "\n";
    } 
    Console.WriteLine(strlist); 
}
kareal();

Console.WriteLine("-------------------------");
//3. örnek-10/3 işleminin kalanı
//--------------------------------------------------------------------------------------------------------------------------------
int bölünen = 10;
int bölen = 3;
int bölüm = bölünen/bölen;//python bölme sonucunu float verir c# int verir
int kalan = bölünen - bölen*bölüm;
Console.WriteLine("10/3 işleminden kalan:");
Console.WriteLine(kalan);




Console.WriteLine("-------------------------");
//4. örnek-4 sayının toplamı ve çarpımı
//--------------------------------------------------------------------------------------------------------------------------------
int toplam = 0;
int carpim = 1;
int sayi;
for (int i = 0;i < 4; i++)
{
    Console.WriteLine(Convert.ToString(i + 1) + ".sayiyi girin");
    sayi = Convert.ToInt32(Console.ReadLine());
    toplam += sayi;
    carpim *= sayi;

}
Console.WriteLine($"4 SAYI İÇİN\ntoplamin sonucu --->{toplam}\nçarpımın sonucu --->{carpim}");




Console.WriteLine("-------------------------");
//5. örnek-iki sayının bölümü
//--------------------------------------------------------------------------------------------------------------------------------
Console.WriteLine("bölünecek sayiyi giriniz");
int s1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("bölecek sayiyi giriniz");
int s2 = Convert.ToInt32(Console.ReadLine());
 while (s2 == 0)
{
    Console.WriteLine("bir sayiyi sıfıra bölemezsiniz \n başka bir sayı girin");
    Console.WriteLine("bölecek sayiyi giriniz");
    s2 = Convert.ToInt32(Console.ReadLine());
}
float bölüm1 = (float)s1 / s2;//sonucun float olabilmesi açısından bölme unsurlarından biri float yapıldı

Console.WriteLine($"{s1}/{s2}bölümün sonucu:");
Console.WriteLine(bölüm1);



Console.WriteLine("-------------------------");
//6. örnek-dikdörtgenler prizmasının hacmi
//--------------------------------------------------------------------------------------------------------------------------------
Console.WriteLine("dikdörtgenler prizmasının 1. kenar bilgisini giriniz");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("dikdörtgenler prizmasının 2. kenar bilgisini giriniz");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("dikdörtgenler prizmasının 3. kenar bilgisini giriniz");
int c = Convert.ToInt32(Console.ReadLine());


int alan = a*b*c;

Console.WriteLine("dikdörtgenler prizmasının hacmi:");
Console.WriteLine(alan);

