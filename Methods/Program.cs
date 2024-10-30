
Matematik matematik =new Matematik();


int sonuc= matematik.Topla(2, 3); // metodumuzdaki return ifadesi aslında sonuc değişkenimize 5 değerini vermesidir bize geri döndürdüğü için
//int sonuc2=matematik.Topla(2);
int sonuc3=matematik.Topla(sayi2:50,sayi1:41); //eğer karışık vermek isterseniz ancak böyle yaparsınız yoksa hata olur sırasıyla vermeniz lazaım parametreleri
 //matematik.Topla();
matematik.ParamsTopla(new int[] {8, 1, 2, 5, 6 }); //array göndermenin kısa yöntemi
matematik.ParamsTopla(8, 1, 2, 5, 6 );//şu şekilde de gönderebilirsin, 0 tane paremtre degöndersebilrisin array ın uzunluğu 0 mış gibi kabul eder

class Matematik
{
    //public int Topla(int sayi1, int sayi2=100) //burdaki 2.ci paremtrede default değerini verrdik isteseydin vermeyebilridin eğer vermeseydin kullandığın yerde iki tane girmek zorundaydın ve en son paremetrede bunuu yapabilrisn 
    //{
    //    return sayi1 + sayi2; // debug ile test edebilirsin 
    //}

    public int Topla(int sayi1, int sayi2) // overloading :aşı yüklenme ne bu peki bir class'ta aynı metotun farklı paretrelerin almasıdır.
    {
        return sayi1 + sayi2; 
    }
    public int Topla(int sayi1, int sayi2, int sayi3 )
    {
        return sayi1 + sayi2+sayi3;
    }

    public int ParamsTopla(params int[] sayilar)
    {
        //int sonuc = 0;
        //foreach (int sayi in sayilar) 
        //{
        ////sonuc += sayi;
        //sonuc= sonuc+sayi;
        //}
        //return sonuc;
        //başka yöntem
        return sayilar.Count(); //genelde bu yöntemi collectiona yani listelere uygularız
    }
}