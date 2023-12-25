using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace math_sınıfı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(txtSayi.Text);

            double sayiMutlak = Math.Abs(sayi);
            double sayiYukariYuvarla = Math.Ceiling(sayi);
            double yuvarlama = Math.Round(sayi);
            double sayiAsagiYuvarla = Math.Floor(sayi);
            double karekok = Math.Sqrt(sayi);
            double sayiUs = Math.Pow(sayi, 2);
                                  
            lblUst.Text = "Sayının kuvveti :" + sayiUs.ToString();
            lblKok.Text = "Sayının karekökü :" + karekok.ToString();
            lblMutlak.Text = " Sayının mutlak değeri :" + sayiMutlak.ToString();
            lblYukari.Text = "Sayının yukarı yuvarlanmış hali :" + sayiYukariYuvarla.ToString();
            lblYuvarlama.Text = "Sayının yuvarlanmış hali :" + yuvarlama.ToString();
            lblAsagi.Text = "Sayının aşağı yuvarlanmış hali :" + sayiAsagiYuvarla.ToString();
        }
    }
}
