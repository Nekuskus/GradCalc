using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradCalc
{
    public class Num
    {
        public List<Decimal> Wszystko = new List<Decimal>();
        protected Num()
        {
            
        }
    }
    public class Grad : Num
    {
        public Grad(params decimal[] wszystko)
        {
            Wszystko = new List<Decimal>();
            Wszystko.AddRange(wszystko);
        }
        public Grad(Deg d)
        {
            Wszystko = new List<Decimal>();
        }
        public Deg toDeg()
        {
            return new Deg(this);
            //return new Deg(Wszystko[0], Wszystko[1], Wszystko[2], Wszystko.GetRange(3, Wszystko.Count-3).ToArray());
        }
    }
    public class Deg : Num
    {
        public Deg(params decimal[] wszystko)
        {
            Wszystko = new List<Decimal>();
            Wszystko.AddRange(wszystko);
        }
        public Deg(Grad g)
        {
            Wszystko = new List<Decimal>();
        }
        public Grad toGrad()
        {
            return new Grad(this);
            //return new Grad(Wszystko[0], Wszystko[1], Wszystko[2], Wszystko.GetRange(3, Wszystko.Count-3).ToArray());
        }
    }
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
