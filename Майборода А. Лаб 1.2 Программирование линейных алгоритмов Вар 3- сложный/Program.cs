// Анатолий Майборода 22-ИСП-2/1 Вар 3 Уровень: высокий 
try
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Введите емкость конденсатора: ");
    double capacityCond = double.Parse(Console.ReadLine());
    Console.Write("Введите индуктивность: ");
    double inductivity = double.Parse(Console.ReadLine());
    double period = 2 * Math.PI * Math.Sqrt(inductivity * capacityCond);
    double chastota = 1 / period;
    Console.ForegroundColor = ConsoleColor.Cyan;
    //Console.WriteLine("{T}= 2*Pi*Sqrt{L}*{C} - период",period,capacityCond,inductivity);
    //Console.WriteLine("{V}= 1/{T} - частота",chastota,period);
    Console.WriteLine($"{period:F2}= 2*Pi*Sqrt{capacityCond}*{inductivity} - период");
    Console.WriteLine($"{chastota}= 1/{period} - частота");

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}