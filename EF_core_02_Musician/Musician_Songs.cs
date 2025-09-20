using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_core_02_Musician
{
    internal class Musician_Songs
    {

        public Musician Musician { get; set; }

        public int Musician_Id;


        public Song Song { get; set; }
        public int Song_Id;


    }
}
