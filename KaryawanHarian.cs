using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_dan_Collection.ClassAnak
{
    class KaryawanHarian : Karyawan
    {
        public double JumlahJamKerja { get; set; }
        public double UpahPerjam { get; set; }
        public override double gaji()
        {
            double jumlah = UpahPerjam * JumlahJamKerja;
            return jumlah;
        }
    }
}
