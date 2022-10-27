namespace _2_Encapsulation_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personel p = new Personel();
            p.Name = "Kübra";
            p.SurName = " Karakus";
            p.CompanyName = "bt akademi";

            Console.WriteLine($"{p.Name} - {p.SurName} - {p.Email}");

            Personel p1 = new Personel();
            Console.WriteLine("Personel adı giriniz:");
            p1.Name = Console.ReadLine();

            Console.WriteLine("Personel SoyAdı Giriniz");
            p1.Name = Console.ReadLine();
            p1.CompanyName = "btakademi";

            Console.WriteLine($"Personelin Email Adresi = {p1.Email} ");


            Console.ReadKey();
        }
    }
}