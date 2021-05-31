using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegionGuesser.Model
{
    class Region
    {
        public static List<Region> AllRegions { get; } = new List<Region>();

        public int Id { get; }
        public string Name { get; }
        public List<Department> Departments { get; } = new List<Department>();

        public Region(int id, string name)
        {
            this.Id = id;
            this.Name = name;
            AllRegions.Add(this);
        }

        public bool PartOfRegion(Department department)
        {
            return (Departments.Find(o => o.Region.Equals(this)) != null);
        }

        public List<string> AllDepartmentCode()
        {
            List<string> codes = new List<string>();
            foreach(Department department in Departments)
            {
                codes.Add(department.Code);
            }
            return codes;
        }

        public static Region Find(string name)
        {
            return AllRegions.Find(o => o.Name.Equals(name));
        }
        
        public static Region Find(int id)
        {
            return AllRegions.Find(o => o.Id.Equals(id));
        }
    }
}
