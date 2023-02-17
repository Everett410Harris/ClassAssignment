using Software2KnowledgeCheck1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software2KnowledgeCheck1
{
    internal class City : ConstructionServiceBase
    {
        public int ZipCode { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public int Population { get; set; }

        public List<Building> Buildings { get; } = new List<Building>();

        public void CreateApartment(Apartment apartment)
        {
            // Get materials
            var ConstructionServiceBase = new ConstructionServiceBase();
            var BuildingWasMade = ConstructionServiceBase.ConstructBuilding(apartment);

            if (BuildingWasMade)
            {
                Buildings.Add(apartment);
            }
        }

       
     }
}



