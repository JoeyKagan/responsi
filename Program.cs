using System;
using System.Collections.Generic;
using ProjectPenjualan;

internal class Program
{
	private static List<Penjualan> daftarPenjualan = new List<Penjualan>();

	private static void Main(string[] args)
	{
		Console.Title = "Responsi UAS Matakuliah Pemrograman";
		while (true)
		{
			TampilMenu();
			Console.Write("\nNomor Menu [1...3]: ");
			switch (Convert.ToInt32(Console.ReadLine()))
			{
				case 1:
					Console.Clear();
					TambahPenjualan();
					break;
				case 2:
					Console.Clear();
					TampilPenjualan();
					break;
				case 3:
					Console.Clear();
					Console.WriteLine("===== TERIMA KASIH =====\n");
					Console.WriteLine("Nama\t: Haniel Joey Kagan");
					Console.WriteLine("NIM\t: 21.11.4273");
					Console.WriteLine("Kelas\t: 21-IF-07");
					Console.ReadKey();
					return;
			}
		}
	}

	private static void TampilMenu()
	{
		Console.Clear();
		Console.WriteLine("Pilih Menu Aplikasi\n");
		Console.Write("1. Tambah Penjualan\n");
		Console.Write("2. Tampilkan Penjualan\n");
		Console.Write("3. Keluar\n");
	}

	private static void TambahPenjualan()
	{
		Console.WriteLine("Tambah Data Penjualan\n");
		Penjualan penjualan = new Penjualan();

		Console.Write("Nota: ");
		penjualan.Nota = Console.ReadLine();

		Console.Write("Tanggal: ");
		penjualan.Tanggal = Console.ReadLine();

		Console.Write("Customer: ");
		penjualan.Customer = Console.ReadLine();

		Console.Write("Jenis [T/K]: ");
		penjualan.Jenis = Console.ReadLine();

		Console.Write("Total Nota: ");
		penjualan.TotalNota = Convert.ToInt32(Console.ReadLine());

		daftarPenjualan.Add(penjualan);
		Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
		Console.ReadKey();
	}

	private static void TampilPenjualan()
	{
		Console.Clear();
		Console.WriteLine("Data Penjualan\n");
		int temp = 1;
		foreach (Penjualan x in daftarPenjualan)
		{
			string text = ((x.Jenis == "T") ? "Tunai" : "Kredit");
			Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", temp, x.Nota, x.Tanggal, x.Customer, text, x.TotalNota); temp++;
		}
		Console.WriteLine("\nTekan enter untuk kembali ke menu");
		Console.ReadKey();
	}
}