using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_02_Musician
{
    internal class Album
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }
        public DateTime Date { get; set; }

        public Musician musician { get; set; }

        public int musician_id { get; set; }


        public ICollection<Song> Songs { get; set; }=new HashSet<Song>();

    }
}
