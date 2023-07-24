
class Program
{
    static void Main(string[] args)
    {
        DateTime data1 = new DateTime(2007, 01, 03);
        DateTime data2 = new DateTime(2023, 07, 24, 16, 12, 0);

        Console.WriteLine(data1);
        Console.WriteLine(data2);

        Console.WriteLine(DateTime.Now);
        Console.WriteLine(DateTime.UtcNow);
        Console.WriteLine(DateTime.Today);
        Console.WriteLine(data1.Year);
        Console.WriteLine(data1.Month);
        Console.WriteLine(data1.DayOfYear);
        Console.WriteLine(data1.DayOfWeek);

        DateTime data3 = data1.AddDays(10);
        DateTime data4 = data1.AddYears(5);
        Console.WriteLine(data3);
        Console.WriteLine(data4);

        DateTime data5 = DateTime.Now;

        //subtração de duas datas 
        TimeSpan a = data5.Subtract(data1);
        Console.WriteLine(a.Days);

        TimeSpan b = data5 - data1;
        Console.WriteLine(b.Days);

        DateTime novadata = DateTime.Now.Subtract(a);
        Console.WriteLine(novadata);


        Console.Write("Informe a data de nascimento: ");
        DateTime nasc = Convert.ToDateTime(Console.ReadLine());
        Console.WriteLine(nasc.DayOfWeek);//dia em que vc nasceu 

        //comparar duas datas 
        DateTime d1 = new DateTime(2023, 07, 24);
        DateTime d2 = new DateTime(2023, 07, 24);

        Console.WriteLine(DateTime.Compare(d1, d2));
        //0 - data iguais 
        //-1 - a primeira data é anterior a segunda 
        //1 - a primeira data é posterior a segunda 

        DateTime d3 = DateTime.Parse(Console.ReadLine());//pode passar qualquer valor de qualquer forma
                                                         
        DateOnly dto = DateOnly.Parse("03/01/2007");//irá passar somente a data, sem a hr 
        Console.ReadKey();
    }
}
    
