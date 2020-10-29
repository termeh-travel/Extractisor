using Extractiosr.TrustPilot;
using System;

namespace Extractisor
{
    public class Program
    {
        
        static void Main(string[] args)
        {


            var trustPilotService = new TrustpilotReviewExtractiosr();
            var a = trustPilotService.GetPageResult("https://www.trustpilot.com/review/termehtravel.com").Result;


            foreach (var item in a.Review)
            {
                Console.WriteLine(item.ReviewBody);
                Console.WriteLine();
            }
            Console.WriteLine();
            
            
        }
    }
}