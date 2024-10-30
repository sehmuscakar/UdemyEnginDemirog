using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // int,string onlarda birer class tır aslında 

            int deger = 10; //mesela student bir şablon aslında int de bir şablon aslında ikisi arka planda bir class  
            // int sınıfından deger isminde bir örnek yani instance üretin 
            // student calssından da ogrenci1 adında bir örnek türetin 

            List<string> isimler = new List<string>() { "Şehmus", "Ali", "Murat" };
            List<int> yaslar = new List<int>() { 23, 25, 13 };
            List<string> mailler = new List<string>() { "sehmus@gmail..com", "ali@gmail.com", "murat@gmail.com" };

            for (int i = 0; i < 4; i++)
            {
              //  MessageBox.Show(isimler[i] + " " + yaslar[i] + " " + mailler[i]);
            }

            //tabiki OOP daha kolay diğeri daha zor
            Student ogrenci1 = new Student();
            ogrenci1.FirstName = "Şehmus";
            ogrenci1.Age = 23;
            ogrenci1.Mail = "sehmus@gmail.com";

            Student ogrenci2 = new Student();
            ogrenci2.FirstName = "Murat";
            ogrenci2.Age = 28;
            ogrenci2.Mail = "Murat@gmail.com";

            Student ogrenci3 = new Student();
            ogrenci3.FirstName = "Ali";
            ogrenci3.Age = 43;
            ogrenci3.Mail = "Ali@gmail.com";


            List<Student> students = new List<Student>() { ogrenci1, ogrenci2, ogrenci3 }; //classların listesiinide böyle oluştururuz.

            foreach (Student student in students) //foreach isimlendirmesinide böyle yap 
            {
              //  MessageBox.Show(student.FirstName+" "+student.Age +" ");
              lbxStudent.Items.Add(student.FirstName);
            }

            dgrwStudent.DataSource = students;
        }
    }
}
