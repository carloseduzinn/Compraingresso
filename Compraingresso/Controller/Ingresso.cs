using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compraingresso.Controller
{
    internal class Ingresso
    {
        public decimal Calcular( decimal valor, decimal qtd)
        {
            decimal resul;
            resul = qtd * valor;
            return  resul;
                  

        }
    }
    
    

}




