using OrientacaoAObjetos.Dia3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrientacaoAObjetos.WindowsForms
{
    public partial class RevisaoConstrutores : Form
    {
        public RevisaoConstrutores()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(); // construtor vazio
            cliente.Nome = txtNome.Text; //set
            cliente.CPF = txtCPF.Text; //set
            MessageBox.Show(cliente.Nome);//get
            MessageBox.Show(cliente.CPF); // get

            /*
            string nome = txtNome.Text;
            string cpf = txtCPF.Text;
            cliente.Nome = nome;
            cliente.CPF = cpf;
            */
        }
    }
}
