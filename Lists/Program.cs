string[] sehirler = new string[] { "İstanbul", "Ankara", "İzmir" };

Console.WriteLine(sehirler.Length);

//sehirler.Add(); // yarın übürgün ekleme sayfasından ekleme yapmak istediğimizde olmayacaktır bu yüzden listeler kullanırız gerçek hayata

//listelerde arkaplanda dizi gibi çalışır aöa liste mantığını anlamak için dizileri iyi anlamak gerekir

//sehirler[3] = "Diyarbakır";// buda outside hatası verecektir cünkü arrays dişina çıktın

sehirler = new string[4]; // bu şekilde de dizi oluşturabilirsin , burda bellekte yeni bir alan oluşturur yeni bir liste oluşturur
sehirler[3] = "Adana";
foreach (string s in sehirler)
{
    Console.WriteLine(s);
}

//listeler arka planda bir diziyi yönetiyor

List<string> sehirler2 = new List<string>();
Console.WriteLine(sehirler2.Count());

List<string> sehirler3 = new List<string>() { "Şehmus", "Ali", "Akif", "Mehmet" };
Console.WriteLine(sehirler3.Count());

sehirler3.Add("Merve");
foreach (string s in sehirler3)
{

    Console.WriteLine(s);
}
sehirler3.Remove("Ali");
bool sounc= sehirler3.Contains("Akif");

Console.WriteLine(sounc);
