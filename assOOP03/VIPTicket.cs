using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assOOP03
{
    internal class VIPTicket:Ticket
    {
        private decimal serviesfee;
        public bool LoungeAccess { get; set; }
        public VIPTicket(string moviename, decimal pri,bool _LoungAcess):base(moviename,pri)
        {
            LoungeAccess = _LoungAcess;
            serviesfee = 50;
        }
        public override string ToString()
        {
            return $"{ base.ToString()} | Lounge : {LoungeAccess} | ServiceFee : {serviesfee} EGP";
        }
    }
}
