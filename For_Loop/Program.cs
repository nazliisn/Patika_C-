namespace For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bir sayı girin");
            int sayac = int.Parse(Console.ReadLine());

            int teksayi = 0;
            int ciftsayi = 0;

            for (int i = 0; i < sayac; i++)
            {
                if (i % 2 == 1)
                    teksayi += i;
                else
                    ciftsayi += i;



            }
            Console.WriteLine(teksayi);
            Console.WriteLine(ciftsayi);
            for (int i = 0; i < sayac; i++)
            {
                if (i == 4)
                    break;

                Console.WriteLine(i);

            }
            for (int i = 0; i < sayac; i++)
            {
                if (i == 4)
                    continue;

                Console.WriteLine(i);

            }
        }
    }
}