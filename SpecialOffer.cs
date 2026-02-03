//==========================================================
// Student Number : S1234567
// Student Name : [Your Name]
// Partner Name : [Partner Name]
//==========================================================

using System;

namespace GruberooFoodDelivery
{
    class SpecialOffer
    {
        private string offerCode;
        private string description;
        private double discountAmount;

        // Properties
        public string OfferCode
        {
            get { return offerCode; }
            set { offerCode = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public double DiscountAmount
        {
            get { return discountAmount; }
            set { discountAmount = value; }
        }

        // Constructor
        public SpecialOffer() { }

        public SpecialOffer(string offerCode, string description, double discountAmount)
        {
            this.offerCode = offerCode;
            this.description = description;
            this.discountAmount = discountAmount;
        }

        // ToString method
        public override string ToString()
        {
            if (discountAmount == 0)
            {
                return $"{offerCode}: {description}";
            }
            else
            {
                return $"{offerCode}: {description} - {discountAmount}% off";
            }
        }
    }
}
