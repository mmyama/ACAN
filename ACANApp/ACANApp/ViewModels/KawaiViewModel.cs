using ACANApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACANApp.ViewModels
{
    public class KawaiViewModel
    {
        public TextosKawai TextosKawai = new TextosKawai();

        public string TextoKawai
        {
            get
            {
                return TextosKawai.TXTKAWAI;
            }
        }

    }
}
