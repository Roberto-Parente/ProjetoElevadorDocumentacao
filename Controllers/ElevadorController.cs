using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoElevador.Models;
using ProjetoElevador.Views;

namespace ProjetoElevador.Controllers
{
    internal class ElevadorController
    {
    
        ElevadorView elevadorView = new ElevadorView();

        public void MostrarTela()
        {
            elevadorView.Tela();
        }

    }
}
