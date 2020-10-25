using System;

namespace Extractisor
{
    public class Program
    {
        static void Main(string[] args)
        {
            var url =
                @$"https://www.tripadvisor.com/Attraction_Review-g295423-d17837638-Reviews-or5-Termeh_Travel-Isfahan_Isfahan_Province.html";

            TripAdvisorReviewExtractor extractor = new TripAdvisorReviewExtractor();

            extractor.ExtractAsync(url);
            
            Console.WriteLine("Done!");
            Console.ReadKey();
            //
            // result.First();
            //
            // Console.WriteLine(review.Reviewer);
            // Console.WriteLine(review.Location);
            // Console.WriteLine(review.SubmissionDate);
            // Console.WriteLine(review.Title);
            // Console.WriteLine(review.Content);
            // Console.WriteLine(review.ReviewerProfileUrl);
            // Console.WriteLine("Rating: " + review.Rating);
            // Console.WriteLine(review.DateOfExperience);
            // Console.WriteLine();


            //https://www.tripadvisor.com/Attraction_Review-g295423-d17837638-Reviews-Termeh_Travel-Isfahan_Isfahan_Province.html
            //https://www.tripadvisor.com/Attraction_Review-g295423-d17837638-Reviews-or5-Termeh_Travel-Isfahan_Isfahan_Province.html
            //https://www.tripadvisor.com/Attraction_Review-g295423-d17837638-Reviews-or10-Termeh_Travel-Isfahan_Isfahan_Province.html
            ////*[@id="component_10"]/div[5]/div[3]/div/div[5]/div[3]/div[3]/div[1]/div[1]/q/span[2]
        }
    }
}