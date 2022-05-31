using ProjetoElevador.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoElevador.Views
{
    public class ElevadorView
    {
       Models.Elevador elevador = new Elevador();

        public void Tela()
        {
            elevador.Menu();
        }

        

    }
}
