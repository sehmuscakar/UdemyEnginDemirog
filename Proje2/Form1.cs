using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> stundents;
        private void Form1_Load(object sender, EventArgs e)
        {
            stundents = new List<string>() { "Şehmus", "Yavuz", "Merve", "Ali" };
            foreach (string st in stundents)
            {
                lbxStudentList.Items.Add(st);
            }

          
        }

        private void btnAddStudent_Click(object sender, EventArgs e) // butona tıklanması event olaydır 
        {
            if (tbxStudentName.Text.Length > 2)
            {
                // lbxStudentList.Items.Add(tbxStudentName.Text);
                stundents.Add(tbxStudentName.Text);//ilk önce listeye ekledik diziden ayıran mesele burası işte 
                lbxStudentList.Items.Clear(); //burda çok aşırı hızlı olduğu için görünmüyor 


                foreach (string st in stundents)
                {
                    lbxStudentList.Items.Add(st);
                }
            }
            else
            {
                MessageBox.Show("Ad alanı en az 2 karetkterden oluşmalıdır.");
            }

        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            if (lbxStudentList.SelectedItem!=null)
            {
                stundents.Remove(lbxStudentList.SelectedItem.ToString());//ilk önce listeeden sil
                lbxStudentList.Items.Clear(); //listeyi temzile
                foreach (string st in stundents) //olan verileri yükle
                {
                    lbxStudentList.Items.Add(st);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir öğe seçiniz");
            }

            if (lbxStudentList.Items.Count == 0)
            {
                btnRemoveStudent.Enabled = false;
            }

        }
    }
}
