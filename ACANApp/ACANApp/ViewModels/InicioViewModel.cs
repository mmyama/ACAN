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

        public ICommand AbrirEmailCommand { get; set; }

        public InicioViewModel()
        {
            AbrirEmailCommand = new Command(AbrirEmail);
        }

        public async void AbrirEmail()
        {
            await enviarEmail.SendMail("aikidonatal@gmail.com");
        }

    }
}
