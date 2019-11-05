using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttibute
{
    // Class Employer 
    class Employer
    {

        // Fields of Employer 
        int _id;
        string _name;

        // Constructor 
        public Employer(int i, string n)
        {
            _id = i;
            _name = n;
        }

        // Applying the custom attribute  
        // NewAttribute to the getId method 
        [NewAttribute("Accessor", "Gives value of Employer Id")]
        public int getId()
        {
            return _id;
        }

        // Applying the custom attribute  
        // NewAttribute to the getName method 
        [NewAttribute("Accessor", "Gives value of Employer Name")]
        public string getName()
        {
            return _name;
        }
    }
}
