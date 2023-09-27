using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phanso
{
    internal class Phanso
    {
        private int iTu;
        private int iMau;
        public Phanso (int iTu, int iMau)
        {
            this.iTu = iTu; 
            this.iMau = iMau;
        }
        public Phanso Cong( Phanso a)
        {
            int Tu =this.iTu*a.iMau+this.iMau*a.iTu;
            int Mau = this.iMau * a.iMau;
            return new Phanso(Tu, Mau);
        }
        public Phanso Tru(Phanso a)
        {
            int Tu = this.iTu * a.iMau - this.iMau * a.iTu;
            int Mau = this.iMau * a.iMau;
            return new Phanso(Tu, Mau);
        }
        public Phanso Nhan(Phanso a)
        {
            int Tu = this.iTu * a.iTu;
            int Mau = this.iMau * a.iMau;
            return new Phanso(Tu, Mau);
        }
        public Phanso Chia(Phanso a)
        {
            int Tu = this.iTu * a.iMau;
            int Mau = this.iMau * a.iTu;
            return new Phanso(Tu, Mau);
        }

    }
}
