﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassTracker.Core.Objects
{
    public class Authors
    {
        public Authors() {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime DateAdded { get; set; }

    }
}
