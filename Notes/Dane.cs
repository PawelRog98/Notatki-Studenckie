using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes
{
    public class Dane
    {
        static public string ZapisanaNazwa;
        static public string NotatkaZapisana
        {
            get { return ZapisanaNazwa; }
            set { ZapisanaNazwa = value; }
        }
    }
}
