using System;
using System.Collections.Generic;
using System.Text;

namespace PayRollSystem
{
     public class Invoice:IPayment
     {
        public string ItemName { get; set; }
        public string ItemDesc { get; set; }

        private decimal price;
        private int quantity;

        public Invoice(string item, string desc, decimal itemprice, int itemqty)
        {
            ItemName = item;
            ItemDesc = desc;
            Price = itemprice;
            Quantity = itemqty;

        }

        public decimal Price
        {
            get { return price; }
            set
            {
                if(value > 0m)
                {
                   price = value;
                }
                else
                {
                    throw new System.ArgumentOutOfRangeException("Price Must be greater than zero");
                }
            }
        }

        public int Quantity
        {
            get { return quantity; }
            set
            {
                if(value > 0)
                {
                    quantity = value;
                }
                else
                {
                    throw new System.ArgumentOutOfRangeException("Quantity must be greater than zero");
                }
            }
        }

        public decimal GetPaymentAmount()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return $"Invoice:\n {ItemName}\n Item Description: {ItemDesc}\n Quantity: {Quantity}\n Price {Price:C}\n";
        }

    }
}
