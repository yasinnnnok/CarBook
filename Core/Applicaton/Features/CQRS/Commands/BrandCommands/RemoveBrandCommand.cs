﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applicaton.Features.CQRS.Commands.BrandCommands
{
    public class RemoveBrandCommand
    {
        public int Id { get; set; }
        public RemoveBrandCommand(int ıd)
        {
            Id = ıd;
        }


    }
}
