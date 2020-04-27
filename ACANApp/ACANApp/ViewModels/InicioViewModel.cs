using ACANApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ACANApp.ViewModels
{
    public class InicioViewModel
    {
        private EnviarEmail enviarEmail = new EnviarEmail();
        private AbrirNavegador abrirNavegador = new AbrirNavegador();

        public ICommand AbrirEmailCommand { get; set; }
        public ICommand AbrirNavegadorCommand { get; set; }

        public InicioViewModel()
        {
            AbrirEmailCommand = new Command<string>(AbrirEmail);
            AbrirNavegadorCommand = new Command<string>(AbrirNavegador);
        }

        public async void AbrirEmail(string endereco)
        {
            await enviarEmail.SendMail(endereco);
        }
        public async void AbrirNavegador(string endereco)
        {
            await abrirNavegador.OpenBrowser(endereco);
        }

    }
}
