using System;
using System.Collections.Generic;
using System.Text;

namespace Conference.Domain.CustomEntities
{
    public partial class Speakers
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}
