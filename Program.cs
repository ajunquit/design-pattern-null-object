using System;

namespace design_pattern_null_object
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractCustomer customerKatherine = CustomerFactory.GetCustomerByName("Katherine");
            Console.WriteLine("Name: {0} Is Null: {1}", customerKatherine.GetName(), customerKatherine.IsNull());

            AbstractCustomer customerValentina = CustomerFactory.GetCustomerByName("Valentina");
            Console.WriteLine("Name: {0} Is Null: {1}", customerValentina.GetName(), customerValentina.IsNull());

            AbstractCustomer customerAgustin = CustomerFactory.GetCustomerByName("Agustin");
            Console.WriteLine("Name: {0} Is Null: {1}", customerAgustin.GetName(), customerAgustin.IsNull());
            Console.ReadLine();
        }
    }
}
