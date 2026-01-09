int nilai;
string nama;

Console.WriteLine("Aplikasi Nilai Siswa");

Console.Write("Nama Siswa");
nama  = Console.ReadLine();

Console.Write("Nilai: ");
nilai = int.Parse(Console.ReadLine()); 

if (nilai >= 75)
{
    Console.WriteLine("Selamat, lulus!");
}
else
{
    Console.WriteLine("Maaf, belum lulus!");
}