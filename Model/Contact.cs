using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Contact
    {
        public String FirstName
        {
            get;
            set;
        }
        public String LastName
        {
            get;
            set;
        }
        public String Email
        {
            get;
            set;
        }

        public Contact(String fn, String ln, String e)
        {
            FirstName = fn;
            LastName = ln;
            Email = e;
        }
    }
}
