namespace LatihanOOP;

class Program
{
    static void Main(string[] args)
    {
        Dosen dosen = new Dosen();
        dosen.nip = 12345;
        dosen.name = "Adi";
        dosen.goWork = "Motor";
        dosen.salary = 5000000;

        dosen.Introduction();
        double allowance = 2000000; 
        dosen.TotalSalary(allowance); // Jika mendapatkan tunjangan

        Karyawan karyawan = new Karyawan();
        karyawan.nip = 67890;
        karyawan.name = "Wahyu";
        karyawan.goWork = "Krl";
        karyawan.salary = 6000000;

        karyawan.Introduction();
        karyawan.TotalSalary(); // Jika tidak mendapatkan tunjangan
    }
}