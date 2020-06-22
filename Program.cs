using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using OOP_dan_Collection.ClassAnak;

namespace OOP_dan_Collection
{
    class Program
    {
        public static void Main(string[] args)
        {
            KaryawanTetap KaryawanTetap = new KaryawanTetap();
            KaryawanTetap.nik = "123-234-345";
            KaryawanTetap.nama = " Michael Suyama";
            KaryawanTetap.GajiBulanan = 4000000;
            KaryawanHarian KaryawanHarian = new KaryawanHarian();
            KaryawanHarian.nik = "123-321-346";
            KaryawanHarian.nama = "Laura Callahan";
            KaryawanHarian.JumlahJamKerja = 8;
            KaryawanHarian.UpahPerjam = 13000;
            Sales Sales = new Sales();
            Sales.nik = "123-333-347";
            Sales.nama = "Andrew Fuller";
            Sales.JumlahPenjualan = 30;
            Sales.Komisi = 45000;
            List<Karyawan> listkaryawan = new List<Karyawan>();
            listkaryawan.Add(KaryawanTetap);
            listkaryawan.Add(KaryawanHarian);
            listkaryawan.Add(Sales);
            int noUrut = 1;
            foreach (Karyawan Karyawan in listkaryawan)
            {
                Console.WriteLine("{0}. Nik : {1}, Nama : {2}, Gaji : {3:N0}", noUrut, Karyawan.nik, Karyawan.nama, Karyawan.gaji());
                noUrut++;
            }
            Console.ReadKey();
        }
    }
}
