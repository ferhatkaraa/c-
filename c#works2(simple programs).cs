/*
Description
1-
Girilen sayının çift - tek kontrolü (if)
2-
1 den 10 a kadar sayıları ekrana yazı değeri olarak yazma işlemi (örn 1 girildiğinde ekrana BİR yazılsın - switch yapısı)
3-
Kullanıcı adı admin ve şifre Admin_32453@ olduğunda giriş başarılı değilse başarısız uyarısı veren c# kodu
4-
10-20 20-30 30-40 arası sıcaklık durumlarına göre ekrana (normal - sıcak - çok sıcak) uyarısı veren c# kodu (if else if else if else yapısı)
*/





//1-çift tek sorgu uygulaması
//--------------------------------------------------------------------------------------------------------------------------------


Console.WriteLine("lütfen çift mi tek mi oldugunu merak ettiğiniz sayiyi giriniz.");

int sor = Convert.ToInt32(Console.ReadLine());

if (sor % 2 == 0)
    Console.WriteLine($"{sor} sayisi çift sayidir");
else if(sor % 2 == 1)
        Console.WriteLine($"{sor} sayisi tek sayidir");


//2-switch ile 1'den 10'kadar rakamları yazı olarak bastırma uygulaması
//--------------------------------------------------------------------------------------------------------------------------------


Console.WriteLine("1-10 bir sayi gir");
string x = Console.ReadLine();

switch (x)
{
    case "1": Console.WriteLine("bir");break;
    case "2": Console.WriteLine("iki");break;
    case "3": Console.WriteLine("üç");break;
    case "4": Console.WriteLine("dört");break;
    case "5": Console.WriteLine("beş");break;
    case "6": Console.WriteLine("alti");break;
    case "7": Console.WriteLine("yedi");break;
    case "8": Console.WriteLine("sekiz"); break;
    case "9": Console.WriteLine("dokuz");break;
    case "10": Console.WriteLine("on");break;
    default: Console.WriteLine($"'{x}' 1-10 arasinda değildir lütfen geçerli bir değer girin.");break;
}


//3-Kullanıcı adı admin ve şifre Admin_32453@ olduğunda giriş başarılı değilse başarısız uyarısı veren c# kodu
//--------------------------------------------------------------------------------------------------------------------------------
string data;
string ad;
string sifre;
string sorgu;
data = "<admin><Admin_32453@>-<ferhat><12345>-";
string hesap = "0";
Console.WriteLine("HOSGELDINIZ");
while (hesap != "3")
{
    Console.WriteLine("1-giris\n2-kayit\n3-cikis");
    hesap = Console.ReadLine();
    if (hesap == "1")
    {
        Console.WriteLine("GİRİS EKRANI");
        Console.WriteLine("---------------------------------");
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("kullanici adinizi girin.");
            ad = Console.ReadLine();
            Console.WriteLine("sifrenizi girin.");
            sifre = Console.ReadLine();
            sorgu = $"<{ad}><{sifre}>";
            if (data.Contains(sorgu))
            {
                Console.WriteLine("Giris basarili");
                hesap = "3"; 
                break;
            }else Console.WriteLine($"Giris basarisiz.Tekrar Deneyin.\nkalan deneme hakki {5 - i}");
        }
    }
    else if (hesap == "2")
    {
        Console.WriteLine("KAYIT EKRANI");
        Console.WriteLine("---------------------------------");
        Console.WriteLine("kullanici adinizi girin.");
        ad = Console.ReadLine();
        Console.WriteLine("sifrenizi girin.");
        sifre = Console.ReadLine();
        data += $"<{ad}><{sifre}>-";
        Console.WriteLine("Kayit basarili");
        Console.WriteLine("ana menüye dönülüyor...");
    }
    else if (hesap == "3") Console.WriteLine("Görüsmek üzere");
    else Console.WriteLine("hatali islem\nLütfen 1-2-3 tuşlarindan birine basin");
}




//4-10-20 20-30 30-40 arası sıcaklık durumlarına göre ekrana (normal - sıcak - çok sıcak) uyarısı veren c# kodu (if else if else if else yapısı)
//--------------------------------------------------------------------------------------------------------------------------------

Console.WriteLine("lütfen sicaklik degerini giriniz.");
int sicaklik = int.Parse(Console.ReadLine());


if (sicaklik >= 10 && sicaklik < 20)
{
    Console.WriteLine("normal bir sicaklik var");
}else if (sicaklik >= 20 && sicaklik < 30)
{
    Console.WriteLine("sicak bir hava var.");
}else if (sicaklik >= 30 && sicaklik < 40)
{
    Console.WriteLine("çok sicak bir hava var");
}
else
{
    Console.WriteLine("Bu program sadece 10-40 derece sicakliklari arasinda calismaktadir.");
}

