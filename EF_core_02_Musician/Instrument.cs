using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_02_Musician
{
    internal class Instrument
    {
        [Key]
        public int Name { get; set; }
        public int Key { get; set; }

        public ICollection<Musician_Instruments> MusicianInstruments = new List<Musician_Instruments>();
    }
}
