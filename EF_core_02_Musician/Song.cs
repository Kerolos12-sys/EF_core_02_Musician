using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_02_Musician
{
    internal class Song
    {
        [Key]
        public int Song_Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

       public ICollection<Musician_Songs> musician_Songs { get; set; }=new HashSet<Musician_Songs>();

        public int AlbumId { get; set; }
        public Album Album { get; set; }
    }
}
