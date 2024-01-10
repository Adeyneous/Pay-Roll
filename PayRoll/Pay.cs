using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayRoll
{
    public class Pay
    {
        private string Monday;
        private string Tuesday;
        private string Wednesday;
        private string Thursday;
        private string Friday;
        private string Saturday;
        private string Sunday;

        public Pay() { }


       
    public Pay(string monday, string tuesday, string wednesday, string thursday, string friday, string saturday, string sunday)
        {
            Monday = monday;
            Tuesday = tuesday;
            Wednesday = wednesday;
            Thursday = thursday;
            Friday = friday;
            Saturday = saturday;
            Sunday = sunday;
        }

    public string DateMonday
    {
            get
            {
                return Monday;
            }
            set
            {
                
            }
        }
    }
  


}
