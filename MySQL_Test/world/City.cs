﻿using System;
using System.Collections.Generic;

namespace MySQL_Test.world
{
    public partial class City
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string CountryCode { get; set; } = null!;
        public string District { get; set; } = null!;
        public int Population { get; set; }
    }
}
