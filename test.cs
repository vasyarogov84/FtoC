using System;
public class test
{
public static void Main()
{
       double Celsium;
        double F;
      Console.Write("Enter Celsium ");
       Celsium = Convert.ToDouble(Console.ReadLine());


        F = ((1.8)*Celsium) + 32;


      Console.WriteLine("Your temprutare in F: " +  F);


}
}
