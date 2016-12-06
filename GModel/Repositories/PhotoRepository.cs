using GModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GModel.Repositories
{
   public class PhotoRepository
    {

        // Spara i minnet tills vi flyttar till en databas
        public static IList<Photo> Photos { get; private set; } = new List<Photo>();

        public PhotoRepository()
        {
            if (!Photos.Any())
            {
                SetupTemporaryData();
            }
        }

        public void Add(Photo photo)
        {
            Photos.Add(photo);
        }

        public void Remove(Guid id)
        {
            var photo = Photos.Where(x => x.ID == id).FirstOrDefault();
            Photos.Remove(photo);
        }

        private void SetupTemporaryData()
        {
            Photos = new List<Photo>
            {

            new Photo {ID=new Guid(),PhotoName="img01",description="Foto 01",ImagPath="img01.jpg" },
             new Photo {ID=new Guid(),PhotoName="img02",description="Foto 02",ImagPath="img02.jpg" },
             new Photo {ID=new Guid(),PhotoName="img03",description="Foto 03",ImagPath="img03.jpg" },
             new Photo {ID=new Guid(),PhotoName="img04",description="Foto 04",ImagPath="img04.jpg" },
             new Photo {ID=new Guid(),PhotoName="img05",description="Foto 05",ImagPath="img05.jpg" }
               };

        }
    }
}
