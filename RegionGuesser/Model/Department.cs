using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegionGuesser.Model
{
    class Department
    {
        public string Code { get; }
        public string Name { get; }
        public string Capital { get; }
        public Region Region { get; }
        public bool DomTom { get; }

        public Department(string code, string name, string capital, Region region, bool domTom=false)
        {
            this.Code = code;
            this.Name = name;
            this.Capital = capital;
            this.Region = region;
            this.DomTom = domTom;
            this.Region.Departments.Add(this);
        }

        public bool PartOfRegion(Region region)
        {
            if (region.Equals(this.Region)) return true;
            return false;
        }

        public override string ToString()
        {
            return $"{Code} {Name} (Chef lieu : {Capital})";
        }
    }
}
