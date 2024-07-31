﻿using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaton.Features.Mediator.Results.PricingResult
{
    public class GetPricingByIdQueryResult
    {
        public int PricingId { get; set; }
        public string Name { get; set; }

    }
}
