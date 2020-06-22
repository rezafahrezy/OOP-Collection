using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_dan_Collection.ClassAnak
{
    class Sales : Karyawan
    {
        public double JumlahPenjualan { get; set; }
        public double Komisi { get; set; }
        public override double gaji()
        {
            double jumlah = JumlahPenjualan * Komisi;
            return jumlah;
        }
    }
}
