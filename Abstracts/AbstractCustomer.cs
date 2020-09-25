using System;
using System.Collections.Generic;
using System.Text;

namespace design_pattern_null_object
{
    public abstract class AbstractCustomer
    {
        protected string Name;

        public abstract bool IsNull();
        public abstract string GetName();

    }
}
