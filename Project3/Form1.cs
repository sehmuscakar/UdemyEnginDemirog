using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
           CustomerManager customerManager = new CustomerManager(); // tek bir class ta birden fazla iş sınıfını çağıramazsın çağırsanda ayrı ayrı oluşurlar çünkü referasn tipindeler

        private void Form1_Load(object sender, EventArgs e)
        {
         //   CustomerManager customerManager = new CustomerManager(); // burda bunu new lediğimiz için bu clasın ctoru çalışır eğer yazmasanda arkplanda çalışır yazıp orda doldurman lazım verilerini
            dgrdwCustomers.DataSource = customerManager.GetAll() ;//datasource bizden bir obje ister bizde bir liste türünü döndürmemiz yetreli olur
       dgrdwCustomers.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;//colonlarımın içini dolduruyor
        }

   
   

        private void btnAdd_Click_1(object sender, EventArgs e)// senin bi şekilde o textboxlarının içini doldurmamn lazım 
        {
            //   CustomerManager customerManager = new CustomerManager();

            Customer customer = new Customer();//bunun içini dolduracaz ve iş sınıfımızda çağracaz

            customer.Id = Convert.ToInt32(tbxId.Text);//casting işlemi yaptık
            customer.FirstName = tbxFirstName.Text;
            customer.LastName = tbxLastName.Text;
            customer.Email = tbxEmail.Text;
            customer.City = tbxCity.Text;
            customerManager.Add(customer);
            dgrdwCustomers.DataSource = null;
            dgrdwCustomers.DataSource = customerManager.GetAll();

            MessageBox.Show("Ürün kaydınız eklendi.");
        }
    }
}
