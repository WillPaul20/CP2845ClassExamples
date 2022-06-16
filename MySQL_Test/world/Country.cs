using System;
using System.Collections.Generic;

namespace MySQL_Test.world
{
    public partial class Country
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Continent { get; set; } = null!;
        public string Region { get; set; } = null!;
        public float SurfaceArea { get; set; }
        public short? IndepYear { get; set; }
        public int Population { get; set; }
        public float? LifeExpectancy { get; set; }
        public float? Gnp { get; set; }
        public float? Gnpold { get; set; }
        public string LocalName { get; set; } = null!;
        public string GovernmentForm { get; set; } = null!;
        public string? HeadOfState { get; set; }
        public int? Capital { get; set; }
        public string Code2 { get; set; } = null!;
    }
}
