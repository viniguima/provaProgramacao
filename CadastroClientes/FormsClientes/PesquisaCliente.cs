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
    public partial class PesquisaCliente : Form
    {
        private List<Cliente> ListaClientes;
        public PesquisaCliente(List<Cliente> ListaClientes)
        {
            InitializeComponent();
            this.ListaClientes = ListaClientes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBoxPesquisa.Clear();
            String busca = textBoxPesquisa.Text;

            List<Cliente> resultaClientes = ListaClientes.FindAll(cliente =>
            
                cliente.Nome.Contains(busca) ||
                cliente.Email.Contains(busca) ||
                cliente.Fone.Contains(busca) 
            );

            resultaClientes.ForEach(cliente =>
            {
                richTextBoxPesquisa.AppendText(cliente.ToString());  
            });
        }
    }
}
