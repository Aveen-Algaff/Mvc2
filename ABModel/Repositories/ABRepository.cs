using ABModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABModel.Repositories
{
   public class ABRepository
    {
        public static IList<Adressboken> Adressboks { get; private set; } = new List<Adressboken>();

        public ABRepository()
        {
            if (!Adressboks.Any())
            {
                SetupTemporaryData();
            }
        }

        public void Add(Adressboken AB)
        {
            Adressboks.Add(AB);
        }

        public void Remov(Guid id)
        {
            var AB = Adressboks.Where(x => x.ID == id).FirstOrDefault();
            Adressboks.Remove(AB);
        }

        private void SetupTemporaryData()
        {
            Adressboks = new List<Adressboken>
            {

             new Adressboken {ID=Guid.NewGuid(), Name ="Bok01",Telefonnummer=012345678,Adress="Gata Ett" ,UpdateAd=DateTime.UtcNow },
             new Adressboken {ID=Guid.NewGuid(), Name="Bok02",Telefonnummer=012345678,Adress="Gata två" ,UpdateAd=DateTime.UtcNow },
             new Adressboken {ID=Guid.NewGuid(), Name="Bok03",Telefonnummer=012345678,Adress="Gata tre" ,UpdateAd=DateTime.UtcNow },
             new Adressboken {ID=Guid.NewGuid(), Name="Bok04",Telefonnummer=012345678,Adress="Gata fyra",UpdateAd=DateTime.UtcNow  },
             new Adressboken {ID=Guid.NewGuid(), Name="Bok05",Telefonnummer=012345678,Adress="Gata fem" ,UpdateAd=DateTime.UtcNow }
               };

        }
    }
}
