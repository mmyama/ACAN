using ACANApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACANApp.ViewModels
{
    public class CulturaViewModel
    {
        public TextosCultura TextosCultura = new TextosCultura();

        public string TextoEspirito
        {
            get
            {
                return TextosCultura.TXTESPIRITO;
            }
        }
        public string TextoHakama
        {
            get
            {
                return TextosCultura.TXTHAKAMA;
            }
        }
        public string TextoKimono
        {
            get
            {
                return TextosCultura.TXTKIMONO;
            }
        }
        public string TextoCaligrafia
        {
            get
            {
                return TextosCultura.TXTCALIGRAFIA;
            }
        }
        public string TextoTienShen
        {
            get
            {
                return TextosCultura.TXTTIENSHEN;
            }
        }
        public string TextoZanshin
        {
            get
            {
                return TextosCultura.TXTZANSHIN;
            }
        }
        public string TextoSeiza
        {
            get
            {
                return TextosCultura.TXTSEIZA;
            }
        }
    }
}
