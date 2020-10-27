using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;


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
            var response = await HttpClient.GetStringAsync(url);

            var startOfScriptSectionIndex = response.IndexOf("window.__WEB_CONTEXT__={") + 37;
            var endOfScriptSectionIndex = response.IndexOf("__WEB_CONTEXT__.pageManifest.features);},[]]},[]]);") - 90;

            string jsonString = response
                .Substring(startOfScriptSectionIndex, endOfScriptSectionIndex - startOfScriptSectionIndex);

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