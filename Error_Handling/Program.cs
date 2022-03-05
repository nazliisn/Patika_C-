namespace Error_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            /* try
             {
                 Console.WriteLine("Bir sayı giriniz");
                 int sayi= Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine(sayi);
             }
             catch (Exception ex)
             {
                Console.WriteLine(ex.Message);
             }*/


            try
            {
                // int a=int.Parse(null);
                //int a=int.Parse("test");
                int a = int.Parse("-2000000000000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer giremezsiniz");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Format uygun değil");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Çok kçük ya da çok büyük değer girdiniz");
                Console.WriteLine(ex);
            }
        }
    }

}