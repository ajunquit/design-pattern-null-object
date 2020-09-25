using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern_null_object
{
    public class RealCustomer : AbstractCustomer
    {
        public RealCustomer(string name)
        {
            this.Name = name;
        }
        public override string GetName()
        {
            return this.Name;
        }

        public override bool IsNull()
        {
            return false;
        }
    }
}
