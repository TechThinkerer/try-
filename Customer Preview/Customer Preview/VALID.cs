using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Preview
{
    internal class VALID
    {
        public void checkname(string name)
        {
            if (name.Length > 10)
            {
                throw new Exception("name  should be written within 10 characters");
            }
            else if (name == " ")
            {
                throw new Exception("name is required");
            }
            
        }
    }
}
