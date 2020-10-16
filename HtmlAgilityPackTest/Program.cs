using System;
using System.Collections.Generic;
using System.Linq;
using HtmlAgilityPack;

namespace HtmlAgilityPackTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            var url = @$"https://www.tripadvisor.com/Attraction_Review-g295423-d17837638-Reviews-Termeh_Travel-Isfahan_Isfahan_Province.html";

            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(url);

            var nodes = htmlDoc.DocumentNode.SelectNodes(".//*[contains(@class,'Dq9MAugU T870kzTX LnVzGwUB')]");
            var reviews = new List<Review>();

            foreach (var node in nodes)

            {
                var review = new Review();
                review.WritersName = node.SelectSingleNode(".//*[contains(@class,'ui_header_link _1r_My98y')]").InnerText;
                review.ReviewTitle = node.SelectSingleNode(".//*[contains(@class,'ocfR3SKN')]").InnerText;
                review.ReviewText = node.SelectSingleNode(".//*[contains(@class,'IRsGHoPm')]").InnerText;
                review.PictureUrl = node.SelectSingleNode(".//*[contains(@class,'_310S4sqz')]").GetAttributeValue("src","Cant Get Image URL");
                review.Rating = Int32.Parse(node.SelectSingleNode(".//*[contains(@class,'nf9vGX55')]").FirstChild.GetAttributeValue("class","").Split('_')[3])/10;
                review.Location= node.SelectSingleNode(".//*[contains(@class,'default _3J15flPT small')]").InnerText;
                var SubmissionDate = node.SelectSingleNode(".//*[contains(@class,'_2fxQ4TOx')]").InnerText.Split(' ');
                review.SubmissionDate = string.Join(" ",SubmissionDate.Reverse().Take(2).Reverse().ToArray());
                review.DateOfExperience = node.SelectSingleNode(".//*[contains(@class,'_34Xs-BQm')]").InnerText;



                reviews.Add(review);

                Console.WriteLine(review.WritersName);
                Console.WriteLine(review.Location);
                Console.WriteLine(review.SubmissionDate);
                Console.WriteLine(review.ReviewTitle);
                Console.WriteLine(review.ReviewText);
                Console.WriteLine(review.PictureUrl);
                Console.WriteLine("Rating: " + review.Rating);
                Console.WriteLine(review.DateOfExperience);
                Console.WriteLine();



                //https://www.tripadvisor.com/Attraction_Review-g295423-d17837638-Reviews-Termeh_Travel-Isfahan_Isfahan_Province.html
                //https://www.tripadvisor.com/Attraction_Review-g295423-d17837638-Reviews-or5-Termeh_Travel-Isfahan_Isfahan_Province.html
                //https://www.tripadvisor.com/Attraction_Review-g295423-d17837638-Reviews-or10-Termeh_Travel-Isfahan_Isfahan_Province.html
                ////*[@id="component_10"]/div[5]/div[3]/div/div[5]/div[3]/div[3]/div[1]/div[1]/q/span[2]
            }

        }
    }
}
