namespace code_casier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("____________________________________________");
            Console.WriteLine("\n       Selamat Datang diProgram Kasir");
            Console.WriteLine("____________________________________________");
            Console.Write("\nMasukkan Nama                :  ");
            string A = Console.ReadLine();
            Console.Write("Masukkan Total Belanja       :  ");
            string a = Console.ReadLine();
            Console.Write("Apakah Anda Member(yes, no)  :  ");
            string AA = Console.ReadLine().ToLower();
            Console.Write("Masukkan Total Barang        :  ");
            string aa = Console.ReadLine();
            Console.WriteLine("____________________________________________");

            double c = 0;
            if (double.TryParse(a, out double b) && int.TryParse(aa, out int bb))
            {
                if (b >= 500000 && bb >= 5 && AA == "yes")
                {
                    c = b * 0.20;
                }
                else if (b >= 1000000 && bb >= 8 && AA == "no")
                {
                    c = b * 0.10;
                }
                else
                {
                    c = 0;
                }
            }
            else
            {
                Console.WriteLine("\nInput Total Belanja dan Barang Tidak Boleh Menggunakan Huruf!");
                return;
            }
            Console.WriteLine("____________________________________________");
            Console.WriteLine("\n     Rincian Pembelian dan Pembayaraan");
            Console.WriteLine("____________________________________________");
            Console.WriteLine($"\nNama                 :  {A}");
            Console.WriteLine($"Total Belanja        :  {b:N0}");
            Console.WriteLine($"Total Barang         :  {bb}");
            Console.WriteLine($"Diskon yang diDapat  :  {c:N0}");
            Console.WriteLine($"Total Pembayaraan    :  {b - c:N0}");
            Console.WriteLine("____________________________________________");
            Console.ReadKey();
        }
    }
}
