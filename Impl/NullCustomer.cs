using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern_null_object
{
    public class NullCustomer : AbstractCustomer
    {
        public override string GetName()
        {
            return "Not available in customer Database.";
        }

        public override bool IsNull()
        {
            return true;
        }
    }
}
