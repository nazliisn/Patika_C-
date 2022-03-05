namespace Operators
{
    class Program
    {
        static  void Main(string[] args)
        {
          //Atama ve İşlemli Atama
            int a=3;
            int b=5;

            int c=b+a;

            Console.WriteLine(c);
            c+=2;
            Console.WriteLine(c);
            c /=1;
            Console.WriteLine(c);
            c*=2;
            Console.WriteLine(c);

            //Mantıksal Operatörler

            bool isSeccess=true;
            bool isCompleted=false;

            if(isSeccess&&isCompleted)
                Console.WriteLine("Perfect");
            
             if(isSeccess||isCompleted)
                Console.WriteLine("Fine");
            
             if(isSeccess&& !isCompleted)
                Console.WriteLine("Good");


             int x=3;
             int y=4;
             bool sonuc =x<y;

             Console.WriteLine(sonuc);
             sonuc=x>y;
             Console.WriteLine(sonuc);
             sonuc=x>=y;
             Console.WriteLine(sonuc);
            sonuc= x ==y;
             Console.WriteLine(sonuc);



              int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1 / sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1 + sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = ++sayi1;
            Console.WriteLine(sonuc1);
            sonuc1 = 20 % 3;
            Console.WriteLine(sonuc1);
            





                
                








        }
    }
}