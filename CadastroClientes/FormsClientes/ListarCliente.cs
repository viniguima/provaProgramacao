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
    public partial class ListarCliente : Form
    {
       
        public ListarCliente(List<Cliente> ListaClientes)
        {
            InitializeComponent();
            MostraClientes(ListaClientes);
        }


        private void MostraClientes(List<Cliente> ListaClientes) 
        {

            ListaClientes.ForEach(cliente =>
            {

                richTextBoxClientes.AppendText(cliente.ToString());

            });
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
