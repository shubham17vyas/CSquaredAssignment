using System;


namespace CSquaredAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You have a bag which contains three items as default. The list of items the bag pack contains are given below. ");

            //making an object of Bagpack class. 
            var bagPack = new Bagpack();
            
            bagPack.Start();
        }
    }


    
}
