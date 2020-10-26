using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Extractisor
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class AdditionalNames
    {
        [JsonPropertyName("normal")]
        public string Normal { get; set; }

        [JsonPropertyName("long")]
        public string Long { get; set; }

        [JsonPropertyName("longOnlyParent")]
        public string LongOnlyParent { get; set; }

        [JsonPropertyName("longParentAbbreviated")]
        public string LongParentAbbreviated { get; set; }

        [JsonPropertyName("longOnlyParentAbbreviated")]
        public string LongOnlyParentAbbreviated { get; set; }

        [JsonPropertyName("longParentStateAbbreviated")]
        public string LongParentStateAbbreviated { get; set; }

        [JsonPropertyName("longOnlyParentStateAbbreviated")]
        public string LongOnlyParentStateAbbreviated { get; set; }

        [JsonPropertyName("geo")]
        public string Geo { get; set; }

        [JsonPropertyName("abbreviated")]
        public string Abbreviated { get; set; }

        [JsonPropertyName("abbreviatedRaw")]
        public string AbbreviatedRaw { get; set; }

        [JsonPropertyName("abbreviatedStateTerritory")]
        public string AbbreviatedStateTerritory { get; set; }

        [JsonPropertyName("abbreviatedStateTerritoryRaw")]
        public string AbbreviatedStateTerritoryRaw { get; set; }
    }

    public class AdditionalNames2
    {
        [JsonPropertyName("normal")]
        public string Normal { get; set; }

        [JsonPropertyName("long")]
        public string Long { get; set; }

        [JsonPropertyName("longOnlyParent")]
        public string LongOnlyParent { get; set; }

        [JsonPropertyName("longParentAbbreviated")]
        public string LongParentAbbreviated { get; set; }

        [JsonPropertyName("longOnlyParentAbbreviated")]
        public string LongOnlyParentAbbreviated { get; set; }

        [JsonPropertyName("longParentStateAbbreviated")]
        public string LongParentStateAbbreviated { get; set; }

        [JsonPropertyName("longOnlyParentStateAbbreviated")]
        public string LongOnlyParentStateAbbreviated { get; set; }

        [JsonPropertyName("geo")]
        public string Geo { get; set; }

        [JsonPropertyName("abbreviated")]
        public string Abbreviated { get; set; }

        [JsonPropertyName("abbreviatedRaw")]
        public string AbbreviatedRaw { get; set; }

        [JsonPropertyName("abbreviatedStateTerritory")]
        public string AbbreviatedStateTerritory { get; set; }

        [JsonPropertyName("abbreviatedStateTerritoryRaw")]
        public string AbbreviatedStateTerritoryRaw { get; set; }
    }

    public class Parent
    {
        [JsonPropertyName("locationId")]
        public int LocationId { get; set; }

        [JsonPropertyName("additionalNames")]
        public AdditionalNames2 AdditionalNames { get; set; }
    }

    public class Location
    {
        [JsonPropertyName("locationId")]
        public int LocationId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("placeType")]
        public string PlaceType { get; set; }

        [JsonPropertyName("parentGeoId")]
        public int ParentGeoId { get; set; }

        [JsonPropertyName("__typename")]
        public string Typename { get; set; }

        [JsonPropertyName("additionalNames")]
        public AdditionalNames AdditionalNames { get; set; }

        [JsonPropertyName("parent")]
        public Parent Parent { get; set; }
    }

    public class Provider
    {
        [JsonPropertyName("isLocalProvider")]
        public bool IsLocalProvider { get; set; }

        [JsonPropertyName("isToolsProvider")]
        public bool IsToolsProvider { get; set; }
    }

    public class PhotoSize
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("width")]
        public int Width { get; set; }

        [JsonPropertyName("height")]
        public int Height { get; set; }
    }

    public class Avatar
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("photoSizes")]
        public List<PhotoSize> PhotoSizes { get; set; }
    }

    public class AdditionalNames3
    {
        [JsonPropertyName("long")]
        public string Long { get; set; }
    }

    public class Location2
    {
        [JsonPropertyName("locationId")]
        public int LocationId { get; set; }

        [JsonPropertyName("additionalNames")]
        public AdditionalNames3 AdditionalNames { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    public class Hometown
    {
        [JsonPropertyName("locationId")]
        public int? LocationId { get; set; }

        [JsonPropertyName("fallbackString")]
        public string FallbackString { get; set; }

        [JsonPropertyName("location")]
        public Location2 Location { get; set; }
    }

    public class ContributionCounts
    {
        [JsonPropertyName("sumAllUgc")]
        public int SumAllUgc { get; set; }

        [JsonPropertyName("helpfulVote")]
        public int HelpfulVote { get; set; }
    }

    public class Route
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class UserProfile
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("userId")]
        public string UserId { get; set; }

        [JsonPropertyName("isMe")]
        public bool IsMe { get; set; }

        [JsonPropertyName("isVerified")]
        public bool IsVerified { get; set; }

        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }

        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("avatar")]
        public Avatar Avatar { get; set; }

        [JsonPropertyName("hometown")]
        public Hometown Hometown { get; set; }

        [JsonPropertyName("contributionCounts")]
        public ContributionCounts ContributionCounts { get; set; }

        [JsonPropertyName("route")]
        public Route Route { get; set; }

        [JsonPropertyName("isFollowing")]
        public bool IsFollowing { get; set; }
    }

    public class TripInfo
    {
        [JsonPropertyName("stayDate")]
        public string StayDate { get; set; }

        [JsonPropertyName("tripType")]
        public string TripType { get; set; }
    }

    public class Route2
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }

    public class SocialStatistics
    {
        [JsonPropertyName("followCount")]
        public int FollowCount { get; set; }

        [JsonPropertyName("isFollowing")]
        public bool IsFollowing { get; set; }

        [JsonPropertyName("isLiked")]
        public bool IsLiked { get; set; }

        [JsonPropertyName("isReposted")]
        public bool IsReposted { get; set; }

        [JsonPropertyName("isSaved")]
        public bool IsSaved { get; set; }

        [JsonPropertyName("likeCount")]
        public int LikeCount { get; set; }

        [JsonPropertyName("repostCount")]
        public int RepostCount { get; set; }

        [JsonPropertyName("tripCount")]
        public int TripCount { get; set; }
    }

    public class Review
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("location")]
        public Location Location { get; set; }

        [JsonPropertyName("createdDate")]
        public string CreatedDate { get; set; }

        [JsonPropertyName("publishedDate")]
        public string PublishedDate { get; set; }

        [JsonPropertyName("provider")]
        public Provider Provider { get; set; }

        [JsonPropertyName("userProfile")]
        public UserProfile UserProfile { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("language")]
        public string Language { get; set; }

        [JsonPropertyName("translationType")]
        public object TranslationType { get; set; }

        [JsonPropertyName("roomTip")]
        public object RoomTip { get; set; }

        [JsonPropertyName("tripInfo")]
        public TripInfo TripInfo { get; set; }

        [JsonPropertyName("additionalRatings")]
        public List<object> AdditionalRatings { get; set; }

        [JsonPropertyName("mgmtResponse")]
        public object MgmtResponse { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("connectionToSubject")]
        public object ConnectionToSubject { get; set; }

        [JsonPropertyName("locationId")]
        public int LocationId { get; set; }

        [JsonPropertyName("rating")]
        public int Rating { get; set; }

        [JsonPropertyName("absoluteUrl")]
        public string AbsoluteUrl { get; set; }

        [JsonPropertyName("mcid")]
        public int Mcid { get; set; }

        [JsonPropertyName("mtProviderId")]
        public int MtProviderId { get; set; }

        [JsonPropertyName("photos")]
        public List<object> Photos { get; set; }

        [JsonPropertyName("original")]
        public object Original { get; set; }

        [JsonPropertyName("attribution")]
        public object Attribution { get; set; }

        [JsonPropertyName("__typename")]
        public string Typename { get; set; }

        [JsonPropertyName("helpfulVotes")]
        public int HelpfulVotes { get; set; }

        [JsonPropertyName("photoIds")]
        public List<object> PhotoIds { get; set; }

        [JsonPropertyName("route")]
        public Route2 Route { get; set; }

        [JsonPropertyName("socialStatistics")]
        public SocialStatistics SocialStatistics { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("userId")]
        public string UserId { get; set; }

        [JsonPropertyName("originalLanguage")]
        public string OriginalLanguage { get; set; }

        [JsonPropertyName("labels")]
        public List<object> Labels { get; set; }

        [JsonPropertyName("alertStatus")]
        public bool AlertStatus { get; set; }
    }

    public class ReviewListPage
    {
        [JsonPropertyName("totalCount")]
        public int TotalCount { get; set; }

        [JsonPropertyName("reviews")]
        public List<Review> Reviews { get; set; }
    }

    public class TripAdvisorPageResult
    {
        [JsonPropertyName("data")]
        public Data Data { get; set; }
    }

    public class Data
    {
        [JsonPropertyName("locations")]
        public List<DataLocation> Locations { get; set; }
    }

    public class DataLocation
    {
        [JsonPropertyName("reviewListPage")]
        public ReviewListPage ReviewListPage { get; set; }
    }
}