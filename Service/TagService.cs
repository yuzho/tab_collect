using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Data.Domain;

namespace Service
{
    public class TagService : ITagService
    {
        private DwGuitarContext db = new DwGuitarContext();

        public IList<Tag> GetAllTags()
        {
            return db.Tags.ToList();
        }
    }
}
