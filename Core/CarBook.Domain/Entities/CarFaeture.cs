﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.Entities
{
    public class CarFaeture
    {
        public int CarFeatureId { get; set; }
        public int CarId { get; set; }

        public Car Car { get; set; }

        public int FeatureId { get; set; }
        public Feature Feature { get; set; }

        public bool Avialable { get; set; }




    }
}
