using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prak8.ClassInduk;
using prak8.ClassAnak;

namespace prak8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8 - Inheritance, Polymorphsim, Abstraction & Collection";

            // Membuat objek untuk semua karyawan

            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.NIK = "333-666-999";
            karyawanTetap.Nama = "Jaka wardana";
            karyawanTetap.GajiBulanan = 4000000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.NIK = "222-444-888";
            karyawanHarian.Nama = "Joko wardono";
            karyawanHarian.UpahPerJam = 13000;
            karyawanHarian.JumlahJamKerja = 8;

            Sales sales = new Sales();
            sales.NIK = "111-555-000";
            sales.Nama = "Jeki Wardeni";
            sales.JumlahPenjualan = 30;
            sales.Komisi = 45000;

            // Objek class collection
            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);

            int noUrut = 1;

            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}. NIK: {1}, Nama: {2}, Gaji: {3}", noUrut, karyawan.NIK, karyawan.Nama, karyawan.Gaji());

                noUrut++;
            }

            Console.ReadLine();
        }
    }
}