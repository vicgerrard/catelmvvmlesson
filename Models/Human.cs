using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catel.Data;

namespace CatelMvvmLesson.Models
{
    public class Human : ModelBase
    {
        public string Name { get; set; }
        public string LastName { get; set; }


        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(LastName)}: {LastName}";
        }
    }
    
}
