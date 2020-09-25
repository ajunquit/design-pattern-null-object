using design_pattern_null_object.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern_null_object
{
    public class CustomerFactory
    {
        public static AbstractCustomer GetCustomerByName(string name) {

            // instance fakedatabase
            var database = new FakeDatabase();

            var customer = database.FindByName(name);

            if (customer!= null)
            {
                return customer;
            }
            
            return new NullCustomer();
        }
    }
}
