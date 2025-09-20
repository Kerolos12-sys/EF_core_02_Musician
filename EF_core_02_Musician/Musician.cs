using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_02_Musician
{
    internal class Musician
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Ph_Number { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public ICollection<Album> albums { get; set; }=new HashSet<Album>();



        public ICollection<Musician_Instruments> MusicianInstruments = new HashSet<Musician_Instruments>();

        public ICollection<Musician_Songs> musician_Songs { get; set; }=new HashSet<Musician_Songs>();
    }
}
