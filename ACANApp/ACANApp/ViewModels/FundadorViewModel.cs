using ACANApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACANApp.ViewModels
{
    public class FundadorViewModel
    {
        public TextosFundador TextosFundador = new TextosFundador();

        public string TextoFundador
        {
            get
            {
                return TextosFundador.TXTFUNDADOR;
            }
        }
        public string TextoAikido
        {
            get
            {
                return TextosFundador.TXTAIKIDO;
            }
        }

    }
}
