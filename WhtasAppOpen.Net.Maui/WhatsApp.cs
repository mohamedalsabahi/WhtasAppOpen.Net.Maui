using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhtasAppOpen.Net.Maui
{
    public class WhatsApp
    {

    


        public static void OpenWithMessage(string phoneNumber, string msg = null)
        {
            try
            {
                var uri = "whatsapp://send?phone=" + phoneNumber;

                if (!string.IsNullOrWhiteSpace(msg))
                    uri += "&text=" + msg;

                Launcher.Default.OpenAsync(new Uri(uri));

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public static void OpenNoMessage(string phoneNumber) {

            var uri = "whatsapp://send?phone=" + phoneNumber;

            Launcher.Default.OpenAsync(new Uri(uri));

        }
}
}
