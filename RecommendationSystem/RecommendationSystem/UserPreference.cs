using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecommendationSystem
{
    class UserPreference
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }
    }

    class CollInit
    {
        Dictionary<int, UserPreference> userPreferences = new Dictionary<int, UserPreference>()
        {
            {1, new UserPreference {FirstName="Johan", LastName="Boers", ID=211 } },
            //{, new UserPreference { , ,  } }
        };
    }
}
