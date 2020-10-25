using System.Collections.Generic;
using Newtonsoft.Json;

namespace Extractisor
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class AdditionalNames
    {
        [JsonProperty("normal")]
        public string Normal { get; set; }

        [JsonProperty("long")]
        public string Long { get; set; }

        [JsonProperty("longOnlyParent")]
        public string LongOnlyParent { get; set; }

        [JsonProperty("longParentAbbreviated")]
        public string LongParentAbbreviated { get; set; }

        [JsonProperty("longOnlyParentAbbreviated")]
        public string LongOnlyParentAbbreviated { get; set; }

        [JsonProperty("longParentStateAbbreviated")]
        public string LongParentStateAbbreviated { get; set; }

        [JsonProperty("longOnlyParentStateAbbreviated")]
        public string LongOnlyParentStateAbbreviated { get; set; }

        [JsonProperty("geo")]
        public string Geo { get; set; }

        [JsonProperty("abbreviated")]
        public string Abbreviated { get; set; }

        [JsonProperty("abbreviatedRaw")]
        public string AbbreviatedRaw { get; set; }

        [JsonProperty("abbreviatedStateTerritory")]
        public string AbbreviatedStateTerritory { get; set; }

        [JsonProperty("abbreviatedStateTerritoryRaw")]
        public string AbbreviatedStateTerritoryRaw { get; set; }
    }

    public class AdditionalNames2
    {
        [JsonProperty("normal")]
        public string Normal { get; set; }

        [JsonProperty("long")]
        public string Long { get; set; }

        [JsonProperty("longOnlyParent")]
        public string LongOnlyParent { get; set; }

        [JsonProperty("longParentAbbreviated")]
        public string LongParentAbbreviated { get; set; }

        [JsonProperty("longOnlyParentAbbreviated")]
        public string LongOnlyParentAbbreviated { get; set; }

        [JsonProperty("longParentStateAbbreviated")]
        public string LongParentStateAbbreviated { get; set; }

        [JsonProperty("longOnlyParentStateAbbreviated")]
        public string LongOnlyParentStateAbbreviated { get; set; }

        [JsonProperty("geo")]
        public string Geo { get; set; }

        [JsonProperty("abbreviated")]
        public string Abbreviated { get; set; }

        [JsonProperty("abbreviatedRaw")]
        public string AbbreviatedRaw { get; set; }

        [JsonProperty("abbreviatedStateTerritory")]
        public string AbbreviatedStateTerritory { get; set; }

        [JsonProperty("abbreviatedStateTerritoryRaw")]
        public string AbbreviatedStateTerritoryRaw { get; set; }
    }

    public class Parent
    {
        [JsonProperty("locationId")]
        public int LocationId { get; set; }

        [JsonProperty("additionalNames")]
        public AdditionalNames2 AdditionalNames { get; set; }
    }

    public class Location
    {
        [JsonProperty("locationId")]
        public int LocationId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("placeType")]
        public string PlaceType { get; set; }

        [JsonProperty("parentGeoId")]
        public int ParentGeoId { get; set; }

        [JsonProperty("__typename")]
        public string Typename { get; set; }

        [JsonProperty("additionalNames")]
        public AdditionalNames AdditionalNames { get; set; }

        [JsonProperty("parent")]
        public Parent Parent { get; set; }
    }

    public class Provider
    {
        [JsonProperty("isLocalProvider")]
        public bool IsLocalProvider { get; set; }

        [JsonProperty("isToolsProvider")]
        public bool IsToolsProvider { get; set; }
    }

    public class PhotoSize
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }
    }

    public class Avatar
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("photoSizes")]
        public List<PhotoSize> PhotoSizes { get; set; }
    }

    public class AdditionalNames3
    {
        [JsonProperty("long")]
        public string Long { get; set; }
    }

    public class Location2
    {
        [JsonProperty("locationId")]
        public int LocationId { get; set; }

        [JsonProperty("additionalNames")]
        public AdditionalNames3 AdditionalNames { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Hometown
    {
        [JsonProperty("locationId")]
        public int? LocationId { get; set; }

        [JsonProperty("fallbackString")]
        public string FallbackString { get; set; }

        [JsonProperty("location")]
        public Location2 Location { get; set; }
    }

    public class ContributionCounts
    {
        [JsonProperty("sumAllUgc")]
        public int SumAllUgc { get; set; }

        [JsonProperty("helpfulVote")]
        public int HelpfulVote { get; set; }
    }

    public class Route
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class UserProfile
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("isMe")]
        public bool IsMe { get; set; }

        [JsonProperty("isVerified")]
        public bool IsVerified { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("avatar")]
        public Avatar Avatar { get; set; }

        [JsonProperty("hometown")]
        public Hometown Hometown { get; set; }

        [JsonProperty("contributionCounts")]
        public ContributionCounts ContributionCounts { get; set; }

        [JsonProperty("route")]
        public Route Route { get; set; }

        [JsonProperty("isFollowing")]
        public bool IsFollowing { get; set; }
    }

    public class TripInfo
    {
        [JsonProperty("stayDate")]
        public string StayDate { get; set; }

        [JsonProperty("tripType")]
        public string TripType { get; set; }
    }

    public class Route2
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class SocialStatistics
    {
        [JsonProperty("followCount")]
        public int FollowCount { get; set; }

        [JsonProperty("isFollowing")]
        public bool IsFollowing { get; set; }

        [JsonProperty("isLiked")]
        public bool IsLiked { get; set; }

        [JsonProperty("isReposted")]
        public bool IsReposted { get; set; }

        [JsonProperty("isSaved")]
        public bool IsSaved { get; set; }

        [JsonProperty("likeCount")]
        public int LikeCount { get; set; }

        [JsonProperty("repostCount")]
        public int RepostCount { get; set; }

        [JsonProperty("tripCount")]
        public int TripCount { get; set; }
    }

    public class Review
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("publishedDate")]
        public string PublishedDate { get; set; }

        [JsonProperty("provider")]
        public Provider Provider { get; set; }

        [JsonProperty("userProfile")]
        public UserProfile UserProfile { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("translationType")]
        public object TranslationType { get; set; }

        [JsonProperty("roomTip")]
        public object RoomTip { get; set; }

        [JsonProperty("tripInfo")]
        public TripInfo TripInfo { get; set; }

        [JsonProperty("additionalRatings")]
        public List<object> AdditionalRatings { get; set; }

        [JsonProperty("mgmtResponse")]
        public object MgmtResponse { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("connectionToSubject")]
        public object ConnectionToSubject { get; set; }

        [JsonProperty("locationId")]
        public int LocationId { get; set; }

        [JsonProperty("rating")]
        public int Rating { get; set; }

        [JsonProperty("absoluteUrl")]
        public string AbsoluteUrl { get; set; }

        [JsonProperty("mcid")]
        public int Mcid { get; set; }

        [JsonProperty("mtProviderId")]
        public int MtProviderId { get; set; }

        [JsonProperty("photos")]
        public List<object> Photos { get; set; }

        [JsonProperty("original")]
        public object Original { get; set; }

        [JsonProperty("attribution")]
        public object Attribution { get; set; }

        [JsonProperty("__typename")]
        public string Typename { get; set; }

        [JsonProperty("helpfulVotes")]
        public int HelpfulVotes { get; set; }

        [JsonProperty("photoIds")]
        public List<object> PhotoIds { get; set; }

        [JsonProperty("route")]
        public Route2 Route { get; set; }

        [JsonProperty("socialStatistics")]
        public SocialStatistics SocialStatistics { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("originalLanguage")]
        public string OriginalLanguage { get; set; }

        [JsonProperty("labels")]
        public List<object> Labels { get; set; }

        [JsonProperty("alertStatus")]
        public bool AlertStatus { get; set; }
    }

    public class ReviewListPage
    {
        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("reviews")]
        public List<Review> Reviews { get; set; }
    }

    public class TripAdvisorPageResult
    {
        [JsonProperty("data")]
        public Data Data { get; set; }
    }

    public class Data
    {
        [JsonProperty("locations")]
        public List<DataLocation> Locations { get; set; }
    }

    public class DataLocation
    {
        [JsonProperty("reviewListPage")]
        public ReviewListPage ReviewListPage { get; set; }
    }
}