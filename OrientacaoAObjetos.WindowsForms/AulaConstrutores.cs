using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrientacaoAObjetos.Dia2;

namespace OrientacaoAObjetos.WindowsForms
{
    public partial class AulaConstrutores : Form
    {
        public AulaConstrutores()
        {
            InitializeComponent();
        }

        private void buttonConstrVazio_Click(object sender, EventArgs e)
        {
            Segurado segurado = new Segurado(); // chamou o construtor vazio Segurado()
            MessageBox.Show(segurado.Teste());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Segurado segurado = new Segurado("Matheus");
            MessageBox.Show("Nome: " + segurado.Nome);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Segurado segurado = new Segurado(1);
            MessageBox.Show("id: " + segurado.Id);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Segurado segurado = new Segurado("Matheus", "04792782104");
            MessageBox.Show("Nome: " + segurado.Nome + "\n" + "CPF: " + segurado.CPF);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new RevisaoConstrutores().Show();
        }
    }
}
