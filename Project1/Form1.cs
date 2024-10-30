using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //bz burda bir e ticaret similasyonunu yaptık genel olarak yazılım mantığınınn nasıl açlıştığını anlıyoruz.
        private void Form1_Load(object sender, EventArgs e) //event deniliyor
        {
            // araçları isimlendirirken değişkenlere verilen isimler gibi yapılır.
            //microsft verdiği isimlendirme standartları kullanılır
            //bu tarafta  da propertylerin ve eventler gwlir.


            //lblProducts.Text = "Ürünler";
            //lbxProducts.Items.Add("Laptop");
            //lbxProducts.Items.Add("Masaüstü PC");
            //lbxProducts.Items.Add("Klavye");


            string product = "Ürünler";
            string btnAddtoCart = "Sepete Ekle";
            string cartText = "Sepetiniz";
            var removeFromCartButtonText = "Sepeten Çıkar";

            lblProducts.Text = product; // bunu buyle birden fazla yerde kullanabiliriz.
            btnAddToCart.Text = btnAddtoCart;
            lblCart.Text = cartText;
            btnRemoveFromCart.Text = removeFromCartButtonText;


            string[] products = new string[] { "Ahmet", "Murat" };
            foreach (var item in products) // burda arka planda index numarasını baz alır fora göre
            {
                lbxProducts.Items.Add(item);
            }
            for (int i = 0; i < products.Length; i++)
            {

                lbxProducts.Items.Add(products[i]);

            }
            if (lbxCart.Items.Count == 0)
            {
                btnRemoveFromCart.Enabled = false;
            }
        }
        //diyelim çğe seçmeden butona bastı uygulamanın kırılması yada yaptladı deriz // hata olduğunda
        private void btnAddToCart_Click(object sender, EventArgs e)
        {


            // MessageBox.Show("Buttona Tıklandı");

            //    lbxCart.Items.Add(lbxProducts.SelectedItem);
            //  MessageBox.Show(lbxProducts.SelectedItem.ToString());

            if (lbxProducts.SelectedItem != null)
            {
                lbxCart.Items.Add(lbxProducts.SelectedItem);
            }
            else
            {

                MessageBox.Show("lütfen bir eleman seçiniz");
            }
            btnRemoveFromCart.Enabled = true;
        }
        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (lbxCart.SelectedItem != null)
            {
                lbxCart.Items.Remove(lbxCart.SelectedItem);
              
            }
            else
            {
                MessageBox.Show("Öncelikle bir ürün seçmelisiniz");
            }

            if (lbxCart.Items.Count == 0)
            {
                btnRemoveFromCart.Enabled = false;
            }
        }
    }
}
