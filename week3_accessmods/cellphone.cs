using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_accessmods
{
    class cellphone
    {
        private string phoneNumber;
        private string phoneCarrier;
        private string phoneModel;

        public string Carrier
        {
            get { return phoneCarrier; }
            set { phoneCarrier = value; }
        }
        
        public string Number
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public cellphone()
        {

        }

        public cellphone(string phoneNumber, string phoneCarrier, string phoneModel)
        {
            this.phoneNumber = phoneNumber;
            this.phoneCarrier = phoneCarrier;
            this.phoneModel = phoneModel;
        }

        public void PhoneInfo()
        {
            Console.WriteLine("Customer Number:" + phoneNumber);
            Console.WriteLine("Customer Carrier:" + phoneCarrier);
            Console.WriteLine("Customer Model:" + phoneModel);
        }





    }
}
