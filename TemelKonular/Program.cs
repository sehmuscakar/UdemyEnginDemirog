//****DEĞİŞKENLER******
//değişkenler: sizin bir uygulamadaki verileri yönetmek için kullanıyoruz o verinin bir tipi vardır hangi formata yani int mi string mi o öenmli 
//YOUTUBE KANALI veya başka bir platformdan değişkenler nerde kullanılıyor örnek ver 

using System.Diagnostics.Metrics;

double aboneSayisi = 34.6; // bunların veri aralığını araştırabilirin data type order c# diye arama yaparsan arlıklarını bulabilirisniz iş hayatında int ve double ile ilerlenir çoğunlukla.
int yas = 23;
short yil = 25500;
byte sayi = 255;



string duyuru = "Duyurmuz var"; //metinsel veri türü

//Soru :Hangisi sadece tam sayı türünde verileri tutmak için kullanılan değişkendir? //int veri tipi ile sadece tam sayı türünde veri tutabiliriz.
//int, string,decimal,double cevap int

//Soru:Hangisi sadece tam sayı türünde verileri tutmak için kullanılan değişkendir?

//double aboneSayisi=34,6 ; int yas=5; sting sayi="15";

//Değişkenin isminin sayı olması onu sayı yapmaz. Değerinin sayı görünümlü olması da onu sayı yapmaz. string ile metinsel veri tutulur.

//C# Data Types bu aramayı yapabilirsiniz başka veri tiplerini öğrenmek için  https://www.w3schools.com/cs/cs_data_types.php bu kaynaktan faydalanabilriisn 

double piyasaDun = 150;

double piyasaBugun = 150.5;

if (piyasaBugun > piyasaDun) //altınin sitesine gidip bakabilirsin
{
    Console.WriteLine("artış");
}
else
{
    Console.WriteLine("azalış");

}


// başka bir yol
string artıOku = "artış oku"; // değişkenleri kullanma sebebimiz birden fazla yerde kullanma ihtimalimizdir ve buda öyledir.
string eksiOku = "azalış oku";
bool sonuc = piyasaBugun > piyasaDun;
bool sonuc2=piyasaBugun >= piyasaDun;
bool sonuc3=piyasaBugun <= piyasaDun;
bool sonuc4=piyasaBugun != piyasaDun; //farklı ise en çok bu kullanılır.
if (sonuc) // hiç bişey yazmasan default olarak true yazar
{
    Console.WriteLine(artıOku);
}
else
{
    Console.WriteLine(eksiOku);
}
// başka bir yol 

if (sonuc==true)
{ 
    Console.WriteLine(artıOku);
}
if (sonuc == false)
{

Console.WriteLine(eksiOku); 
}


//ternary operatörü  
//değer = (koşul) ? değer1 : değer2; 

//koşul: Bir boolean ifade(true veya false döner).
//değer1: Koşul true olduğunda döndürülecek değer.
//değer2: Koşul false olduğunda döndürülecek değer.


int a = 10;
int b = 20;
int enBüyük = (a > b) ? a : b;

Console.WriteLine(enBüyük); // Çıktı: 20

int sayi2 = 150;

string yuzdenBuyuk = sayi2 > 100 ? "Evet" : "Hayır";

Console.WriteLine(yuzdenBuyuk); //Evet sonucu gösterilir.