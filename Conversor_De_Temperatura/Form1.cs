using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor_De_Temperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnFahrenheitC_Click_1(object sender, EventArgs e)
        {
            float Fahrenheit = float.Parse(TbxFahrenheit.Text);
            float Celcius = (Fahrenheit - 32) * 5.0f / 9.0f;
            TbxCelcius.Text = Celcius.ToString();
        }



        private void btnCelciusF_Click_1(object sender, EventArgs e)
        {
            float Celcius = float.Parse(TbxCelcius.Text);
            float Fahrenheit = (Celcius * 9f / 5f) + 32;
            TbxFahrenheit.Text = Fahrenheit.ToString();
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            TbxFahrenheit.Text = "0.0";
            TbxCelcius.Text = "0.0";
            MessageBox.Show("Se limpiaron los valores de los texBox");
        }
    }

}
