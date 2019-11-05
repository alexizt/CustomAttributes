using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttibute
{
    // Class Employee 
    class Employee
    {
        // Fields of Employee 
        int _id;
        string _name;

        public Employee(int i, string n)
        {
            _id = i;
            _name = n;
        }

        // Applying the custom  
        // attribute NewAttribute 
        // to the getId method 
        [NewAttribute("Accessor", "Gives value of Employee Id")]
        public int getId()
        {
            return _id;
        }

        // Applying the custom attribute  
        // NewAttribute to the getName method 
        [NewAttribute("Accessor", "Gives value of Employee Name")]
        public string getName()
        {
            return _name;
        }
    }
}
