using CadastroClientes.Entidade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CadastroClientes.FormsClientes
{
    public partial class ExcluirCliente : Form
    {
        public List<Cliente> ListaClientes;
        public ExcluirCliente(List<Cliente> ListaClientes)
        {
            InitializeComponent();
            this.ListaClientes = ListaClientes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idExcluir = Convert.ToInt32(textBoxIDExcluir.Text);
            Cliente cliente = ListaClientes.Find(cliente => cliente.ID == idExcluir);
            ListaClientes.Remove(cliente);
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
