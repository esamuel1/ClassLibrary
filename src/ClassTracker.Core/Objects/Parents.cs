using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassTracker.Core.Objects
{
    public class Parents
    {
        public Parents() {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public String   FirstName   { get; set; }
        public String LastName { get; set; }
        public String EmailAddress { get; set; }
        public int ContactNumber { get; set; }
        public String SecPas { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
