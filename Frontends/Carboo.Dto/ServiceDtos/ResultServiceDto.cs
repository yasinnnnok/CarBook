﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carbook.Dto.ServiceDtos
{
    public class ResultServiceDto
    {
        public int ServiceId { get; set; }
        public string Title { get; set; }
        public string Descripton { get; set; }
        public string IconUrl { get; set; }
    }
}
