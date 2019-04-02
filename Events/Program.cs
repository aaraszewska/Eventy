using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            AgendaMenager amgr = new AgendaMenager();
            SMSSender sms = new SMSSender();

            amgr.AddedAgenda += sms.OnAddedAgenda;

            amgr.AddAgenda(new Agenda()
                {
                AgendaDate = DateTime.Now.AddDays(2),
                AgendaName = "Kubus puchatek"
});
          
            Console.Read();
        }
    }
}
