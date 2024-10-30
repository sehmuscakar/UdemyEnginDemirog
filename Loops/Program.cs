string[] students = new string[3];
students[0] = "Ali";
students[1] = "Mehmet";
students[2] = "Yusuf";

for (int i = 0; i < students.Length; i++)
{
    Console.WriteLine(students[i]);
}
Console.WriteLine("--------------------");
for (int i = 0; i < 3; i++)
{
    Console.WriteLine(students[i]);
}
Console.WriteLine("--------------------");
foreach (string student in students) // burda student alias tır aslında yani takma isimdir
{

    Console.WriteLine(student);
}
Console.WriteLine("--------------------");

int sayac = 0;
while (sayac < 7)
{
    Console.WriteLine("Şehmus");
    sayac++;
  //  sayac = sayac + 1;
}

int sayac1 = 0;
while (sayac1 < 3)
{
    Console.WriteLine(students[sayac1]);
    sayac1++;
    //  sayac = sayac + 1;
}

//not örnek veriiyorum bir string fonksiyonlarını başka bir sınıdın fonnsiyonlarını ezberlemeyin zaten ihityaç olduğunda ctrl+ space(boşluk tuşuna bastığınızda karşınıza çıkar) ihityaç halinde kullanılması daha çok aklıda kalıcı olur 

int rakam1 ;
int rakam2 ;