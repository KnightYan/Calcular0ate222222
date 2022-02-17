using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcular0ate222222
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int quantidadeDeVezes = 0;
            for(int i=0; i<=222222;i++)
            {
                string aux = i.ToString();
                while (aux.Contains("0"))
                {
                    quantidadeDeVezes++;
                    int indexOfZero = aux.IndexOf("0");
                    aux = aux.Remove(indexOfZero, 1);
                }
            }

            MessageBox.Show("Quantidade de vezes são: " + quantidadeDeVezes);
        }
    }
}
