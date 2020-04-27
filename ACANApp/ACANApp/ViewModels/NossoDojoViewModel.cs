using ACANApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ACANApp.ViewModels
{
    public class NossoDojoViewModel
    {
        private TextosNossoDojo TextosNossoDojo = new TextosNossoDojo();

        public string TextoEtiqueta
        {
            get
            {
                return TextosNossoDojo.TXTETIQUETA;
            }
        }

        private TextosProgramacao TextosProgramacao = new TextosProgramacao();

        public string TextoJaneiro
        {
            get
            {
                return TextosProgramacao.Janeiro;
            }
        }
        public string TextoFevereiro
        {
            get
            {
                return TextosProgramacao.Fevereiro;
            }
        }
        public string TextoMarco
        {
            get
            {
                return TextosProgramacao.Marco;
            }
        }
        public string TextoAbril
        {
            get
            {
                return TextosProgramacao.Abril;
            }
        }
        public string TextoMaio
        {
            get
            {
                return TextosProgramacao.Maio;
            }
        }
        public string TextoJunho
        {
            get
            {
                return TextosProgramacao.Junho;
            }
        }
        public string TextoJulho
        {
            get
            {
                return TextosProgramacao.Julho;
            }
        }
        public string TextoAgosto
        {
            get
            {
                return TextosProgramacao.Agosto;
            }
        }
        public string TextoSetembro
        {
            get
            {
                return TextosProgramacao.Setembro;
            }
        }
        public string TextoOutubro
        {
            get
            {
                return TextosProgramacao.Outubro;
            }
        }
        public string TextoNovembro
        {
            get
            {
                return TextosProgramacao.Novembro;
            }
        }
        public string TextoDezembro
        {
            get
            {
                return TextosProgramacao.Dezembro;
            }
        }

        private EnviarEmail enviarEmail = new EnviarEmail();

        
        public ICommand AbrirEmailCommand { get; private set; }

        public NossoDojoViewModel()
        {
            AbrirEmailCommand = new Command<string>(AbrirEmail);
        }

        public async void AbrirEmail(string email)
        {
            await enviarEmail.SendMail(email);
        }


    }
}

