using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace ACANApp.Models
{
    public class EnviarEmail
    {

        public async Task SendMail(string endereço)
        {
            try
            {
                var message = new EmailMessage
                {
                    To = { endereço },
                };
                await Email.ComposeAsync(message);
            }
            catch (FeatureNotSupportedException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
