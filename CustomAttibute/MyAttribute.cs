using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttibute
{
    [AttributeUsage(AttributeTargets.All)]
    public class MyAttribute : Attribute
    {

        // Provides name of the member 
        private string _name;

        // Provides description of the member 
        private string _action;

        // Constructor 
        public MyAttribute(string name, string action)
        {
            this._name = name;
            this._action = action;
        }

        // property to get name 
        public string Name
        {
            get { return _name; }
        }

        // property to get description 
        public string Action
        {
            get { return _action; }
        }
    }

}
