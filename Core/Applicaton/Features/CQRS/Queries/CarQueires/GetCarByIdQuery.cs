﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaton.Features.CQRS.Queries.CarQueires
{
    public class GetCarByIdQuery
    {
        public int Id { get; set; }
        public GetCarByIdQuery(int id)
        {
            Id = id;
        }


    }
}
