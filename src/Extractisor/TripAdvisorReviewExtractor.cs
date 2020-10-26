using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
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
        public async Task<ICollection<Review>> ExtractAsync(string url)
        {
            // The address of the page you crawled
            var baseUrl = new Uri(new Uri(url)
                .GetLeftPart(UriPartial.Path));

            var response = await HttpClient.GetStringAsync(url);

            HtmlDocument htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(response);

            var nodes = htmlDocument
                .DocumentNode
                .SelectSingleNode("//*[@id='BODY_BLOCK_JQUERY_REFLOW']/script[4]/text()").InnerText;

            string jsonString = nodes.Substring(37, nodes.Length - 178);

            using (JsonDocument document = JsonDocument.Parse(jsonString))
            {
                var reviewListPageElement = document
                    .RootElement
                    .GetProperty("urqlCache")
                    .EnumerateObject()
                    .Select(jsonProperty => jsonProperty.Value.GetProperty("data"))
                    .Where(element => element.EnumerateObject().Any(p => p.NameEquals("locations")))
                    .Select(element => element.GetProperty("locations"))
                    .Select(element => element.EnumerateArray().First())
                    .Where(element => element.ValueKind == JsonValueKind.Object)
                    .Single(element => element.EnumerateObject().Any(p => p.NameEquals("reviewListPage")))
                    .GetProperty("reviewListPage");

                var json = reviewListPageElement.GetRawText();
                var result = JsonSerializer.Deserialize<ReviewListPage>(json);

                return result.Reviews;
            }
        }
    }
}