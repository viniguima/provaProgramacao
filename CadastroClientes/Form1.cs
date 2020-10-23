using CadastroClientes.Entidade;
using CadastroClientes.FormsClientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroClientes
{
    public partial class Form1 : Form
    {
        private List<Cliente> ListaClientes;
        public Form1()
        {
            InitializeComponent();
            ListaClientes = new List<Cliente>();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ecerrando o sistema!");

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormsClientes.InserirCliente formCliente = new FormsClientes.InserirCliente(ListaClientes);
            formCliente.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListarCliente listarCliente = new ListarCliente(ListaClientes);
            listarCliente.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExcluirCliente excluirCliente = new ExcluirCliente(ListaClientes);
            excluirCliente.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PesquisaCliente pesquisaCliente = new PesquisaCliente(ListaClientes);
            pesquisaCliente.Show();
        }
    }
}
