using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Extractisor.Models;
using HtmlAgilityPack;

namespace Extractisor
{
    public class TripAdvisorReviewExtractor
    {
        private static readonly HttpClient HttpClient;

        static TripAdvisorReviewExtractor()
        {
            HttpClient = new HttpClient();
        }

        /// <summary>
        /// Extract all the reviews of a given page
        /// </summary>
        /// <param name="url">the page url</param>
        public async Task ExtractAsync(string url)
        {
            // The address of the page you crawled
            var baseUrl = new Uri(url);

            var response = await HttpClient.GetStringAsync(baseUrl);

            HtmlDocument htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(response);

            var nodes = htmlDocument
                .DocumentNode
                .SelectNodes(".//div[@class='Dq9MAugU T870kzTX LnVzGwUB']");

            foreach (var node in nodes)
            {
                var review = new Review();

                review.ReviewerFullName = node
                    .SelectSingleNode(".//a[@class='ui_header_link _1r_My98y']")
                    .InnerText;

                var reviewTitleNode = node
                    .SelectSingleNode(".//a[@class='ocfR3SKN']");

                var reviewRelativeLink = reviewTitleNode.GetAttributeValue("href", null);
                var reviewLink = new Uri(baseUrl, reviewRelativeLink);

                review.Title = reviewTitleNode.InnerText;
                review.Link = reviewLink.AbsoluteUri;

                var contents = node
                    .SelectNodes(".//q[@class='IRsGHoPm']/span");

                if (contents.Count == 1)
                {
                    review.Content = contents.First().InnerText;
                }
                else
                {
                    review.Content = contents
                        .Take(2)
                        .Select(n => n.InnerText)
                        .JoinAsString("");
                }

                // review.ReviewerProfileUrl = node
                //     .SelectSingleNode(".//*[contains(@class,'_310S4sqz')]")
                //     .GetAttributeValue("src", "Cant Get Image URL");

                review.Rating = node
                    .SelectSingleNode(".//span[contains(@class,'ui_bubble_rating')]")
                    .GetClasses()
                    .ElementAt(1)
                    .GetLast(2)
                    .ToInt() / 10;

                var locations = node
                    .SelectSingleNode(".//span[@class = 'default _3J15flPT small' ]")
                    .InnerText
                    .Split(", ");

                if (locations.Length == 2)
                {
                    review.ReviewerCity = locations[0];
                    review.ReviewerCountry = locations[1];
                }
                else
                {
                    review.ReviewerCountry = locations[0];
                }

                review.SubmissionDate = node
                    .SelectSingleNode(".//div[@class='_2fxQ4TOx']")
                    .InnerText
                    .Split(' ')
                    .TakeLast(2)
                    .JoinAsString()
                    .ToDateTime();

                
                review.DateOfExperience = node
                    .SelectSingleNode(".//span[@class='_34Xs-BQm']")
                    .LastChild
                    .InnerText
                    .ToDateTime();
            }
        }
    }
}