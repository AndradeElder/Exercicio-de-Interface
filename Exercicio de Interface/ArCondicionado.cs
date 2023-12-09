using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_de_Interface
{
    internal class ArCondicionado : IDispositivelEletronico
    {
        public bool Status { get; set; }

        public void Desligar()
        {
            Status = false;
        }

        public void Ligar()
        {
            Status = true;
        }

        public string StatusDispositivo()
        {
            if (Status)
            {
                return "Ligado";
            }
            else
            {
                return "Desligado";
            }

        }

    }
}
