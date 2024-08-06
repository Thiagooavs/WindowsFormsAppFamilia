using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppFamilia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bnt_Calcular_Click(object sender, EventArgs e)
        {
            int gasto = int.Parse(txt_Agua.Text) + int.Parse(txt_Alimentacao.Text) + int.Parse(txt_Energia.Text) + int.Parse(txt_outro.Text) + int.Parse(txt_TV.Text);
            int saldo = int.Parse(txt_Grana.Text) - gasto;
            
            lbl_Saldo.Text = saldo.ToString("C");
            lbl_Total.Text = gasto.ToString("C");

        }

        private void bnt_Limpar_Click(object sender, EventArgs e)
        {
            txt_Agua.Text = "";
            txt_Alimentacao.Text= "";
            txt_Energia.Text = "";
            txt_Grana.Text = "";
            txt_outro.Text = "";
            txt_TV.Text = "";
            lbl_Saldo.Text = "0";
            lbl_Total.Text = "0";
        }

        private void bnt_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
