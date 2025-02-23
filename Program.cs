﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPenjualan
{
    class Program
    {
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        TampilPenjualan();
                        break;

                    case 3: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine();
            Console.WriteLine("1. Tambah Penjualan");
            Console.WriteLine("2. Tampilkan Penjualan");
            Console.WriteLine("3. Keluar");
        }

        static void TambahPenjualan()
        {
            Console.Clear();

            Console.WriteLine("Tambah Data Penjualan");
            Console.WriteLine();

            Console.Write("Nota: ");
            string Nota = Console.ReadLine();
            Console.Write("Tanggal: ");
            string Tanggal = Console.ReadLine();
            Console.Write("Customer: ");
            string Customer = Console.ReadLine();
            Console.Write("Jenis[T/K]: ");
            char iJenis = Convert.ToChar(Console.ReadLine());
            string Jenis;
            if (iJenis == 'T' || iJenis == 't')
                Jenis = "Tunai";
            else
                Jenis = "Kredit";
            Console.Write("Total Nota: ");
            int Total = Convert.ToInt32(Console.ReadLine());

            Penjualan mhs = new Penjualan();
            mhs.Nota = Nota;
            mhs.Tanggal = Tanggal;
            mhs.Customer = Customer;
            mhs.Jenis = Jenis;
            mhs.Total = Total;

            daftarPenjualan.Add(mhs);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusPenjualan()
        {
            Console.Clear();

            Console.WriteLine("Hapus Data Penjualan");
            Console.WriteLine();

            Console.Write("Nota: ");
            string Nota = Console.ReadLine();

            int i = 0;
            int size = daftarPenjualan.Count();

            foreach (Penjualan p in daftarPenjualan.ToList())
            {
                if (p.Nota == Nota)
                {
                    daftarPenjualan.Remove(daftarPenjualan[i]);
                    Console.WriteLine("Data Penjualan Berhasil dihapus");

                }
                else
                {
                    if (i == size - 1)
                    {
                        Console.WriteLine("Nota Tidak Ditemukan");
                    }
                }
                i++;
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();



            Console.WriteLine("Data Penjualan");
            Console.WriteLine();

            int i = 0;

            foreach (Penjualan p in daftarPenjualan)
            {
                i++;
                Console.WriteLine($"{i}. {p.Nota}, {p.Tanggal}, {p.Customer}, {p.Jenis}, {p.Total}");
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
