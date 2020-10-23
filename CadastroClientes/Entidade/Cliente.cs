using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroClientes.Entidade
{
    public class Cliente
    {
        public int ID { get; set; }
        public String Nome { get; set; }
       
        public String Email { get; set; }

        public String Fone { get; set; }

        public override string ToString()
        {
            return "ID:"+ ID + ", Nome:" + Nome + ", Email:" + Email + ", Fone:" + Fone + "\n";
        }
    }
}
