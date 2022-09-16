using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoKatia_2_
{
    public partial class Form1 : Form
    {
        public Form1() 
        {
            InitializeComponent();
        }

        Jogador obj = new Jogador();
        Jogador[] v = new Jogador[10];
        int i = 0;

        private void btnGravar_Click(object sender, EventArgs e) 
        {
            if (i < 10) 
            {
                obj.Nome = txtNome.Text;
                obj.Time = txtTime.Text;
                obj.Numero = Convert.ToInt32(txtNumero.Text);
                obj.Altura = Convert.ToInt32(txtAltura.Text);
                obj.Idade = Convert.ToInt32(txtIdade.Text);
                obj.Peso = Convert.ToInt32(txtPeso.Text);
                v[i] = obj;
                i++;
            } else 
            {
                MessageBox.Show("Não é possível gravar");
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e) 
        {
            for(int j = 0; j < 10; j++) 
            {
                if (v[j].Nome.Equals(txtNome.Text)) 
                {
                    txtTime.Text = v[j].Time;
                    txtNumero.Text = v[j].Numero.ToString();
                    txtAltura.Text = v[j].Altura.ToString();
                    txtIdade.Text = v[j].Idade.ToString();
                    txtPeso.Text = v[j].Peso.ToString();
                }
            }
        }
    }
}
