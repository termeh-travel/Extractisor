using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Extractiosr.TrustPilot
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class AggregateRating
    {
        [JsonPropertyName("@type")]
        public string Type { get; set; }

        [JsonPropertyName("bestRating")]
        public string BestRating { get; set; }

        [JsonPropertyName("worstRating")]
        public string WorstRating { get; set; }

        [JsonPropertyName("ratingValue")]
        public string RatingValue { get; set; }

        [JsonPropertyName("reviewCount")]
        public string ReviewCount { get; set; }
    }

    public class Address
    {
        [JsonPropertyName("@type")]
        public string Type { get; set; }

        [JsonPropertyName("streetAddress")]
        public string StreetAddress { get; set; }

        [JsonPropertyName("addressLocality")]
        public string AddressLocality { get; set; }

        [JsonPropertyName("addressCountry")]
        public string AddressCountry { get; set; }
    }

    public class ItemReviewed
    {
        [JsonPropertyName("@type")]
        public string Type { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class Author
    {
        [JsonPropertyName("@type")]
        public string Type { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }
    }

    public class ReviewRating
    {
        [JsonPropertyName("@type")]
        public string Type { get; set; }

        [JsonPropertyName("bestRating")]
        public string BestRating { get; set; }

        [JsonPropertyName("worstRating")]
        public string WorstRating { get; set; }

        [JsonPropertyName("ratingValue")]
        public string RatingValue { get; set; }
    }

    public class Publisher
    {
        [JsonPropertyName("@type")]
        public string Type { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("sameAs")]
        public string SameAs { get; set; }
    }

    public class Review
    {
        [JsonPropertyName("@type")]
        public string Type { get; set; }

        [JsonPropertyName("itemReviewed")]
        public ItemReviewed ItemReviewed { get; set; }

        [JsonPropertyName("author")]
        public Author Author { get; set; }

        [JsonPropertyName("datePublished")]
        public DateTime DatePublished { get; set; }

        [JsonPropertyName("headline")]
        public string Headline { get; set; }

        [JsonPropertyName("reviewBody")]
        public string ReviewBody { get; set; }

        [JsonPropertyName("reviewRating")]
        public ReviewRating ReviewRating { get; set; }

        [JsonPropertyName("publisher")]
        public Publisher Publisher { get; set; }

        [JsonPropertyName("inLanguage")]
        public string InLanguage { get; set; }
    }

    public class TrustPilotPageResult
    {
        [JsonPropertyName("@context")]
        public string Context { get; set; }

        [JsonPropertyName("@type")]
        public string Type { get; set; }

        [JsonPropertyName("@id")]
        public string Id { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("telephone")]
        public string Telephone { get; set; }

        [JsonPropertyName("aggregateRating")]
        public AggregateRating AggregateRating { get; set; }

        [JsonPropertyName("address")]
        public Address Address { get; set; }

        [JsonPropertyName("review")]
        public List<Review> Review { get; set; }
    }


}
