using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
   public class SMSSender
    {
        public void OnAddedAgenda(object o, AgendaEventArgs e)
        {
            Console.WriteLine("SMS Sender: SMS was send!!! Date: " + e.Agenda.AgendaDate + "Title" + e.Agenda.AgendaName);

        }

    }
}
