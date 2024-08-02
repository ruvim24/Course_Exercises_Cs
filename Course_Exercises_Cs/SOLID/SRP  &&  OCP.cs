using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects.SOLID
{

    public class Save
    {
        // Salvarea comenzii în baza de date
        public void SaveToDatabase()
        {
            Console.WriteLine("Saving order to database...");
        }

        // Încarcă comanda din baza de date
        public void LoadFromDatabase(int orderId)
        {
            Console.WriteLine("Loading order from database...");
        }
    }

    public interface IProcesPayment 
    {
        void Proces();
    }
    

    public class ProcesPaymentCrditCard : IProcesPayment 
    {
        public void Proces()
        {
            Console.WriteLine("Processing credit card payment...");
        }
    }
    public class ProcesPaymentPayPal : IProcesPayment
    {
        public void Proces()
        {
            Console.WriteLine("Processing PayPal payment...");

        }
    }
    public class ProcesPaymentBankTransfer : IProcesPayment
    {
        public void Proces()
        {
            Console.WriteLine("Processing bank transfer payment...");
        }
    }
    public class Order
    {
        public int Id { get; set; }
        public double Amount { get; set; }

    }

}
