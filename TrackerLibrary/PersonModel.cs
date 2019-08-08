using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Represents one person.
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// First name of the person.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name of the person.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The primary email adress of the person.
        /// </summary>
        public string EmailAdress { get; set; }

        /// <summary>
        /// The primary cell phone of the person.
        /// </summary>
        public string CellPhoneNumber { get; set; }



    }
}
