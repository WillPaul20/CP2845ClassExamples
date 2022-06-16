using System;
using System.Collections.Generic;

namespace MySQL_Test.world
{
    public partial class Countrylanguage
    {
        public string CountryCode { get; set; } = null!;
        public string Language { get; set; } = null!;
        public string IsOfficial { get; set; } = null!;
        public float Percentage { get; set; }
    }
}
