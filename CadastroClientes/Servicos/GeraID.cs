using CadastroClientes.Entidade;
using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroClientes.Servicos
{
    class GeraID
    {
        public static int getNewID(List<Cliente> listaCliente)
        {
            int maiorID = 0;
            listaCliente.ForEach(cliente =>
            {
                if(cliente.ID > maiorID)
                {
                    maiorID = cliente.ID;
                }
            });
            return maiorID + 1;
        }
    }
}
