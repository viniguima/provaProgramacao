using CadastroClientes.Entidade;
using CadastroClientes.Servicos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CadastroClientes.FormsClientes
{
    public partial class InserirCliente : Form
    {
        private List<Cliente> ListaClientes;
        public InserirCliente(List<Cliente> ListaClientes)
        {
            InitializeComponent();
            this.ListaClientes = ListaClientes;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            cliente.ID = GeraID.getNewID(ListaClientes);
            cliente.Nome = textBoxNome.Text;
            cliente.Email = textBoxEmail.Text;
            cliente.Fone = textBoxFone.Text;

            ListaClientes.Add(cliente);
            this.Close();
        }
    }
}
