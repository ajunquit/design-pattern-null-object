using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace design_pattern_null_object.Data
{
    public class FakeDatabase
    {

        List<RealCustomer> _realCustomers;

        public FakeDatabase()
        {
            _realCustomers = new List<RealCustomer>();
            _realCustomers.Add(new RealCustomer("Katherine"));
            _realCustomers.Add(new RealCustomer("Alejandro"));
            _realCustomers.Add(new RealCustomer("Valentina"));
            _realCustomers.Add(new RealCustomer("Mathias"));
        }

        public RealCustomer FindByName(string name) {
            return this._realCustomers.Where(x => x.GetName().Equals(name)).FirstOrDefault();
        }

    }
}
