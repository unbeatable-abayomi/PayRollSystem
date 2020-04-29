using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace PayRollSystem
{
    class PaymentCollection <T> where T : IPayment

    {

        private T[] payments;
        private int numElements;
        private const int DEAFUALTSIZE = 5;


        public PaymentCollection()
        {
            payments = new T[DEAFUALTSIZE];
            numElements = 0;
        }

        public PaymentCollection(int size)
        {
            payments = new T[size];
            numElements = 0;
        }

        public void Add(T item)
        {
            if(numElements < payments.Length)
            {
                payments[numElements] = item;
                numElements++;
            }
            else
            {
                throw new System.Exception("PAyment  is full");
            }
        }

        public T Remove()
        {
            if(numElements != 0)
            {
                T item = payments[--numElements];
                return item;
            }
            //else
            //{
                throw new System.Exception("PAyment is empty");
            //}
            
        } 
    }
}
