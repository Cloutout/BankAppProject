using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.EntityLayer.Concrete
{
    //musterinin hesap islemlerini tutar
    public class CustomerAccountProcess
    {
        public int CustomerAccountProcessID { get; set; }
        public string CustomerAccountProcessProcessType { get; set; }
        public decimal CustomerAccountProcessProcessAmount { get; set; }
        public DateTime CustomerAccountProcessProcessDate { get; set; }


    }
}
