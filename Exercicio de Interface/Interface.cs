using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_de_Interface
{
    public interface IDispositivelEletronico
    {
        void Ligar();
        void Desligar();
        string StatusDispositivo();

    }
}
