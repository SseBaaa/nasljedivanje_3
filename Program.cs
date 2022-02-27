using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nasljedivanje_3
{
    internal class Program
    {
        static void Main(string[] args)
        {



        }
    }

    public class Biljka
    {

    }

    public class Stablo : Biljka
    {
        public bool otpadajuListovi;

        public Stablo(bool otpadajuListovi)
        {
            otpadajuListovi = OtpadajuListovi;
        }

        public bool OtpadajuListovi { get => otpadajuListovi; set => otpadajuListovi = value; }
    }

    public class Cvijet : Biljka
    {

    }

    public class Bjelogoricno : Stablo
    {
      public Bjelogoricno(bool otpadajuListovi)
        {
            otpadajuListovi = OtpadajuListovi;
        }

    }

    public class Crnogoricno : Stablo
    {
        

    }



    public class Hrast : Bjelogoricno
    {

    }

    public class Bor : Crnogoricno
    {

    }

}
