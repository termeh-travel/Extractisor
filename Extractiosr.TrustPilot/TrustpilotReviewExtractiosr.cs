using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Extractiosr.TrustPilot
{
    public interface ITrustpilotReviewExtractisor
    {

        /// <summary>
        /// Extract all reviews of a given url.
        /// </summary>
        /// <param name="url">the url of a page in tripadvisor</param>
        /// <returns>The list of extracted reviews</returns>
        IAsyncEnumerable<TrustPilotPageResult> ExtractAsync(string url);

        /// <summary>
        /// Extract all the reviews up to the given number of page
        /// </summary>
        /// <param name="url"></param>
        /// <param name="numberOfPages"></param>
        /// <returns></returns>
        IAsyncEnumerable<TrustPilotPageResult> ExtractAsync(string url, int numberOfPages);
    }

    public class TrustpilotReviewExtractiosr : ITrustpilotReviewExtractisor
    {
        private static readonly HttpClient HttpClient = new HttpClient();


        public async IAsyncEnumerable<TrustPilotPageResult> ExtractAsync(string url)
        {
            url = RemoveQueryString(url);
            var firstPageResult = await GetPageResult(url);

            var total = int.Parse(firstPageResult.AggregateRating.ReviewCount);

            var numberOfPages = (int)Math.Ceiling(total / 20.0);


            for (int i = 1; i <= numberOfPages; i++)
            {
                var pageUrl = url + $"?page={i}";

                var pageResult = await GetPageResult(pageUrl);

                
                    yield return pageResult;
                
            }

        }

        public async IAsyncEnumerable<TrustPilotPageResult> ExtractAsync(string url, int numberOfPages)
        {
            url = RemoveQueryString(url);
            var firstPageResult = await GetPageResult(url);

            for (int i = 1; i <= numberOfPages; i++)
            {
                var pageUrl = url + $"?page={i}";

                var pageResult = await GetPageResult(pageUrl);


                yield return pageResult;

            }
        }

        private string RemoveQueryString(string url)
        {
            return url.Split('?')[0];
        }

        public async Task<TrustPilotPageResult> GetPageResult(string url)
        {
            url = RemoveQueryString(url);
            var response = await HttpClient.GetStringAsync(url);

            var startOfScriptSectionIndex = response.IndexOf("[{\"@context");
            var endOfScriptSectionIndex = response.IndexOf("}}]") + 3;

            string jsonString = response
                .Substring(startOfScriptSectionIndex, endOfScriptSectionIndex - startOfScriptSectionIndex);

            using (JsonDocument document = JsonDocument.Parse(jsonString))
            {
                var reviewListPageElement = document
                    .RootElement
                    .EnumerateArray()
                    .First();

                var json = reviewListPageElement.GetRawText();
                var result = JsonSerializer.Deserialize<TrustPilotPageResult>(json);

                return result;
            }
        }
    }
}
