using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Extractisor
{
    public interface ITripAdvisorReviewExtractor
    {
        /// <summary>
        /// Extract all reviews of a given url.
        /// </summary>
        /// <param name="url">the url of a page in tripadvisor</param>
        /// <returns>The list of extracted reviews</returns>
        IAsyncEnumerable<Review> ExtractAsync(string url);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="numberOfReviews"></param>
        /// <returns></returns>
        IAsyncEnumerable<Review> ExtractAsync(string url, int numberOfReviews);
    } 
    
    public class TripAdvisorReviewExtractor
    {
        private static readonly HttpClient HttpClient;

        static TripAdvisorReviewExtractor()
        {
            HttpClient = new HttpClient();
        }

        public IAsyncEnumerable<Review> ExtractAsync(string url, int numberOfReviews)
        {
            throw new System.NotImplementedException();
        }
        
        public async IAsyncEnumerable<Review> ExtractAsync(string url)
        {
            url = GetFirstPageUrl(url);
        
            var firstPageResult = await GetPageResult(url);
        
            var total = firstPageResult.TotalCount - 5; // 18

            var numberOfPages = (int)Math.Ceiling(total / 5.0);

            var reviewsIndex = url.IndexOf("Reviews", StringComparison.OrdinalIgnoreCase) + 7;
            
            for (int i = 5; i <= numberOfPages; i += 5)
            {
                var pageUrl = url.Insert(reviewsIndex, $"-or{i}-");
                
                var pageResult = await GetPageResult(pageUrl);

                foreach (var resultReview in pageResult.Reviews)
                {
                    yield return resultReview;
                }
            }
        }
        
        private string GetFirstPageUrl(string url)
        {
            return Regex.Replace(url, @"-or\d[0,5]{0,}-", "");
        }
        private async Task<TripAdvisorPageResult> GetPageResult(string url)
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
                var result = JsonSerializer.Deserialize<TripAdvisorPageResult>(json);

                return result;
            }
        }
    }
}