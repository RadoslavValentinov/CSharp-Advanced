using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class StationaryPhone : Smartphone
    {
        public void Dialing(string model)
        {
            
        }
        public StationaryPhone(string model) 
            : base(model)
        {
        }
    }
}
