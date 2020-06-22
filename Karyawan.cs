using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_dan_Collection
{
    public abstract class Karyawan
    {
        public string nik { get; set; }
        public string nama { get; set; }
        public abstract double gaji();
    }
}
