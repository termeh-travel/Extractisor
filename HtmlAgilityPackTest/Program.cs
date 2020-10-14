using System;
using System.Collections.Generic;
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
                review.WritersName = node.SelectSingleNode(".//a[contains(@class,'ui_header_link _1r_My98y')]").InnerText;
                review.ReviewTitle = node.SelectSingleNode(".//*[contains(@class,'ocfR3SKN')]").InnerText;
                review.ReviewText = node.SelectSingleNode(".//*[contains(@class,'IRsGHoPm')]").InnerText;
                review.PictureUrl = node.SelectSingleNode(".//a[contains(@class,'_3x5_awTA ui_social_avatar inline')]").ChildNodes["img"].GetAttributeValue("src","Cant Get Image URL");
                review.Rating = Int32.Parse(node.SelectSingleNode(".//*[contains(@class,'nf9vGX55')]").FirstChild.GetAttributeValue("class","").Split('_')[3])/10;

                reviews.Add(review);

                Console.WriteLine(review.WritersName);
                Console.WriteLine(review.ReviewTitle);
                Console.WriteLine(review.ReviewText);
                Console.WriteLine(review.PictureUrl);
                Console.WriteLine(review.Rating);
                Console.WriteLine();



                //https://www.tripadvisor.com/Attraction_Review-g295423-d17837638-Reviews-Termeh_Travel-Isfahan_Isfahan_Province.html
                //https://www.tripadvisor.com/Attraction_Review-g295423-d17837638-Reviews-or5-Termeh_Travel-Isfahan_Isfahan_Province.html
                //https://www.tripadvisor.com/Attraction_Review-g295423-d17837638-Reviews-or10-Termeh_Travel-Isfahan_Isfahan_Province.html
            }

        }
    }
}
