//==========================================================
// Student Number : S1234567
// Student Name : [Your Name]
// Partner Name : [Partner Name]
//==========================================================

using System;

namespace GruberooFoodDelivery
{
    class Payment
    {
        private string paymentMethod;
        private DateTime paymentDate;

        // Properties
        public string PaymentMethod
        {
            get { return paymentMethod; }
            set { paymentMethod = value; }
        }

        public DateTime PaymentDate
        {
            get { return paymentDate; }
            set { paymentDate = value; }
        }

        // Constructor
        public Payment() { }

        public Payment(string paymentMethod, DateTime paymentDate)
        {
            this.paymentMethod = paymentMethod;
            this.paymentDate = paymentDate;
        }

        // ToString method
        public override string ToString()
        {
            return $"Payment Method: {paymentMethod}, Date: {paymentDate:dd/MM/yyyy HH:mm}";
        }
    }
}
