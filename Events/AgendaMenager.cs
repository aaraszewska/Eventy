using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Events
{
   public  class AgendaMenager
    {
        public delegate void AddedAgendaEventHandler(Object o, AgendaEventArgs e);
        public event AddedAgendaEventHandler AddedAgenda;

        /// <summary>
        /// Enter publisher
        /// protected
        /// virtual
        /// void
        /// name startb to On
        /// podnies nam evant 
        /// </summary>
        protected virtual void OnAddedAgenda(Agenda newAgenda)
        {
            if (AddedAgenda != null)
                AddedAgenda(this, new AgendaEventArgs() { Agenda = newAgenda });
        }
        public void AddAgenda( Agenda newAgenda)
        {
            Console.WriteLine("AddAgenda : I'm starting to add....");
            Thread.Sleep(300);// usypianie 
            OnAddedAgenda(newAgenda);
            Console.WriteLine("Finish add");
        }
    }
}
