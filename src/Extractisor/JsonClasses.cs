using System;
using System.Collections.Generic;
using System.Text;

namespace Extractisor
{

    public class Rootobject
    {
        public string[] assets { get; set; }
        public Redux redux { get; set; }
        public Apollocache[] apolloCache { get; set; }
        public Urqlcache urqlCache { get; set; }
        public Messages messages { get; set; }
        public Features features { get; set; }
        public Render[] renders { get; set; }
        public object[] profilables { get; set; }
        public object[] strictModeRoots { get; set; }
        public Hydration[] hydrations { get; set; }
        public string[] lazyLoadedModules { get; set; }
        public string[] ssrPreloadedModules { get; set; }
        public string[] bundles { get; set; }
    }

    public class Redux
    {
        public I18n i18n { get; set; }
        public Api api { get; set; }
        public Page page { get; set; }
        public Travelerinfo travelerInfo { get; set; }
        public Auth auth { get; set; }
        public Route route { get; set; }
        public Lithiumroute[] lithiumRoute { get; set; }
        public Overlays overlays { get; set; }
        public Meta meta { get; set; }
        public Tracking tracking { get; set; }
    }

    public class I18n
    {
        public string locale { get; set; }
        public string language { get; set; }
        public string ietfLocale { get; set; }
        public bool isRtl { get; set; }
        public string currencyCode { get; set; }
        public string distanceUnit { get; set; }
        public int firstDayOfWeek { get; set; }
    }

    public class Api
    {
        public Requests requests { get; set; }
        public Responses responses { get; set; }
    }

    public class Requests
    {
        public _Data_1_0_Brand_Header_Servlet_Attraction_Review_Viewportcategory_MOBILE_Geoid_295423_Pagename_Attraction_Review_Istareferrer_False _data_1_0_brand_header_servlet_Attraction_Review_viewportCategory_MOBILE_geoId_295423_pageName_Attraction_Review_isTaReferrer_false { get; set; }
        public _Data_1_0_Attraction_Company_Supplier_Contactcard_17837638 _data_1_0_attraction_company_supplier_contactcard_17837638 { get; set; }
        public _Data_1_0_Attraction_Company_Supplier_Products_Product_Photos_17837638_Locale_En_US_Currency_IRR_Page_0_Maxresults_24 _data_1_0_attraction_company_supplier_products_product_photos_17837638_locale_en_US_currency_IRR_page_0_maxResults_24 { get; set; }
        public _Data_1_0_Attraction_Categoryxsell_17837638 _data_1_0_attraction_categoryxsell_17837638 { get; set; }
        public _Data_1_0_Attraction_Company_Supplier_Derived_17837638 _data_1_0_attraction_company_supplier_derived_17837638 { get; set; }
        public _Data_1_0_Location_17837638_Hours _data_1_0_location_17837638_hours { get; set; }
        public _Data_1_0_Location_17837638__Allowedfields_Ta_Message _data_1_0_location_17837638__allowedFields_ta_message { get; set; }
        public _Data_1_0_Draftreviews_Hasdraft_17837638 _data_1_0_draftreviews_hasDraft_17837638 { get; set; }
        public _Data_1_0_Attraction_Similar_17837638 _data_1_0_attraction_similar_17837638 { get; set; }
        public _Data_1_0_Attractions_Products_Multitour_17837638 _data_1_0_attractions_products_multitour_17837638 { get; set; }
        public _Data_1_0_Attraction_Company_Supplier_Profile_17837638 _data_1_0_attraction_company_supplier_profile_17837638 { get; set; }
        public _Data_1_0_Attraction_About_17837638 _data_1_0_attraction_about_17837638 { get; set; }
        public _Data_1_0_Attraction_Company_Supplier_Products_List_17837638_Locale_En_US_Currency_IRR_Offset_0_Maxresults_5 _data_1_0_attraction_company_supplier_products_list_17837638_locale_en_US_currency_IRR_offset_0_maxResults_5 { get; set; }
        public _Data_1_0_Hoteldetail_17837638_Locationalert _data_1_0_hotelDetail_17837638_locationAlert { get; set; }
    }

    public class _Data_1_0_Brand_Header_Servlet_Attraction_Review_Viewportcategory_MOBILE_Geoid_295423_Pagename_Attraction_Review_Istareferrer_False
    {
        public bool loading { get; set; }
        public string[] result { get; set; }
        public string url { get; set; }
    }

    public class _Data_1_0_Attraction_Company_Supplier_Contactcard_17837638
    {
        public bool loading { get; set; }
        public string[] result { get; set; }
        public string url { get; set; }
    }

    public class _Data_1_0_Attraction_Company_Supplier_Products_Product_Photos_17837638_Locale_En_US_Currency_IRR_Page_0_Maxresults_24
    {
        public bool loading { get; set; }
        public string[] result { get; set; }
        public string url { get; set; }
    }

    public class _Data_1_0_Attraction_Categoryxsell_17837638
    {
        public bool loading { get; set; }
        public string[] result { get; set; }
        public string url { get; set; }
    }

    public class _Data_1_0_Attraction_Company_Supplier_Derived_17837638
    {
        public bool loading { get; set; }
        public string[] result { get; set; }
        public string url { get; set; }
    }

    public class _Data_1_0_Location_17837638_Hours
    {
        public bool loading { get; set; }
        public string[] result { get; set; }
        public string url { get; set; }
    }

    public class _Data_1_0_Location_17837638__Allowedfields_Ta_Message
    {
        public bool loading { get; set; }
        public string[] result { get; set; }
        public string url { get; set; }
    }

    public class _Data_1_0_Draftreviews_Hasdraft_17837638
    {
        public bool loading { get; set; }
        public string[] result { get; set; }
        public string url { get; set; }
    }

    public class _Data_1_0_Attraction_Similar_17837638
    {
        public bool loading { get; set; }
        public string[] result { get; set; }
        public string url { get; set; }
    }

    public class _Data_1_0_Attractions_Products_Multitour_17837638
    {
        public bool loading { get; set; }
        public string[] result { get; set; }
        public string url { get; set; }
    }

    public class _Data_1_0_Attraction_Company_Supplier_Profile_17837638
    {
        public bool loading { get; set; }
        public string[] result { get; set; }
        public string url { get; set; }
    }

    public class _Data_1_0_Attraction_About_17837638
    {
        public bool loading { get; set; }
        public string[] result { get; set; }
        public string url { get; set; }
    }

    public class _Data_1_0_Attraction_Company_Supplier_Products_List_17837638_Locale_En_US_Currency_IRR_Offset_0_Maxresults_5
    {
        public bool loading { get; set; }
        public string[] result { get; set; }
        public string url { get; set; }
    }

    public class _Data_1_0_Hoteldetail_17837638_Locationalert
    {
        public bool loading { get; set; }
        public string[] result { get; set; }
        public string url { get; set; }
    }

    public class Responses
    {
        public Data10AttractionCompanySupplierProductsList17837638LocaleEn_USCurrencyIRROffset0Maxresults5 data10attractioncompanysupplierproductslist17837638localeen_UScurrencyIRRoffset0maxResults5 { get; set; }
        public Data10Hoteldetail17837638Locationalert data10hotelDetail17837638locationAlert { get; set; }
        public Data10AttractionCompanySupplierContactcard17837638 data10attractioncompanysuppliercontactcard17837638 { get; set; }
        public Data10Location17837638AllowedfieldsTa_Message data10location17837638allowedFieldsta_message { get; set; }
        public Data10AttractionCompanySupplierProfile17837638 data10attractioncompanysupplierprofile17837638 { get; set; }
        public Data10AttractionCategoryxsell17837638 data10attractioncategoryxsell17837638 { get; set; }
        public Data10AttractionCompanySupplierDerived17837638 data10attractioncompanysupplierderived17837638 { get; set; }
        public Data10DraftreviewsHasdraft17837638 data10draftreviewshasDraft17837638 { get; set; }
        public Data10Location17837638Hours data10location17837638hours { get; set; }
        public Data10BrandHeaderServletAttraction_ReviewViewportcategoryMOBILEGeoid295423PagenameAttraction_ReviewIstareferrerFalse data10brandheaderservletAttraction_ReviewviewportCategoryMOBILEgeoId295423pageNameAttraction_ReviewisTaReferrerfalse { get; set; }
        public Data10AttractionsProductsMultitour17837638 data10attractionsproductsmultitour17837638 { get; set; }
        public Data10AttractionCompanySupplierProductsProductPhotos17837638LocaleEn_USCurrencyIRRPage0Maxresults24 data10attractioncompanysupplierproductsproductphotos17837638localeen_UScurrencyIRRpage0maxResults24 { get; set; }
        public Data10AttractionSimilar17837638 data10attractionsimilar17837638 { get; set; }
        public Data10AttractionAbout17837638 data10attractionabout17837638 { get; set; }
    }

    public class Data10AttractionCompanySupplierProductsList17837638LocaleEn_USCurrencyIRROffset0Maxresults5
    {
        public Data data { get; set; }
        public object error { get; set; }
    }

    public class Data
    {
        public object supplierCode { get; set; }
        public int attractionId { get; set; }
        public int totalAvailable { get; set; }
        public int offset { get; set; }
        public object[] products { get; set; }
        public object urgencyMessage { get; set; }
        public object seeAllUrl { get; set; }
    }

    public class Data10Hoteldetail17837638Locationalert
    {
        public Data1 data { get; set; }
        public object error { get; set; }
    }

    public class Data1
    {
        public object responseDate { get; set; }
        public object ownerPropertyName { get; set; }
        public bool shouldTranslateResponse { get; set; }
        public bool hasOverrideMessaging { get; set; }
        public bool hasSensitiveIssuesBadge { get; set; }
        public object ownerName { get; set; }
        public object ownerRole { get; set; }
        public object ownerResponseText { get; set; }
        public object targetLanguage { get; set; }
        public object message { get; set; }
    }

    public class Data10AttractionCompanySupplierContactcard17837638
    {
        public Data2 data { get; set; }
        public object error { get; set; }
    }

    public class Data2
    {
        public string location { get; set; }
        public string email { get; set; }
        public string website { get; set; }
        public string phone { get; set; }
    }

    public class Data10Location17837638AllowedfieldsTa_Message
    {
        public Data3 data { get; set; }
        public object error { get; set; }
    }

    public class Data3
    {
        public string location_id { get; set; }
        public string name { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string num_reviews { get; set; }
        public string timezone { get; set; }
        public string location_string { get; set; }
        public object[] awards { get; set; }
        public string location_subtype { get; set; }
        public string preferred_map_engine { get; set; }
        public object distance { get; set; }
        public object distance_string { get; set; }
        public object bearing { get; set; }
        public bool is_closed { get; set; }
        public string open_now_text { get; set; }
        public bool is_long_closed { get; set; }
        public string description { get; set; }
        public string web_url { get; set; }
        public object[] ancestors { get; set; }
        public Category category { get; set; }
        public object[] subcategory { get; set; }
        public bool is_jfy_enabled { get; set; }
        public object[] nearest_metro_station { get; set; }
        public bool is_candidate_for_contact_info_suppression { get; set; }
        public object tags { get; set; }
        public object photo { get; set; }
        public object display_hours { get; set; }
    }

    public class Category
    {
        public string key { get; set; }
        public string name { get; set; }
    }

    public class Data10AttractionCompanySupplierProfile17837638
    {
        public Data4 data { get; set; }
        public object error { get; set; }
    }

    public class Data4
    {
        public object supplierCode { get; set; }
        public string tripadvisorId { get; set; }
        public string avatarPicUrl { get; set; }
        public string name { get; set; }
        public object shortIntro { get; set; }
        public Description description { get; set; }
        public string countryCode { get; set; }
        public object[] supportedLanguages { get; set; }
        public object profession { get; set; }
        public object credentials { get; set; }
        public object isProfessionalTourGuide { get; set; }
        public object hasTourGuideLicense { get; set; }
        public object isTestSupplier { get; set; }
        public bool isClosed { get; set; }
        public Featuredanimals featuredAnimals { get; set; }
        public string improveListingUrl { get; set; }
        public object website { get; set; }
        public object email { get; set; }
        public object phone { get; set; }
        public object[] tags { get; set; }
    }

    public class Description
    {
        public string text { get; set; }
        public object locale { get; set; }
        public object originalLocale { get; set; }
        public object translation { get; set; }
    }

    public class Featuredanimals
    {
        public bool hasAnimals { get; set; }
        public bool violatesAnimalWelfarePolicy { get; set; }
        public string animalLearnMoreUrl { get; set; }
    }

    public class Data10AttractionCategoryxsell17837638
    {
        public Data5 data { get; set; }
        public object error { get; set; }
    }

    public class Data5
    {
        public string title { get; set; }
        public string shortTitle { get; set; }
        public object[] shelves { get; set; }
        public string url { get; set; }
    }

    public class Data10AttractionCompanySupplierDerived17837638
    {
        public Data6 data { get; set; }
        public object error { get; set; }
    }

    public class Data6
    {
        public object[] locations { get; set; }
        public int productCount { get; set; }
        public int totalReviewCount { get; set; }
        public int overallRating { get; set; }
        public int rankingPosition { get; set; }
        public int rankingDenominator { get; set; }
        public string rankingCategoryUrl { get; set; }
        public string rankingCategoryLabel { get; set; }
        public string rankingParentGeo { get; set; }
        public Attrlink[] attrLinks { get; set; }
        public int collapseAfter { get; set; }
        public bool showMoreLink { get; set; }
    }

    public class Attrlink
    {
        public bool canCollapse { get; set; }
        public Link link { get; set; }
        public string linkType { get; set; }
        public int id { get; set; }
    }

    public class Link
    {
        public string url { get; set; }
        public object beforeText { get; set; }
        public object afterText { get; set; }
        public string name { get; set; }
    }

    public class Data10DraftreviewsHasdraft17837638
    {
        public bool data { get; set; }
        public object error { get; set; }
    }

    public class Data10Location17837638Hours
    {
        public Data7 data { get; set; }
        public object error { get; set; }
    }

    public class Data7
    {
        public string openStatus { get; set; }
        public string openStatusText { get; set; }
        public string hoursTodayText { get; set; }
        public string currentHoursText { get; set; }
        public Allopenhour[] allOpenHours { get; set; }
        public Addhourslink addHoursLink { get; set; }
    }

    public class Addhourslink
    {
        public string url { get; set; }
        public string text { get; set; }
    }

    public class Allopenhour
    {
        public string days { get; set; }
        public string[] times { get; set; }
    }

    public class Data10BrandHeaderServletAttraction_ReviewViewportcategoryMOBILEGeoid295423PagenameAttraction_ReviewIstareferrerFalse
    {
        public Data8 data { get; set; }
        public object error { get; set; }
    }

    public class Data8
    {
        public bool adjustForSmartBanner { get; set; }
        public bool showGeopill { get; set; }
        public int numLines { get; set; }
        public bool isPersistentHeader { get; set; }
        public bool usePersistentIcons { get; set; }
        public bool hideLogo { get; set; }
        public bool liteHeader { get; set; }
    }

    public class Data10AttractionsProductsMultitour17837638
    {
        public Data9 data { get; set; }
        public object error { get; set; }
    }

    public class Data9
    {
        public int totalProductCount { get; set; }
    }

    public class Data10AttractionCompanySupplierProductsProductPhotos17837638LocaleEn_USCurrencyIRRPage0Maxresults24
    {
        public Data10 data { get; set; }
        public object error { get; set; }
    }

    public class Data10
    {
        public string[] urls { get; set; }
        public int[] mediaIds { get; set; }
    }

    public class Data10AttractionSimilar17837638
    {
        public object data { get; set; }
        public Error error { get; set; }
    }

    public class Error
    {
        public Error1 error { get; set; }
    }

    public class Error1
    {
        public string message { get; set; }
    }

    public class Data10AttractionAbout17837638
    {
        public Data11 data { get; set; }
        public object error { get; set; }
    }

    public class Data11
    {
        public string name { get; set; }
        public string url { get; set; }
        public Description1 description { get; set; }
        public Truncateddescription truncatedDescription { get; set; }
        public bool hasCertificateOfExcellenceAward { get; set; }
        public int rating { get; set; }
        public int numReviews { get; set; }
        public string recommendedVisit { get; set; }
        public bool openNow { get; set; }
        public string openHoursDisplayText { get; set; }
        public string hoursTodayText { get; set; }
        public Displayhour[] displayHours { get; set; }
        public Taxonomyinfo[] taxonomyInfos { get; set; }
        public Rankinginfo rankingInfo { get; set; }
        public int id { get; set; }
        public bool showTravelersTalkAbout { get; set; }
        public string improveThisListingLink { get; set; }
        public Thumbnail thumbnail { get; set; }
    }

    public class Description1
    {
        public string text { get; set; }
        public object locale { get; set; }
        public object originalLocale { get; set; }
        public object translation { get; set; }
    }

    public class Truncateddescription
    {
        public string text { get; set; }
        public object locale { get; set; }
        public object originalLocale { get; set; }
        public object translation { get; set; }
    }

    public class Rankinginfo
    {
        public int position { get; set; }
        public int denominator { get; set; }
        public string url { get; set; }
        public string categoryLabel { get; set; }
        public string parentGeo { get; set; }
    }

    public class Thumbnail
    {
        public int id { get; set; }
        public string caption { get; set; }
        public DateTime published_date { get; set; }
        public int helpful_votes { get; set; }
        public bool is_blessed { get; set; }
        public DateTime uploaded_date { get; set; }
        public Images images { get; set; }
    }

    public class Images
    {
        public Small small { get; set; }
        public Thumbnail1 thumbnail { get; set; }
        public Original original { get; set; }
        public Large large { get; set; }
        public Medium medium { get; set; }
    }

    public class Small
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Thumbnail1
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Original
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Large
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Medium
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Displayhour
    {
        public string days { get; set; }
        public string[] times { get; set; }
    }

    public class Taxonomyinfo
    {
        public int id { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public string type { get; set; }
    }

    public class Page
    {
        public string name { get; set; }
        public int geoId { get; set; }
        public int detailId { get; set; }
        public object crossSells { get; set; }
    }

    public class Travelerinfo
    {
        public Preferences preferences { get; set; }
        public object hotels { get; set; }
        public Vr vr { get; set; }
        public Attractions attractions { get; set; }
        public Restaurants restaurants { get; set; }
        public object home { get; set; }
        public Flights flights { get; set; }
    }

    public class Preferences
    {
        public string currency { get; set; }
    }

    public class Vr
    {
        public object start { get; set; }
        public object end { get; set; }
        public int adults { get; set; }
        public int children { get; set; }
    }

    public class Attractions
    {
        public string singleDate { get; set; }
        public string fromDate { get; set; }
        public string toDate { get; set; }
        public int attractionPaxAdults { get; set; }
        public int attractionPaxChildren { get; set; }
    }

    public class Restaurants
    {
        public string date { get; set; }
        public string time { get; set; }
        public string partySize { get; set; }
        public bool isDefault { get; set; }
        public string displayDate { get; set; }
    }

    public class Flights
    {
        public string oneWayDate { get; set; }
        public string departureDate { get; set; }
        public string returnDate { get; set; }
        public object originAirportCode { get; set; }
        public object destinationAirportCode { get; set; }
    }

    public class Auth
    {
        public bool isMember { get; set; }
        public string csrfToken { get; set; }
        public string altSessId { get; set; }
        public object loggedInUserId { get; set; }
        public object captcha { get; set; }
        public Fbapi fbApi { get; set; }
    }

    public class Fbapi
    {
        public string apiVersion { get; set; }
        public string facebookConnectApiKey { get; set; }
        public string facebookConnectAppId { get; set; }
        public string facebookConnectAppName { get; set; }
        public int taServerTime { get; set; }
        public bool skipFacebookSessionCheck { get; set; }
        public string sdkUrl { get; set; }
        public string facebookPermissions { get; set; }
    }

    public class Route
    {
        public string geo { get; set; }
        public string detail { get; set; }
        public string page { get; set; }
        public string o { get; set; }
    }

    public class Overlays
    {
        public object global { get; set; }
        public object fab { get; set; }
        public Locals locals { get; set; }
        public object[] toasts { get; set; }
    }

    public class Locals
    {
    }

    public class Meta
    {
        public string initialServletName { get; set; }
        public Device device { get; set; }
        public bool readonlyMode { get; set; }
        public string initialRelativeUrl { get; set; }
        public string initialAbsoluteUrl { get; set; }
        public string baseUrl { get; set; }
        public string imageCdnUrl { get; set; }
        public string cookieDomain { get; set; }
        public string taUnique { get; set; }
        public bool isTaReferrer { get; set; }
        public object referrerUrl { get; set; }
        public bool forceFullSite { get; set; }
        public string environment { get; set; }
        public bool isNativeWebview { get; set; }
        public int commerceCountryId { get; set; }
        public Impressiondata impressionData { get; set; }
        public Lineitemsbyloc lineItemsByLoc { get; set; }
    }

    public class Device
    {
        public string viewportCategory { get; set; }
        public string userAgentCategory { get; set; }
        public Os os { get; set; }
        public Browser browser { get; set; }
        public string securityToken { get; set; }
    }

    public class Os
    {
        public string family { get; set; }
        public int majorVersion { get; set; }
    }

    public class Browser
    {
        public string family { get; set; }
        public int majorVersion { get; set; }
    }

    public class Impressiondata
    {
        public string pageLoadUid { get; set; }
    }

    public class Lineitemsbyloc
    {
    }

    public class Tracking
    {
        public int mcid { get; set; }
        public string uid { get; set; }
        public Analytics analytics { get; set; }
        public string searchSessionId { get; set; }
        public string sessionId { get; set; }
        public string uniqueId { get; set; }
        public string serverName { get; set; }
        public string hostName { get; set; }
        public int vcsRevision { get; set; }
        public string vcsBranch { get; set; }
        public string drsInfo { get; set; }
        public string uvmScore { get; set; }
        public string retargetingUrl { get; set; }
        public string domainName { get; set; }
    }

    public class Analytics
    {
        public object[][] cv { get; set; }
        public string url { get; set; }
    }

    public class Lithiumroute
    {
        public string page { get; set; }
        public Params _params { get; set; }
        public string path { get; set; }
        public string fragment { get; set; }
        public string uid { get; set; }
    }

    public class Params
    {
        public string offset { get; set; }
        public int geoId { get; set; }
        public int detailId { get; set; }
    }

    public class Urqlcache
    {
        public _142903272 _142903272 { get; set; }
        public _705469953 _705469953 { get; set; }
        public _720901404 _720901404 { get; set; }
        public _824923715 _824923715 { get; set; }
        public _2149739531 _2149739531 { get; set; }
        public _2638710656 _2638710656 { get; set; }
        public _3455660163 _3455660163 { get; set; }
        public _3759005133 _3759005133 { get; set; }
        public _156401003945857 _156401003945857 { get; set; }
    }

    public class _142903272
    {
        public Data12 data { get; set; }
    }

    public class Data12
    {
        public object cachedFilters { get; set; }
        public object cachedPrefs { get; set; }
        public Location[] locations { get; set; }
    }

    public class Location
    {
        public int locationId { get; set; }
        public int parentGeoId { get; set; }
        public string name { get; set; }
        public string placeType { get; set; }
        public Reviewsummary reviewSummary { get; set; }
        public Keywords keywords { get; set; }
        public object currentUserOwnerStatus { get; set; }
        public string accommodationCategory { get; set; }
        public string url { get; set; }
        public Reviewlistpage reviewListPage { get; set; }
        public Reviewaggregations reviewAggregations { get; set; }
    }

    public class Reviewsummary
    {
        public int rating { get; set; }
        public int count { get; set; }
    }

    public class Keywords
    {
        public Keyword[] keywords { get; set; }
    }

    public class Keyword
    {
        public string keyword { get; set; }
    }

    public class Reviewlistpage
    {
        public int totalCount { get; set; }
        public object[] preferredReviewIds { get; set; }
        public Review[] reviews { get; set; }
    }

    public class Review
    {
        public int id { get; set; }
        public string url { get; set; }
        public Location1 location { get; set; }
        public string createdDate { get; set; }
        public string publishedDate { get; set; }
        public Provider provider { get; set; }
        public Userprofile userProfile { get; set; }
        public string title { get; set; }
        public string language { get; set; }
        public object translationType { get; set; }
        public object roomTip { get; set; }
        public Tripinfo tripInfo { get; set; }
        public object[] additionalRatings { get; set; }
        public object mgmtResponse { get; set; }
        public string text { get; set; }
        public string username { get; set; }
        public object connectionToSubject { get; set; }
        public int locationId { get; set; }
        public int rating { get; set; }
        public string absoluteUrl { get; set; }
        public int mcid { get; set; }
        public int mtProviderId { get; set; }
        public Photo[] photos { get; set; }
        public object original { get; set; }
        public object attribution { get; set; }
        public string __typename { get; set; }
        public int helpfulVotes { get; set; }
        public int?[] photoIds { get; set; }
        public Route2 route { get; set; }
        public Socialstatistics socialStatistics { get; set; }
        public string status { get; set; }
        public string userId { get; set; }
        public string originalLanguage { get; set; }
        public object[] labels { get; set; }
        public bool alertStatus { get; set; }
    }

    public class Location1
    {
        public int locationId { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public string placeType { get; set; }
        public int parentGeoId { get; set; }
        public string __typename { get; set; }
        public Additionalnames additionalNames { get; set; }
        public Parent parent { get; set; }
    }

    public class Additionalnames
    {
        public string normal { get; set; }
        public string _long { get; set; }
        public string longOnlyParent { get; set; }
        public string longParentAbbreviated { get; set; }
        public string longOnlyParentAbbreviated { get; set; }
        public string longParentStateAbbreviated { get; set; }
        public string longOnlyParentStateAbbreviated { get; set; }
        public string geo { get; set; }
        public string abbreviated { get; set; }
        public string abbreviatedRaw { get; set; }
        public string abbreviatedStateTerritory { get; set; }
        public string abbreviatedStateTerritoryRaw { get; set; }
    }

    public class Parent
    {
        public int locationId { get; set; }
        public Additionalnames1 additionalNames { get; set; }
    }

    public class Additionalnames1
    {
        public string normal { get; set; }
        public string _long { get; set; }
        public string longOnlyParent { get; set; }
        public string longParentAbbreviated { get; set; }
        public string longOnlyParentAbbreviated { get; set; }
        public string longParentStateAbbreviated { get; set; }
        public string longOnlyParentStateAbbreviated { get; set; }
        public string geo { get; set; }
        public string abbreviated { get; set; }
        public string abbreviatedRaw { get; set; }
        public string abbreviatedStateTerritory { get; set; }
        public string abbreviatedStateTerritoryRaw { get; set; }
    }

    public class Provider
    {
        public bool isLocalProvider { get; set; }
        public bool isToolsProvider { get; set; }
    }

    public class Userprofile
    {
        public string id { get; set; }
        public string userId { get; set; }
        public bool isMe { get; set; }
        public bool isVerified { get; set; }
        public string displayName { get; set; }
        public string username { get; set; }
        public Avatar avatar { get; set; }
        public Hometown hometown { get; set; }
        public Contributioncounts contributionCounts { get; set; }
        public Route1 route { get; set; }
        public bool isFollowing { get; set; }
    }

    public class Avatar
    {
        public int id { get; set; }
        public Photosize[] photoSizes { get; set; }
    }

    public class Photosize
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Hometown
    {
        public int? locationId { get; set; }
        public string fallbackString { get; set; }
        public Location2 location { get; set; }
    }

    public class Location2
    {
        public int locationId { get; set; }
        public Additionalnames2 additionalNames { get; set; }
        public string name { get; set; }
    }

    public class Additionalnames2
    {
        public string _long { get; set; }
    }

    public class Contributioncounts
    {
        public int sumAllUgc { get; set; }
        public int helpfulVote { get; set; }
    }

    public class Route1
    {
        public string url { get; set; }
    }

    public class Tripinfo
    {
        public string stayDate { get; set; }
        public string tripType { get; set; }
    }

    public class Route2
    {
        public string url { get; set; }
    }

    public class Socialstatistics
    {
        public int followCount { get; set; }
        public bool isFollowing { get; set; }
        public bool isLiked { get; set; }
        public bool isReposted { get; set; }
        public bool isSaved { get; set; }
        public int likeCount { get; set; }
        public int repostCount { get; set; }
        public int tripCount { get; set; }
    }

    public class Photo
    {
        public int id { get; set; }
        public string[] statuses { get; set; }
        public Photosize1[] photoSizes { get; set; }
    }

    public class Photosize1
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Reviewaggregations
    {
        public int[] ratingCounts { get; set; }
        public Languagecounts languageCounts { get; set; }
        public int alertStatusCount { get; set; }
    }

    public class Languagecounts
    {
        public int en { get; set; }
        public int es { get; set; }
    }

    public class _705469953
    {
        public Data13 data { get; set; }
    }

    public class Data13
    {
        public Footerlinks footerLinks { get; set; }
    }

    public class Footerlinks
    {
        public Aboutuslink[] aboutUsLinks { get; set; }
        public Businesslink[] businessLinks { get; set; }
        public Restaurantlink[] restaurantLinks { get; set; }
        public Explorelink[] exploreLinks { get; set; }
        public Legallink[] legalLinks { get; set; }
        public Applink[] appLinks { get; set; }
        public Sociallink[] socialLinks { get; set; }
        public Partnerlink[] partnerLinks { get; set; }
    }

    public class Aboutuslink
    {
        public string preLocalizedAnchorText { get; set; }
        public object localizedAnchorText { get; set; }
        public bool newWindow { get; set; }
        public string trackAction { get; set; }
        public string url { get; set; }
    }

    public class Businesslink
    {
        public string preLocalizedAnchorText { get; set; }
        public object localizedAnchorText { get; set; }
        public object newWindow { get; set; }
        public string trackAction { get; set; }
        public string url { get; set; }
    }

    public class Restaurantlink
    {
        public string preLocalizedAnchorText { get; set; }
        public object localizedAnchorText { get; set; }
        public object newWindow { get; set; }
        public string trackAction { get; set; }
        public string url { get; set; }
    }

    public class Explorelink
    {
        public string preLocalizedAnchorText { get; set; }
        public object localizedAnchorText { get; set; }
        public object newWindow { get; set; }
        public string trackAction { get; set; }
        public string url { get; set; }
        public object isObfuscated { get; set; }
    }

    public class Legallink
    {
        public string preLocalizedAnchorText { get; set; }
        public object localizedAnchorText { get; set; }
        public object newWindow { get; set; }
        public string trackAction { get; set; }
        public string url { get; set; }
        public object isObfuscated { get; set; }
    }

    public class Applink
    {
        public string preLocalizedAnchorText { get; set; }
        public object localizedAnchorText { get; set; }
        public bool newWindow { get; set; }
        public string trackAction { get; set; }
        public string url { get; set; }
    }

    public class Sociallink
    {
        public string preLocalizedAnchorText { get; set; }
        public object localizedAnchorText { get; set; }
        public string iconUrl { get; set; }
        public string trackAction { get; set; }
        public string url { get; set; }
    }

    public class Partnerlink
    {
        public string preLocalizedLink { get; set; }
        public object localizedLink { get; set; }
        public string trackAction { get; set; }
    }

    public class _720901404
    {
        public Data14 data { get; set; }
    }

    public class Data14
    {
        public Location3[] locations { get; set; }
    }

    public class Location3
    {
        public Reviewsummary1 reviewSummary { get; set; }
    }

    public class Reviewsummary1
    {
        public int count { get; set; }
    }

    public class _824923715
    {
        public Data15 data { get; set; }
    }

    public class Data15
    {
        public object[] locations { get; set; }
    }

    public class _2149739531
    {
        public Data16 data { get; set; }
    }

    public class Data16
    {
        public Explicitpreferences explicitPreferences { get; set; }
    }

    public class Explicitpreferences
    {
        public Where where { get; set; }
        public Segment segment { get; set; }
        public Dates dates { get; set; }
        public Interests interests { get; set; }
    }

    public class Where
    {
        public int value { get; set; }
    }

    public class Segment
    {
        public object value { get; set; }
    }

    public class Dates
    {
        public object value { get; set; }
    }

    public class Interests
    {
        public Value[] value { get; set; }
    }

    public class Value
    {
        public string type { get; set; }
        public string value { get; set; }
        public bool selected { get; set; }
        public Display display { get; set; }
    }

    public class Display
    {
        public string displayText { get; set; }
    }

    public class _2638710656
    {
        public Data17 data { get; set; }
    }

    public class Data17
    {
        public Currency currency { get; set; }
    }

    public class Currency
    {
        public string code { get; set; }
        public string name { get; set; }
        public string symbol { get; set; }
    }

    public class _3455660163
    {
        public Data18 data { get; set; }
    }

    public class Data18
    {
        public Location6[] locations { get; set; }
        public Canonicalizedroute[] canonicalizedRoutes { get; set; }
        public Insightprofile insightProfile { get; set; }
        public Populardestination[] popularDestinations { get; set; }
    }

    public class Insightprofile
    {
        public Location4[] locations { get; set; }
    }

    public class Location4
    {
        public Location5 location { get; set; }
    }

    public class Location5
    {
        public int locationId { get; set; }
        public int parentId { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public string HOTELS_URL { get; set; }
        public string ATTRACTIONS_URL { get; set; }
        public string RESTAURANTS_URL { get; set; }
        public bool isGeo { get; set; }
        public Locationv2 locationV2 { get; set; }
        public Thumbnail2 thumbnail { get; set; }
        public string placeType { get; set; }
    }

    public class Locationv2
    {
        public string placeType { get; set; }
        public Names names { get; set; }
        public object vacationRentalsRoute { get; set; }
    }

    public class Names
    {
        public string longOnlyHierarchyTypeahead { get; set; }
        public string longOnlyHierarchyTypeaheadV2 { get; set; }
    }

    public class Thumbnail2
    {
        public Photosize2[] photoSizes { get; set; }
    }

    public class Photosize2
    {
        public int width { get; set; }
        public int height { get; set; }
        public string url { get; set; }
    }

    public class Location6
    {
        public string name { get; set; }
    }

    public class Canonicalizedroute
    {
        public string url { get; set; }
    }

    public class Populardestination
    {
        public int locationId { get; set; }
        public int parentId { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public string HOTELS_URL { get; set; }
        public string ATTRACTIONS_URL { get; set; }
        public string RESTAURANTS_URL { get; set; }
        public bool isGeo { get; set; }
        public Locationv21 locationV2 { get; set; }
        public Thumbnail3 thumbnail { get; set; }
        public string placeType { get; set; }
    }

    public class Locationv21
    {
        public string placeType { get; set; }
        public Names1 names { get; set; }
        public Vacationrentalsroute vacationRentalsRoute { get; set; }
    }

    public class Names1
    {
        public string longOnlyHierarchyTypeahead { get; set; }
        public string longOnlyHierarchyTypeaheadV2 { get; set; }
    }

    public class Vacationrentalsroute
    {
        public string url { get; set; }
    }

    public class Thumbnail3
    {
        public Photosize3[] photoSizes { get; set; }
    }

    public class Photosize3
    {
        public int width { get; set; }
        public int height { get; set; }
        public string url { get; set; }
    }

    public class _3759005133
    {
        public Data19 data { get; set; }
    }

    public class Data19
    {
        public Location7[] locations { get; set; }
        public object memberProfile { get; set; }
        public Explicitpreferences1 explicitPreferences { get; set; }
    }

    public class Explicitpreferences1
    {
        public Where1 where { get; set; }
        public Segment1 segment { get; set; }
        public Dates1 dates { get; set; }
        public Interests1 interests { get; set; }
    }

    public class Where1
    {
        public int value { get; set; }
    }

    public class Segment1
    {
        public object value { get; set; }
    }

    public class Dates1
    {
        public object value { get; set; }
    }

    public class Interests1
    {
        public Value1[] value { get; set; }
    }

    public class Value1
    {
        public string type { get; set; }
        public string value { get; set; }
        public bool selected { get; set; }
        public Display1 display { get; set; }
    }

    public class Display1
    {
        public string displayText { get; set; }
    }

    public class Location7
    {
        public string name { get; set; }
    }

    public class _156401003945857
    {
        public Data20 data { get; set; }
    }

    public class Data20
    {
        public Currentlocale currentLocale { get; set; }
    }

    public class Currentlocale
    {
        public string pointOfSaleName { get; set; }
        public string ietfLocale { get; set; }
        public string languageName { get; set; }
        public Country country { get; set; }
    }

    public class Country
    {
        public int locationId { get; set; }
        public string name { get; set; }
    }

    public class Messages
    {
        public string details_section_header { get; set; }
        public string attractions_checkout_abandonment_popup_special_offer_terms_feb_2020 { get; set; }
        public string cx_explicit_preferences_end_body_geo { get; set; }
        public string filter_reviews { get; set; }
        public string mentions_profile_label_a_lower { get; set; }
        public string sanitation_checklist_community { get; set; }
        public string relative_dates_responded_caps { get; set; }
        public string iap_trips_copyrighted { get; set; }
        public string iap_trips_error_or_disagree { get; set; }
        public string cx_explicit_preferences_cta_traveling_partner { get; set; }
        public string member_event_on_linkpost { get; set; }
        public string trips_error_save_trip_full { get; set; }
        public string social_publish_date_Yesterday { get; set; }
        public string social_report_ty2b { get; set; }
        public string hs_safety_tooltip { get; set; }
        public string social_content_report_copyright_violation { get; set; }
        public string cx_explicit_preferences_cta_traveling_family { get; set; }
        public string routecategory_europe { get; set; }
        public string stat_modal_saved_to_tripname_with_bold { get; set; }
        public string repost_rate_limited_v2 { get; set; }
        public string attractionsbookingflaglikely_to_sell_out { get; set; }
        public string ugc_post_updated { get; set; }
        public string hs_safety_filter_removable { get; set; }
        public string exp_ar_improve_this_listing { get; set; }
        public string cx_explicit_preferences_segment_friends { get; set; }
        public string language_portugese_ffffe66c { get; set; }
        public string iap_forums_harassment { get; set; }
        public string onetap_subhead_signin_alerts_deals { get; set; }
        public string social_untag_me { get; set; }
        public string restaurant_owner_upload_photo_cta { get; set; }
        public string home_location_things_near_you { get; set; }
        public string native_login_user_review_anonymous { get; set; }
        public string attractionsbookingflagspecial_offer { get; set; }
        public string trips_error_default_add_item_to_trip { get; set; }
        public string boosted_social { get; set; }
        public string mem_account_info { get; set; }
        public string I_live_in { get; set; }
        public string report_review_radio_desc_11_ver_1 { get; set; }
        public string restaurants_view_all_details { get; set; }
        public string delete_confirmation_description_post_0 { get; set; }
        public string mv_photos_from_professionals { get; set; }
        public string social_profile_contributions { get; set; }
        public string btn_cancel { get; set; }
        public string relative_dates_weeks_fffff175 { get; set; }
        public string cx_explicit_preferences_cta_month2 { get; set; }
        public string cx_explicit_preferences_cta_solo2 { get; set; }
        public string onetap_message_unlock { get; set; }
        public string mem_offers_e4e { get; set; }
        public string brand_save_money_we_search_200 { get; set; }
        public string Date_of_travel { get; set; }
        public string ttd_ar_featuresanimals_body_v2 { get; set; }
        public string mobile_no_results_found_8e0 { get; set; }
        public string trips_stat_modal_profanity_check_native { get; set; }
        public string iap_promote_illegal_activity { get; set; }
        public string airm_baggage_fees_included { get; set; }
        public string member_event_on_photo { get; set; }
        public string routecategory_caribbean { get; set; }
        public string owners_managelisting_open { get; set; }
        public string iap_profile_contribution { get; set; }
        public string insurance_title { get; set; }
        public string delete_confirmation_description_video_0 { get; set; }
        public string tc_popup_text { get; set; }
        public string favorite_review_travelertype_solo { get; set; }
        public string n_Trips_plural { get; set; }
        public string attractionsbookingerrorsapi_error { get; set; }
        public string airm_premiumEconomy { get; set; }
        public string flights_airline_reviews_basic_economy { get; set; }
        public string mobile_book_tour_all_caps_2558 { get; set; }
        public string social_report_level2_3 { get; set; }
        public string cx_explicit_preferences_welcome_subheader2 { get; set; }
        public string social_label_Suggested_for_you { get; set; }
        public string social_report_level2_1 { get; set; }
        public string trip_level_2_disagree_or_error { get; set; }
        public string ur_rd_0characterminimum { get; set; }
        public string social_report_level2_5 { get; set; }
        public string social_report_level2_4 { get; set; }
        public string rcp_review_attribution_update { get; set; }
        public string stat_modal_change { get; set; }
        public string attractionsfilteredpriceperday { get; set; }
        public string attractionsbookingsectionduration { get; set; }
        public string global_nav_content_cta_post { get; set; }
        public string restaurants_view_all_hours { get; set; }
        public string iap_forums_copyrighted { get; set; }
        public string common_Yes { get; set; }
        public string Claim_badge_unclaimed_tooltip_2_b { get; set; }
        public string cx_explicit_preferences_segment_header { get; set; }
        public string sanitation_checklist_email_restaurant { get; set; }
        public string delete_confirmation_header_forum_post_0 { get; set; }
        public string routecategory_middle_east { get; set; }
        public string language_hebrew { get; set; }
        public string report_review_radio_desc_14_part_2 { get; set; }
        public string attractionscartalert_not_available { get; set; }
        public string restaurant_rr_caps_rating { get; set; }
        public string responsive_no_photo_content { get; set; }
        public string airm_all_reviews { get; set; }
        public string n_photos_plural { get; set; }
        public string report_review_radio_desc_14_part_1 { get; set; }
        public string sanitation_checklist_list_header_hotels { get; set; }
        public string ib_more_info { get; set; }
        public string CRITERIA_ANY { get; set; }
        public string hs_traveler_safety_title { get; set; }
        public string tags_category_tag_violates_animal_welfare_policy { get; set; }
        public string mobile_reviews_plural_uppercase_2 { get; set; }
        public string global_travel_notice_covid19 { get; set; }
        public string room_tip_colon_f4 { get; set; }
        public string airm_businessClass { get; set; }
        public string delete_confirmation_header_repost_1 { get; set; }
        public string favorite_review_travelertype_families { get; set; }
        public string attractionsfiltereddifficultymoderate { get; set; }
        public string photos_provided_by_2_1bed { get; set; }
        public string attractionsfilteredplusnmorelocationsv2 { get; set; }
        public string ib_share_booking_download_app { get; set; }
        public string iap_link_incorrect_outdated_broken { get; set; }
        public string cruise_review_type_of_trip { get; set; }
        public string dual_search_popular_destinations { get; set; }
        public string reviewed_by_title { get; set; }
        public string attractionsmore { get; set; }
        public string success_repost_video { get; set; }
        public string COE_lightbox_headline_updated { get; set; }
        public string cx_explicit_preferences_cta_interested_in { get; set; }
        public string routecategory_usa { get; set; }
        public string dual_search_recently_viewed_all_caps { get; set; }
        public string Search_reviews_248 { get; set; }
        public string Dashboard_HSBookingTools_ClickTypeEmail { get; set; }
        public string hotels_n_helpful_votes_plural { get; set; }
        public string trip_contains_profanity { get; set; }
        public string check_email_subheader { get; set; }
        public string common_Average { get; set; }
        public string Claim_badge_unclaimed_tooltip_1 { get; set; }
        public string nspexampleFormproductSizesmalllabel { get; set; }
        public string social_mobile_reason_for_sponsored { get; set; }
        public string select_trip_header { get; set; }
        public string attractions_see_all_tours_count_unicode { get; set; }
        public string trips_share_email_body_v2 { get; set; }
        public string relative_dates_yesterday_fffff175 { get; set; }
        public string n_contributions_plural { get; set; }
        public string social_Follow { get; set; }
        public string iap_not_personal_experience { get; set; }
        public string single_connection_reviewed_airline { get; set; }
        public string qa_guidelines_links { get; set; }
        public string memx_mw_gating_hybrid_title { get; set; }
        public string mobile_gate_signin_keep_planning { get; set; }
        public string repost_failure_message { get; set; }
        public string delete_confirmation_header_photo_0 { get; set; }
        public string attractions_community_content_cta_finish_your_review { get; set; }
        public string hr_ask_a_question { get; set; }
        public string m1_trips_unsave_error { get; set; }
        public string delete_confirmation_description_review_0 { get; set; }
        public string _10_off_tour_activity_v2 { get; set; }
        public string routecategory_central_america { get; set; }
        public string stat_modal_create_a_trip_v2 { get; set; }
        public string attractions_review_of_activity { get; set; }
        public string ttd_ar_featuresanimals_link { get; set; }
        public string common_Previous { get; set; }
        public string social_change_profile_photo { get; set; }
        public string social_unfollow { get; set; }
        public string routecategory_asia { get; set; }
        public string airm_nReviews { get; set; }
        public string captcha_50f { get; set; }
        public string attractions_free_cancellation { get; set; }
        public string NoticeHeader_1d63 { get; set; }
        public string post_video_typeahead_placeholder_text_search { get; set; }
        public string show_more_ffffe986 { get; set; }
        public string trips_error_general_default { get; set; }
        public string attractionsbookingcommon_n_youth { get; set; }
        public string language_french_ffffe66c { get; set; }
        public string my_bookings_headtext_fffff9b3 { get; set; }
        public string attractionreadmorereviewsonviatorpluralized { get; set; }
        public string tavrs_view_profile { get; set; }
        public string report_review_radio_desc_15_ver_1 { get; set; }
        public string attractionsbookingflagbest_seller { get; set; }
        public string post_a_video_modal_header { get; set; }
        public string language_german_ffffe66c { get; set; }
        public string sanitation_checklist_more_questions { get; set; }
        public string view_repost { get; set; }
        public string sanitation_checklist_list_header_restaurants { get; set; }
        public string global_nav_profile_my_business { get; set; }
        public string socialproof_friends_have_flown_with_airline { get; set; }
        public string member_event_on_forumpost_reply { get; set; }
        public string no_results_found { get; set; }
        public string member_event_reposted_review { get; set; }
        public string attractions_community_content_cta_write_a_review { get; set; }
        public string routecategory_north_africa { get; set; }
        public string iap_profile_problem_with_pic_lev2 { get; set; }
        public string post_photos_form_header { get; set; }
        public string cx_explicit_preferences_segment_partner { get; set; }
        public string create_trip_general_error_v2 { get; set; }
        public string cx_explicit_preferences_welcome_yes { get; set; }
        public string hr_community_qa_show_top_answer { get; set; }
        public string share_email_forumtopic { get; set; }
        public string Claim_badge_claimed_tooltip_body { get; set; }
        public string sng_michelin_year { get; set; }
        public string common_Search { get; set; }
        public string profile_joined_in { get; set; }
        public string tabs_reviews_fffff660 { get; set; }
        public string stat_modal_view_trip_v2 { get; set; }
        public string Disclaimer_Reviews_Control_Hamon_FR { get; set; }
        public string social_report_prof_err { get; set; }
        public string attractionscartitem_already_added_with_link { get; set; }
        public string hs_safety_filter { get; set; }
        public string locationinfo_fffffa56 { get; set; }
        public string locationinfo_fffffa57 { get; set; }
        public string iap_profile_username { get; set; }
        public string footer_ta_sites_v2 { get; set; }
        public string social_remove_tag { get; set; }
        public string qa_question_overlay_note_56a { get; set; }
        public string hr_overview_travelers_talk_about { get; set; }
        public string success_repost_trip { get; set; }
        public string m1_trips_save_success_stat_d2 { get; set; }
        public string qaa_form_placeholder_no_name { get; set; }
        public string member_event_on_question_with_date { get; set; }
        public string sng_award_michelin_plate { get; set; }
        public string qa_guidelines_relevant_visit { get; set; }
        public string delete_confirmation_description_photo_0 { get; set; }
        public string social_untag_yourself { get; set; }
        public string trips_email_share_collaborator_version { get; set; }
        public string language_turkish_13a4 { get; set; }
        public string iap_profile_problem_my_account { get; set; }
        public string cx_single_search_explore_tripadvisor { get; set; }
        public string linkify_removed_v2 { get; set; }
        public string absolute_dates_responded_caps { get; set; }
        public string cx_explicit_preferences_cta_family2 { get; set; }
        public string Date_of_stay { get; set; }
        public string iap_profile_report_from_inbox_lev2 { get; set; }
        public string soical_loading_error_2 { get; set; }
        public string userreview_25ed { get; set; }
        public string ds_award_michelin_two_star_label { get; set; }
        public string socialproof_see_their_activity { get; set; }
        public string attractionstype_and_count { get; set; }
        public string common_btn_cancel_ffffe209 { get; set; }
        public string trips_feed_trip_joined_v2 { get; set; }
        public string rental_cars { get; set; }
        public string tabs_photos_fffff660 { get; set; }
        public string cds_langname_da_159b { get; set; }
        public string common_Overview { get; set; }
        public string mobile_try_again { get; set; }
        public string review_show_more_button { get; set; }
        public string social_memberstats_followers { get; set; }
        public string qa_iap_label { get; set; }
        public string season_sep_nov_1cb3 { get; set; }
        public string social_repost { get; set; }
        public string social_Save { get; set; }
        public string social_label_Trending { get; set; }
        public string share_email_link { get; set; }
        public string n_videos_plural { get; set; }
        public string command_interests_screen { get; set; }
        public string attractions_booking_unavailable_on_tripadvisor { get; set; }
        public string qa_guidelines_forums_new_tab { get; set; }
        public string link_share_option_sms { get; set; }
        public string report_review_radio_12_ver_2 { get; set; }
        public string social_no_permission { get; set; }
        public string social_nCount_followers2 { get; set; }
        public string attractionsbookingcommon_n_senior { get; set; }
        public string socialproof_friends_visited_non_geo { get; set; }
        public string n_forum_posts_plural { get; set; }
        public string save_all_items { get; set; }
        public string mobile_back_8e0 { get; set; }
        public string typeAheadSearchFor_fffff81b { get; set; }
        public string trips_error_duplicate { get; set; }
        public string command_dates_screen_geo { get; set; }
        public string discover_ttd { get; set; }
        public string curated_shopping_detail_shopping_tips { get; set; }
        public string jfy { get; set; }
        public string cx_explicit_preferences_welcome_no { get; set; }
        public string attractionsfiltereddifficultyhard { get; set; }
        public string common_25f1 { get; set; }
        public string member_event_on_review_with_date { get; set; }
        public string userreviewbody_25ed { get; set; }
        public string cx_explicit_preferences_cta_traveling_friends { get; set; }
        public string hotels_favorite { get; set; }
        public string social_Helpful { get; set; }
        public string listing_detail_improve_this_listing_ffffeaf1 { get; set; }
        public string trips_collaborate_invite_email_subject { get; set; }
        public string attractionscollapse { get; set; }
        public string restaurants_michelin_view_more { get; set; }
        public string hr_tabs_overview_tab_fffff660 { get; set; }
        public string tch_booking_button_learn_more { get; set; }
        public string sanitation_checklist_covid19_travel_safe_v2 { get; set; }
        public string stat_modal_undo { get; set; }
        public string qa_guidelines_adhere_new_tab { get; set; }
        public string traveler_type { get; set; }
        public string member_event_reposted_photo { get; set; }
        public string airm_economy { get; set; }
        public string delete_confirmation_header_link_post_0 { get; set; }
        public string explain_why_management_response_violates_guidelines { get; set; }
        public string member_event_on_review { get; set; }
        public string Photoviewer_staffPhotoCaption { get; set; }
        public string common_Excellent { get; set; }
        public string member_event_on_location_topic { get; set; }
        public string restaurant_owners_visit_your_owner_mangement_center { get; set; }
        public string link_share_sms_checkthisout { get; set; }
        public string common_Poor { get; set; }
        public string social_Coming_soon { get; set; }
        public string success_repost_photo { get; set; }
        public string p13n_time_of_year { get; set; }
        public string attractionsbookingsectionitinerary { get; set; }
        public string mv_photos_from_everyone { get; set; }
        public string mobile_search_filter_clear_26e8 { get; set; }
        public string cx_single_search_explore_geo { get; set; }
        public string ip_view_profile_1cf1 { get; set; }
        public string relative_dates_days_fffff175 { get; set; }
        public string qa_get_quick_answers_56a { get; set; }
        public string season_mar_may_1cb3 { get; set; }
        public string attractionslanguages_offered_listand_x_more { get; set; }
        public string report_review_radio_9 { get; set; }
        public string Date_of_experience { get; set; }
        public string report_review_radio_8 { get; set; }
        public string m1_trips_my_saves_header { get; set; }
        public string cx_explicit_preferences_dates_header { get; set; }
        public string inbox_swipe_delete { get; set; }
        public string report_review_radio_1 { get; set; }
        public string cx_explicit_preferences_cta_subheader3 { get; set; }
        public string link_share_option_clipboard { get; set; }
        public string report_review_radio_3 { get; set; }
        public string new_trip_name_error_msg { get; set; }
        public string report_review_radio_2 { get; set; }
        public string report_review_radio_5 { get; set; }
        public string report_review_radio_4 { get; set; }
        public string report_review_radio_7 { get; set; }
        public string ratings_card_low_reviews_v2 { get; set; }
        public string report_review_radio_6 { get; set; }
        public string footer_disclaimer_line2 { get; set; }
        public string footer_disclaimer_line3 { get; set; }
        public string ppl_you_know { get; set; }
        public string footer_disclaimer_line1 { get; set; }
        public string delete_confirmation_header_post_0 { get; set; }
        public string attractionsbookingtour_grade_unavailable_for_pax_date { get; set; }
        public string ds_award_michelin_three_star_label { get; set; }
        public string trips_error_default_move_item { get; set; }
        public string attractions_booking_what_to_expect { get; set; }
        public string machine_translated_review_display_toggle { get; set; }
        public string link_share_share { get; set; }
        public string common_9bc { get; set; }
        public string curated_shopping_detail_branch_list_2 { get; set; }
        public string restaurants_contact_links_website { get; set; }
        public string mentions_profile_label_span_lower { get; set; }
        public string routecategory_southeast_asia { get; set; }
        public string management_photo { get; set; }
        public string attractionslanguages_offered_list { get; set; }
        public string iap_profile_report_from_post_lev2 { get; set; }
        public string terms_and_policy_links { get; set; }
        public string rs_manage_this_business_link { get; set; }
        public string common_Reviews { get; set; }
        public string share_email_photos { get; set; }
        public string mg2019_fbot_see_where_friends_traveled { get; set; }
        public string experiences_POI_list_see_related_experiences_button_v2 { get; set; }
        public string dmo_hdr_alerts { get; set; }
        public string restaurants_show_full_menu { get; set; }
        public string common_Readless { get; set; }
        public string mobile_here_is_a_place_i_found_8e0 { get; set; }
        public string curated_shopping_detail_access_map { get; set; }
        public string footer_get_app_v2 { get; set; }
        public string Travelers_Choice_POI_2 { get; set; }
        public string Travelers_Choice_POI_1 { get; set; }
        public string AAC_PRIVATE_TOUR { get; set; }
        public string social_nCount_following2 { get; set; }
        public string social_Saved { get; set; }
        public string Chinese_trad { get; set; }
        public string hr_community_qa_show_all_answers { get; set; }
        public string RCP_attribution_generic_restaurant_fffff20a { get; set; }
        public string ttd_ar_featuresanimals_violation_header { get; set; }
        public string footer_region { get; set; }
        public string mem_sign_in_now { get; set; }
        public string success_repost_review { get; set; }
        public string num_results_plural { get; set; }
        public string attractionsfilteredgroupsizelarge_v2 { get; set; }
        public string share_sms_link { get; set; }
        public string community_popular_mentions { get; set; }
        public string what_is_travelers_choice { get; set; }
        public string accommodation_dropdown_label { get; set; }
        public string report_review_redirect_5 { get; set; }
        public string report_review_redirect_6 { get; set; }
        public string report_review_redirect_3 { get; set; }
        public string Photoviewer_albumFilterHeader { get; set; }
        public string cx_explicit_preferences_welcome_header3 { get; set; }
        public string cx_explicit_preferences_segment_family { get; set; }
        public string reg_error_reload { get; set; }
        public string attractionsbookingcommon_n_adult { get; set; }
        public string mobile_gate_save_trip_on_a_map { get; set; }
        public string language_italian_ffffe66c { get; set; }
        public string language_japanese_ffffe66c { get; set; }
        public string iap_forums_spam { get; set; }
        public string OwnerResponse_filter_languages_1 { get; set; }
        public string report_review_redirect_7 { get; set; }
        public string routecategory_south_america { get; set; }
        public string delete_confirmation_header_video_0 { get; set; }
        public string social_loading_error_1 { get; set; }
        public string ttd_ar_featuresanimals_violation_body { get; set; }
        public string attractionscta_more_info { get; set; }
        public string social_follow_toast_message { get; set; }
        public string cx_explicit_preferences_profile_end_screen2 { get; set; }
        public string CTA_Review_Control_Hamon_FR { get; set; }
        public string qa_q_placeholder_restaurant_no_name { get; set; }
        public string homepage_war_button { get; set; }
        public string hr_community_qa_answer_question { get; set; }
        public string attractionsfiltereddestinations { get; set; }
        public string sanitation_checklist_disclaimer_text { get; set; }
        public string attractionsbookingtour_grade_unavailable_try_different { get; set; }
        public string reviews_and_more { get; set; }
        public string qa_q_placeholder_lo { get; set; }
        public string geetest_slide_to_verify { get; set; }
        public string social_n_contributions_plural { get; set; }
        public string favorite_review_travelertype_couples { get; set; }
        public string filter_ffffe84e { get; set; }
        public string footer_explore_v2 { get; set; }
        public string language_swedish_ffffe66c { get; set; }
        public string attractionsfilteredgroupsizesmall_v2 { get; set; }
        public string restaurant_rr_caps_cuisines { get; set; }
        public string locale_ar { get; set; }
        public string season_dec_feb_1cb3 { get; set; }
        public string tripadvisor_photo { get; set; }
        public string ugc_uploader_photo_v3 { get; set; }
        public string trips_error_default_update_comment { get; set; }
        public string attractions_checkout_abandonment_popup_avail_and_price_change { get; set; }
        public string attractionswhy_book_with_supplier { get; set; }
        public string trips_see_more_CTA { get; set; }
        public string common_less_capital_ffffe27f { get; set; }
        public string social_memberstats_contributions { get; set; }
        public string routecategory_trans_tasmin { get; set; }
        public string attractionssee_more_tours { get; set; }
        public string command_where_to_screen_v2 { get; set; }
        public string mtprovider_attribution_microsoft { get; set; }
        public string share_email_link_subject { get; set; }
        public string attractions_community_content_cta_post_a_photo { get; set; }
        public string userreview_92d { get; set; }
        public string report_review_redirect_2_part_2 { get; set; }
        public string report_review_redirect_2_part_1 { get; set; }
        public string social_report_ty2 { get; set; }
        public string mobile_gate_get_hotel_flight_alerts { get; set; }
        public string iap_trips_not_travel_related { get; set; }
        public string member_event_on_photo_with_date { get; set; }
        public string hsx_management_response_header { get; set; }
        public string iap_profile_problem_with_link { get; set; }
        public string sanitation_checklist_list_header_experiences { get; set; }
        public string userreview_92e { get; set; }
        public string restaurants_contact_links_call { get; set; }
        public string share_email_forumreply { get; set; }
        public string Sponsored_17e8 { get; set; }
        public string onboarding_social_brand_splash_get_started_cta { get; set; }
        public string aao_delete_question_msg_fffff375 { get; set; }
        public string cx_explicit_preferences_destination_subheader2 { get; set; }
        public string delete_confirmation_header_review_0 { get; set; }
        public string mem_settings { get; set; }
        public string baggage_fees_text { get; set; }
        public string see_more_room_tips_f4 { get; set; }
        public string mobile_ola_cabs { get; set; }
        public string attractionsbookingsectionimportant_info { get; set; }
        public string member_event_reposted_video { get; set; }
        public string n_Helpful_votes_plural { get; set; }
        public string common_Hotels { get; set; }
        public string common_Signin { get; set; }
        public string Claim_badge_claimed_status { get; set; }
        public string RCP_attribution_branded_fffff20a { get; set; }
        public string hrm_flyoutupsell_reviewcollection { get; set; }
        public string hr_community_tab_reviews { get; set; }
        public string p13n_reviews_no_results_with_query_and_filters_2 { get; set; }
        public string attractionsbookingsectionhighlights { get; set; }
        public string n_saves_plural { get; set; }
        public string Photoviewer_mgmtPhotoCaption_v2 { get; set; }
        public string common_ffffe1a7 { get; set; }
        public string restaurant_special_diets { get; set; }
        public string social_label_Member_liked_this { get; set; }
        public string trips_collaborate_invite_email_body_v2 { get; set; }
        public string Date_of_visit { get; set; }
        public string com_fyf_p2_011 { get; set; }
        public string common_Submit { get; set; }
        public string routecategory_africa { get; set; }
        public string language_english_ffffe66c { get; set; }
        public string n_helpful_votes_plural { get; set; }
        public string iap_low_quality_ffffe4e2 { get; set; }
        public string common_cap_more_16e9 { get; set; }
        public string mentions_profile_label_a { get; set; }
        public string rr_food_and_ambiance_title { get; set; }
        public string common_more_ffffe87d { get; set; }
        public string RCP_attribution_generic_attraction_fffff20a { get; set; }
        public string certificateOfExcellence_title { get; set; }
        public string trip_note_update_error { get; set; }
        public string restaurant_nav_overview { get; set; }
        public string delete_confirmation_description_repost_0 { get; set; }
        public string iap_forums_self_promotion { get; set; }
        public string qa_posting_guidelines { get; set; }
        public string locale_el { get; set; }
        public string Claim_badge_unclaimed_tooltip_2_CTA { get; set; }
        public string delete_confirmation_description_forum_post_0 { get; set; }
        public string review_back_to_top { get; set; }
        public string nspaccountyourExpertisefieldisTourGuidelabel { get; set; }
        public string related_activities { get; set; }
        public string cx_explicit_preferences_interests_header2 { get; set; }
        public string stat_modal_save_to_trip_v2 { get; set; }
        public string carousel_progress_numbers { get; set; }
        public string member_support_reviews { get; set; }
        public string price_range_caps { get; set; }
        public string link_share_email_subject { get; set; }
        public string hs_selected_filters { get; set; }
        public string link_share_option_email { get; set; }
        public string trip_type_sentence { get; set; }
        public string mtprovider_attribution_promt { get; set; }
        public string attractioncategorynamev426 { get; set; }
        public string trips_error_default_edit_trip { get; set; }
        public string airm_firstClass { get; set; }
        public string restaurant_nav_reviews { get; set; }
        public string hr_community_qa_answer_question_first { get; set; }
        public string trips_delete_trip_confirmation_text_v2 { get; set; }
        public string cx_explicit_preferences_profile_end_screen_no_name { get; set; }
        public string cx_explicit_preferences_profile_hometown_help2 { get; set; }
        public string common_Signout { get; set; }
        public string nearby_use_my_location { get; set; }
        public string iap_link_illegal_activity { get; set; }
        public string cx_explicit_preferences_cta_dates2 { get; set; }
        public string cx_explicit_preferences_cta_months2 { get; set; }
        public string qa_see_all_n_questions { get; set; }
        public string locale_fi { get; set; }
        public string attractions_operated_by { get; set; }
        public string share_email_reviews { get; set; }
        public string social_report_level3_2 { get; set; }
        public string social_report_level3_1 { get; set; }
        public string Propertys_Favorite_Review { get; set; }
        public string common_Flights { get; set; }
        public string common_closed_strong_2705 { get; set; }
        public string locale_id { get; set; }
        public string common_Cruises { get; set; }
        public string share_email_subject { get; set; }
        public string my_name_is { get; set; }
        public string rd_popularity_index_linked3 { get; set; }
        public string linkify_url_error { get; set; }
        public string iap_profile_unwanted_messages { get; set; }
        public string locale_hu { get; set; }
        public string rs_sales_lander2_features { get; set; }
        public string stat_modal_general_error { get; set; }
        public string share_email_link_attribution { get; set; }
        public string common_Verygood_fffffabd { get; set; }
        public string report_review_radio_desc_13_ver_2 { get; set; }
        public string member_event_on_tip { get; set; }
        public string attractionsfilterednotincluded { get; set; }
        public string routecategory_south_pacific { get; set; }
        public string Travelers_Choice_Botb_POI_1 { get; set; }
        public string cx_explicit_preferences_dates_flexible { get; set; }
        public string global_travel_notice_head { get; set; }
        public string nav_rs_premium_contact_support { get; set; }
        public string trips_share_email_subject { get; set; }
        public string Travelers_Choice_Botb_POI_2 { get; set; }
        public string mtprovider_attribution_asiaonline_d49 { get; set; }
        public string language_vietnamese_fffffd37 { get; set; }
        public string Travelers_Choice_Botb_POI_3 { get; set; }
        public string taking_safety_measures { get; set; }
        public string cruise_review_sail_date { get; set; }
        public string see_all_results_for { get; set; }
        public string ratings_card_low_reviews_short { get; set; }
        public string attractionsfilteredgroupsize { get; set; }
        public string language_czech { get; set; }
        public string curated_shopping_detail_store_directory { get; set; }
        public string locale_ko { get; set; }
        public string member_event_reposted_forumpost { get; set; }
        public string mobile_google_translation { get; set; }
        public string iap_forums_multiple_accounts_or_impersonation { get; set; }
        public string sanitation_checklist_updated { get; set; }
        public string ds_award_michelin_one_star_label { get; set; }
        public string member_event_reposted_photo_v2 { get; set; }
        public string common_Terrible { get; set; }
        public string iap_forums_duplicate { get; set; }
        public string mobile_questions_answers { get; set; }
        public string common_Travelerrating { get; set; }
        public string report_problem_ffffff85 { get; set; }
        public string report_review_radio_desc_12_part_2 { get; set; }
        public string trips_delete_trip_confirmation_header { get; set; }
        public string report_review_radio_desc_12_part_1 { get; set; }
        public string dual_search_ghost_im_going_to { get; set; }
        public string hrm_flyoutupsell_ownerresponse { get; set; }
        public string common_Read_more { get; set; }
        public string attractions_grades_show_options { get; set; }
        public string trips_error_default_add_item_comment_v2 { get; set; }
        public string restaurant_nav_photos { get; set; }
        public string app_download_url_secure { get; set; }
        public string trips_share_email_hey { get; set; }
        public string safetymore_info { get; set; }
        public string routecategory_domestic { get; set; }
        public string iap_participate_illegal_activity { get; set; }
        public string attractionsbookingcommon_n_traveler { get; set; }
        public string ur_rd_0charactermaximum { get; set; }
        public string cx_explicit_preferences_cta_header { get; set; }
        public string social_nowFollowing { get; set; }
        public string common_Thingstodo { get; set; }
        public string hr_connection_reviewed_single_see_said { get; set; }
        public string iap_profane_explicit_or_hate_speech { get; set; }
        public string post_video_location_typeahead_add_location { get; set; }
        public string social_destination_expert_for { get; set; }
        public string ttd_ar_featuresanimals_header { get; set; }
        public string shopping_cart_instant_confirmation { get; set; }
        public string common_Next { get; set; }
        public string attractions_kids_cost_less { get; set; }
        public string memx_gating_mw_generic_value { get; set; }
        public string tours_and_tickets_by_supplier { get; set; }
        public string link_uploader_header { get; set; }
        public string aao_delete_cancel_btn_fffff375 { get; set; }
        public string rd_hd_writeReview { get; set; }
        public string continue_sub_cta { get; set; }
        public string num_votes_plural { get; set; }
        public string cx_explicit_preferences_segment_solo { get; set; }
        public string relative_dates_today_fffff175 { get; set; }
        public string routecategory_russia { get; set; }
        public string dmo_photos_all_photos { get; set; }
        public string where_to_hint_text { get; set; }
        public string routecategory_canada { get; set; }
        public string stat_modal_removed_from_tripname { get; set; }
        public string member_event_on_topic_posting { get; set; }
        public string common_Populardestinations { get; set; }
        public string iap_profile_general_support_lev2 { get; set; }
        public string locale_no { get; set; }
        public string attractions_checkout_abandonment_popup_special_offer_title_unescaped { get; set; }
        public string social_untag_confirmation_message { get; set; }
        public string nspexampleFormproductSizelargelabel { get; set; }
        public string trips_save_CTA { get; set; }
        public string iap_forums_off_topic { get; set; }
        public string cx_explicit_preferences_profile_hometown { get; set; }
        public string report_review_radio_24 { get; set; }
        public string mx_nearby { get; set; }
        public string expiry_date_cta { get; set; }
        public string traveler_photo { get; set; }
        public string save_all_items_modal_header { get; set; }
        public string cruise_review_cabin_type { get; set; }
        public string discovery_sponsored_label { get; set; }
        public string explicit_preferences_account_screen_name { get; set; }
        public string coe_popup { get; set; }
        public string cx_explicit_preferences_edit_cta_header { get; set; }
        public string mw_common_menu_fffffd37 { get; set; }
        public string mobile_gate_signin_for_best_tripadvisor { get; set; }
        public string mentions_headline { get; set; }
        public string ONB_saves_educator_tap_the_heart_subhead { get; set; }
        public string mobile_uber_1ad3 { get; set; }
        public string cx_explicit_preferences_profile_name_help { get; set; }
        public string member_event_on_forumpost_question { get; set; }
        public string member_event_reposted_Trip { get; set; }
        public string footer_do_business_v2 { get; set; }
        public string locale_pl { get; set; }
        public string hrm_flyoutupsell_cta_starttrial { get; set; }
        public string common_Restaurants { get; set; }
        public string attractionsfiltereddifficulty { get; set; }
        public string sng_award_michelin_bib { get; set; }
        public string manage_business_tooltip { get; set; }
        public string exp_book_now_a { get; set; }
        public string cx_explicit_preferences_destination_header2 { get; set; }
        public string locale_th { get; set; }
        public string boost_social { get; set; }
        public string success_repost_photos { get; set; }
        public string attractions_merchandising_by { get; set; }
        public string tavrs_common_show_less { get; set; }
        public string social_Following { get; set; }
        public string attractions_community_content_cta_ask_a_question { get; set; }
        public string common_Close { get; set; }
        public string success_repost_link { get; set; }
        public string RCP_attribution_generic_airlines { get; set; }
        public string locale_sr { get; set; }
        public string ratings_card_zero_reviews_short { get; set; }
        public string full_view { get; set; }
        public string common_VeryGood { get; set; }
        public string n_reposts_plural { get; set; }
        public string attraction_product_social_proof_page_views_v3 { get; set; }
        public string aao_delete_answer_msg_fffff375 { get; set; }
        public string cx_explicit_preferences_end_body_nearby { get; set; }
        public string success_repost_forum { get; set; }
        public string qa_guidelines_objective { get; set; }
        public string social_report_level2_6b { get; set; }
        public string locale_sk { get; set; }
        public string Claim_badge_claimed_tooltip_CTA { get; set; }
        public string attractionslanguages_offered_listboldline_break { get; set; }
        public string mw_add_photo_ffffdfce { get; set; }
        public string Claim_badge_unclaimed_status { get; set; }
        public string share_email_videos { get; set; }
        public string locale_ru { get; set; }
        public string react_safe_q_and_a { get; set; }
        public string trips_inline_profanity_check { get; set; }
        public string attractions_checkout_abandonment_popup_continue_checkout { get; set; }
        public string attractions_checkout_abandonment_popup_view_details { get; set; }
        public string command_companion_v2 { get; set; }
        public string report_review_radio_desc_10 { get; set; }
        public string cx_explicit_preferences_edit_trip_details { get; set; }
        public string sanitation_checklist_email_operator { get; set; }
        public string curated_shopping_detail_top_sellers { get; set; }
        public string common_26ec { get; set; }
        public string mobile_gate_see_reviews_travelers_like_you { get; set; }
        public string report_review_radio_desc_16 { get; set; }
        public string report_review_radio_desc_19 { get; set; }
        public string report_review_radio_desc_17 { get; set; }
        public string common_Forums { get; set; }
        public string report_review_radio_desc_18 { get; set; }
        public string common_Allrightsreserved { get; set; }
        public string ar_btf_about_header { get; set; }
        public string trips_collaborate_invite_email_body_collaborator_version { get; set; }
        public string social_report_1 { get; set; }
        public string member_list_reposts { get; set; }
        public string relative_dates_one_week_fffff175 { get; set; }
        public string locale_uk { get; set; }
        public string covid19_safety_tab { get; set; }
        public string iap_profile_problem_with_pic { get; set; }
        public string mobile_reviews_plural { get; set; }
        public string cruise_review_destination { get; set; }
        public string stat_modal_saved_to_tripname_with_bold_v3 { get; set; }
        public string hotel_info_about_service { get; set; }
        public string link_share_link_copied { get; set; }
        public string report_review_redirect_4_ver_2 { get; set; }
        public string more_link { get; set; }
        public string create_trip_success_toast_with_bold { get; set; }
        public string routecategory_north_asia { get; set; }
        public string memx_gating_mw_attraction_values { get; set; }
        public string trips_edit_CTA { get; set; }
        public string cx_explicit_preferences_welcome_header_no_name2 { get; set; }
        public string feed_batched_photos_header_v2 { get; set; }
        public string routecategory_mexico { get; set; }
        public string common_Xof5bubbles { get; set; }
        public string ttd_ar_featuresanimals_button { get; set; }
        public string airm_cabin { get; set; }
        public string language_spanish_ffffe66c { get; set; }
        public string open_in_the_app { get; set; }
        public string cx_explicit_preferences_cta_partner2 { get; set; }
        public string social_n_followers_plural { get; set; }
        public string trips_error_default_edit_privacy { get; set; }
        public string footer_disclaimer_line1_no_country { get; set; }
        public string attractionsbookingcommon_n_infant { get; set; }
        public string free_cancel_ahead { get; set; }
        public string n_reviews_plural { get; set; }
        public string report_review_radio_desc_9 { get; set; }
        public string qaa_form_placeholder_product_no_name { get; set; }
        public string attraction_product_social_proof_total_bookings_v2 { get; set; }
        public string mv_photos_from_management { get; set; }
        public string iap_forums_profanity_sex_violence_crime_hate { get; set; }
        public string footer_disclaimer_line2_estimates { get; set; }
        public string Mobile_Meals { get; set; }
        public string userreviewbody_26ec { get; set; }
        public string userreviewbody_26eb { get; set; }
        public string userreview_disclaimer_lp_fffffa56 { get; set; }
        public string social_report_reason_photos2 { get; set; }
        public string footer_about_ta_v2 { get; set; }
        public string attractionsbookingcommon_n_child { get; set; }
        public string mw_js_positionPermissionDenied { get; set; }
        public string social_repost_on_tripadvisor { get; set; }
        public string attractions_checkout_abandonment_popup_header { get; set; }
        public string stat_modal_removed_from_tripname_with_bold_v3 { get; set; }
        public string favorite_review_travelertype_business { get; set; }
        public string triptype_desc_sentence { get; set; }
        public string Chinese_sim { get; set; }
        public string ratings_and_reviews { get; set; }
        public string tabs_tours_and_tickets { get; set; }
        public string memx_gating_mw_restaurant_values { get; set; }
        public string hrm_flyoutupsell_managementcenter { get; set; }
        public string mobile_uberCTA_1ad3 { get; set; }
        public string n_links_plural { get; set; }
        public string TAFlights_search_flights_text { get; set; }
        public string cx_explicit_preferences_profile_header3 { get; set; }
        public string social_report_level2_redirect { get; set; }
        public string iap_false_misleading_info { get; set; }
        public string mob_menu_header_title_147b { get; set; }
        public string attractionsseefewertime { get; set; }
        public string member_event_on_tip_with_date { get; set; }
        public string attraction_about { get; set; }
        public string sanitation_checklist_note_header { get; set; }
        public string member_event_on_video { get; set; }
        public string member_event_reposted_linkpost { get; set; }
        public string reviews_all_reviewers { get; set; }
        public string mv_photos_from_travelers { get; set; }
        public string common_TripAdvisor { get; set; }
        public string location_and_contact_overview { get; set; }
        public string see_all_hours { get; set; }
        public string iap_forums_personal_info { get; set; }
        public string common_alllangs_3dd { get; set; }
        public string ratings_card_zero_reviews { get; set; }
        public string m2_trips_detail_date_display { get; set; }
        public string attractions_checkout_abandonment_popup_special_offer_see_terms { get; set; }
        public string tavrs_common_show_more { get; set; }
        public string sanitation_checklist_write_a_review { get; set; }
        public string social_publish_date_Today { get; set; }
        public string mobile_nearby_af0 { get; set; }
        public string delete_confirmation_description_link_post_0 { get; set; }
        public string common_more_capital_ffffe27f { get; set; }
        public string attractions_other_booking_options { get; set; }
        public string common_NEW_1bd8 { get; set; }
        public string cx_explicit_preferences_interests_subheader3 { get; set; }
        public string trips_error_unsave { get; set; }
        public string airm_route { get; set; }
        public string machine_translated_google_disclaimer { get; set; }
        public string curated_shopping_detail_spotlight { get; set; }
        public string attractionsfiltereddifficultyeasy { get; set; }
        public string respond_review_cta { get; set; }
        public string cx_explicit_preferences_cta_date2 { get; set; }
        public string all_photos_parens { get; set; }
        public string season_jun_aug_1cb3 { get; set; }
        public string member_event_on_Trip { get; set; }
        public string reposted { get; set; }
        public string attractions_community_tab_questions { get; set; }
        public string common_OK { get; set; }
        public string trips_product_name { get; set; }
        public string common_No { get; set; }
        public string explicit_preferences_who_are_you_traveling_with_skip_button { get; set; }
        public string attractionsseemoretimes { get; set; }
        public string memx_mw_gating_cta { get; set; }
        public string exp_see_n_experiences_cap { get; set; }
        public string sanitation_checklist_ask_a_question { get; set; }
        public string attractionsmerchandisingfrompricewithautoresizespan2 { get; set; }
        public string social_Add_profile_photo { get; set; }
        public string dual_search_worldwide { get; set; }
        public string routecategory_international { get; set; }
        public string report_review_radio_10 { get; set; }
        public string cx_explicit_preferences_cta_friends3 { get; set; }
        public string report_review_radio_13 { get; set; }
        public string report_review_radio_11 { get; set; }
        public string Innkeepers_Favorite_Review { get; set; }
        public string report_review_radio_17 { get; set; }
        public string report_review_radio_18 { get; set; }
        public string report_review_radio_16 { get; set; }
        public string trips_error_default_add_note { get; set; }
        public string report_review_radio_19 { get; set; }
        public string cx_explicit_preferences_cta_traveling_solo { get; set; }
        public string favorite_review_travelertype_friends { get; set; }
        public string google_translation { get; set; }
        public string reg_back { get; set; }
        public string mentions_profile_label_span { get; set; }
        public string RCP_attribution_generic_hotel_fffff20a { get; set; }
        public string report_review_radio_20 { get; set; }
        public string report_review_radio_21 { get; set; }
        public string language_dutch_ffffe66c { get; set; }
    }

    public class Features
    {
        public bool ungate_sponsored_listing_clicks { get; set; }
        public bool prod_runtime_tracking { get; set; }
        public bool curated_shelves_preview { get; set; }
        public bool restaurants_detail_page_attribution_pixel { get; set; }
        public bool digital_turbine_high_intent { get; set; }
        public bool ml_hard_gate_model_v2_excl_hotels { get; set; }
        public bool trips_heart_icon { get; set; }
        public bool travel_advice { get; set; }
        public bool mw_hard_gate_ghost { get; set; }
        public bool social_follow_enabled { get; set; }
        public bool fbot_single_screen_onb { get; set; }
        public bool attractions_social_proof_total_bookings { get; set; }
        public bool attraction_supplier_grouped_tabs { get; set; }
        public bool home_lithium { get; set; }
        public bool enhanced_gate_google_one_tap_2pv_mw { get; set; }
        public bool safety_2_0_web_test_below_reviews { get; set; }
        public bool social_ugc_share { get; set; }
        public bool curated_shopping_quick_link { get; set; }
        public bool tc_2020_botb { get; set; }
        public bool trips_save_ugc { get; set; }
        public bool t11208_variant_a_curated_broad_interest_categories { get; set; }
        public bool attractions_apd_sold_out_message_with_additional_availability { get; set; }
        public bool social_mentions_above_the_fold { get; set; }
        public bool tc_1l_logo { get; set; }
        public bool react_tracking_impressions { get; set; }
        public bool post_signup_attr_promo_explicit_preferences_control { get; set; }
        public bool t11213_mip_2_account_screen { get; set; }
        public bool info_icons_over_question_icons { get; set; }
        public bool attractions_checkout_abandonment_pop_up { get; set; }
        public bool google_translate { get; set; }
        public bool ep_has_command_screen { get; set; }
        public bool account_screen_onb_reqlo { get; set; }
        public bool restaurants_attribution_pixel_clicks { get; set; }
        public bool rich_content_editor { get; set; }
        public bool seo_vacation_packages_servlet { get; set; }
        public bool fusion_lithium_hotels_list_page { get; set; }
        public bool hydrate_while_loading { get; set; }
        public bool ml_hard_gate_dt_v3_master { get; set; }
        public bool tourism_management_center { get; set; }
        public bool restaurant_list_consolidation { get; set; }
        public bool hr_mediaviewer_display_360_photos { get; set; }
        public bool consent_mgmt_enabled { get; set; }
        public bool h_defer_facebook_sdk { get; set; }
        public bool travel_advice_preview { get; set; }
        public bool ml_hard_gate_dt_v1_master { get; set; }
        public bool ml_hard_gate_dt_v2_master { get; set; }
        public bool facebook_onetap_mobile { get; set; }
        public bool hr_disable_cpm_ads { get; set; }
        public bool timed_refresh_after_15s { get; set; }
        public bool vr_broad_geo_list_redesign { get; set; }
        public bool restaurants_sponsored_attribution_pixel { get; set; }
        public bool answers_attractions { get; set; }
        public bool social_edit_enabled { get; set; }
        public bool social_profile_contribution_count_enabled { get; set; }
        public bool attractions_apd_social_proof_weekly_page_views { get; set; }
        public bool safety_2_0_web_test_above_reviews { get; set; }
        public bool cx_explicit_preferences_geopill { get; set; }
        public bool attraction_product_spotlight_zero_booking_fee { get; set; }
        public bool attractions_nonbookable_xsell_category_shelf { get; set; }
        public bool hrm_beta_full_story { get; set; }
        public bool restaurant_booking_click_ungates_all { get; set; }
        public bool cx_explicit_preferences_onboarding { get; set; }
        public bool saves_educator_explicit_preferences { get; set; }
        public bool attractions_social_proof_weekly_page_views { get; set; }
        public bool hr_mediaviewer_mas { get; set; }
        public bool update_photo_ui_on_grouping_tabs { get; set; }
        public bool t11216_mip_2_traditional_sign_up_ll { get; set; }
        public bool mw_unlock_bookable_restaurants { get; set; }
        public bool attraction_show_booking_option { get; set; }
        public bool trip_savers_modal { get; set; }
        public bool ep_has_command_screen_control { get; set; }
        public bool post_signup_attr_promo_explicit_preferences { get; set; }
        public bool fusion_detail_page_lithium { get; set; }
        public bool post_signup_attr_promo_masthead_join { get; set; }
        public bool fusion_lithium_attraction_products_list_page { get; set; }
        public bool rental_cars_winning_quick_link { get; set; }
        public bool apr_lithium_control { get; set; }
        public bool forum_home_lithium { get; set; }
        public bool hr_dark_green_icons { get; set; }
        public bool optimus { get; set; }
        public bool cx_explicit_preferences_scoped_home_cta { get; set; }
        public bool t11430_checkout_abandonment_pop_up_test_with_promo { get; set; }
        public bool attractions_apd_social_proof_total_bookings { get; set; }
        public bool restaurants_review_covid19_travel_safe_module { get; set; }
        public bool attractions_checkout_abandonment_pop_up_apds_check_availability { get; set; }
        public bool attractions_checkout_abandonment_pop_up_with_promo { get; set; }
        public bool ml_hard_gate_targeting_logic { get; set; }
        public bool show_foreign_member_profile { get; set; }
        public bool hard_gate_excl_disable_domain_direct { get; set; }
        public bool t11210_mip_variant_c { get; set; }
        public bool fusion_cta_copy_test { get; set; }
        public bool attraction_percentage_based_discount { get; set; }
        public bool ml_hard_gate_no_reqlo { get; set; }
        public bool cruise_better_by_sea { get; set; }
        public bool health_and_safety_review_alert_web { get; set; }
        public bool ungate_restaurant_booking_clicks { get; set; }
        public bool trips_pop_stat_modal { get; set; }
        public bool restaurants_claimed_badge { get; set; }
        public bool hr_defer_facebook_sdk { get; set; }
        public bool review_detail_hard_gate_master_dt { get; set; }
        public bool trips_skip_check_whitelist_public_trips { get; set; }
        public bool rubicon_header_bidding { get; set; }
        public bool restaurant_booking_click_ungates_single { get; set; }
        public bool sentryio_js { get; set; }
        public bool cx_brand_refresh_degreen { get; set; }
        public bool cx_explicit_preferences_scoped_home_cta_always_edit { get; set; }
        public bool restaurants_attribution_pixel_impressions { get; set; }
        public bool linkify_urls { get; set; }
        public bool trips_saves_heart { get; set; }
        public bool mobile_web { get; set; }
        public bool tourism_lithium { get; set; }
        public bool ml_hard_gate_master { get; set; }
        public bool social_likes_enabled { get; set; }
        public bool account_screen_onb_control { get; set; }
        public bool facebook_onetap_desktop { get; set; }
        public bool attractions_lithium_filtered { get; set; }
        public bool restaurants_unsponsored_attribution_pixel { get; set; }
        public bool bcom_partner_photos { get; set; }
        public bool mediaviewer_placement { get; set; }
        public bool cx_brand_refresh_header { get; set; }
        public bool media_preview_focal_point { get; set; }
        public bool cruise { get; set; }
        public bool attractions_ar_category_pivot_shelf { get; set; }
        public bool nearby_lithium { get; set; }
        public bool social_report_repost_iap_enabled { get; set; }
        public bool social_at_referencing_profile_links { get; set; }
        public bool ml_hard_gate_model_v2_reevaluate_on_page_view { get; set; }
        public bool qualtrics_surveys_any { get; set; }
        public bool attraction_product_carousel_new_filtered_a { get; set; }
        public bool t4b_management_center_full_story_sampled { get; set; }
        public bool ml_hard_gate_model_v2 { get; set; }
        public bool search_engine_referrer { get; set; }
        public bool ml_hard_gate_model_v1 { get; set; }
        public bool trips_bookmark { get; set; }
        public bool quicklinks_sorting_model { get; set; }
        public bool account_screen_onb { get; set; }
        public bool cx_explicit_preferences_onetap { get; set; }
        public bool dd_brand_refresh { get; set; }
        public bool saves_educator_control { get; set; }
        public bool trip_modal_home { get; set; }
        public bool health_notice_banner { get; set; }
        public bool t4b_management_center_full_story { get; set; }
        public bool t10349_facebook_onetap_w_value_copy { get; set; }
        public bool social_reposts { get; set; }
        public bool curated_trips_attractions { get; set; }
        public bool attractions_animal_button { get; set; }
        public bool navigation_to_scoped_home { get; set; }
        public bool articles_lithium { get; set; }
        public bool trips_2018_collab { get; set; }
        public bool select_restaurants_booking_click_ungates { get; set; }
        public bool home_location_prompt_master { get; set; }
        public bool dummy_cache_on_client { get; set; }
        public bool disable_reg_dialog_for_hardgate { get; set; }
        public bool hotel_review_is_thin_content { get; set; }
        public bool review_detail_hard_gate_dt_other_servlets { get; set; }
        public bool social_delete_enabled { get; set; }
        public bool mobile_fixed_ad { get; set; }
        public bool ml_hard_gate_model_v1_reevaluate_on_page_view { get; set; }
        public bool hr_lithium_atf_media_window_and_viewer { get; set; }
        public bool social_report_iap_enabled { get; set; }
        public bool account_merge { get; set; }
        public bool digital_turbine_max_flow { get; set; }
        public bool curated_trips_restaurants { get; set; }
        public bool articles_home_lithium { get; set; }
        public bool cx_brand_refresh_saves { get; set; }
        public bool ml_hard_gate_dt { get; set; }
        public bool fusion_lithium_attractions_list_page { get; set; }
        public bool appsflyer_deep_links { get; set; }
        public bool fusion_cta_color_test_a { get; set; }
        public bool t11209_mip_variant_b { get; set; }
        public bool attractions_browse_by_category_improved_photos { get; set; }
    }

    public class Apollocache
    {
        public Result result { get; set; }
        public string dataId { get; set; }
        public Query query { get; set; }
        public string variables { get; set; }
    }

    public class Result
    {
        public Coeaward[] coeAward { get; set; }
        public Locationkeyword[] locationKeywords { get; set; }
        public Snippet[][] snippets { get; set; }
        public Location8[] locations { get; set; }
    }

    public class Coeaward
    {
        public object[] locations { get; set; }
        public string __typename { get; set; }
    }

    public class Locationkeyword
    {
        public Keyword1[] keywords { get; set; }
        public string __typename { get; set; }
    }

    public class Keyword1
    {
        public int frequency { get; set; }
        public string keyword { get; set; }
        public int order { get; set; }
        public string __typename { get; set; }
    }

    public class Snippet
    {
        public int reviewId { get; set; }
        public string text { get; set; }
        public bool isMachineTranslated { get; set; }
        public string language { get; set; }
        public string publishedDate { get; set; }
        public Review1 review { get; set; }
        public Userprofile1 userProfile { get; set; }
        public string __typename { get; set; }
    }

    public class Review1
    {
        public int rating { get; set; }
        public string __typename { get; set; }
    }

    public class Userprofile1
    {
        public Avatar1 avatar { get; set; }
        public string __typename { get; set; }
    }

    public class Avatar1
    {
        public int id { get; set; }
        public Photosize4[] photoSizes { get; set; }
        public string __typename { get; set; }
    }

    public class Photosize4
    {
        public int height { get; set; }
        public bool isHorizontal { get; set; }
        public string url { get; set; }
        public int width { get; set; }
        public string __typename { get; set; }
    }

    public class Location8
    {
        public int locationId { get; set; }
        public string writeUserReviewUrl { get; set; }
        public string topicsUrl { get; set; }
        public string postPhotosUrl { get; set; }
        public int parentGeoId { get; set; }
        public object currentUserOwnerStatus { get; set; }
        public int topicCount { get; set; }
        public Album[] albums { get; set; }
        public Reviewsummary2 reviewSummary { get; set; }
        public string __typename { get; set; }
    }

    public class Reviewsummary2
    {
        public int count { get; set; }
        public int rating { get; set; }
        public string __typename { get; set; }
    }

    public class Album
    {
        public int totalCount { get; set; }
        public string __typename { get; set; }
    }

    public class Query
    {
        public string kind { get; set; }
        public Definition[] definitions { get; set; }
        public Loc loc { get; set; }
        public long __key { get; set; }
        public bool hasBeenTransformed { get; set; }
    }

    public class Loc
    {
        public int start { get; set; }
        public int end { get; set; }
        public Source source { get; set; }
    }

    public class Source
    {
        public string body { get; set; }
    }

    public class Definition
    {
        public string kind { get; set; }
        public string operation { get; set; }
        public Name name { get; set; }
        public Variabledefinition[] variableDefinitions { get; set; }
        public object[] directives { get; set; }
        public Selectionset selectionSet { get; set; }
    }

    public class Name
    {
        public string kind { get; set; }
        public string value { get; set; }
    }

    public class Selectionset
    {
        public string kind { get; set; }
        public Selection[] selections { get; set; }
    }

    public class Selection
    {
        public string kind { get; set; }
        public Name1 name { get; set; }
        public Argument2[] arguments { get; set; }
        public object[] directives { get; set; }
        public Selectionset1 selectionSet { get; set; }
        public Alias alias { get; set; }
    }

    public class Name1
    {
        public string kind { get; set; }
        public string value { get; set; }
    }

    public class Selectionset1
    {
        public string kind { get; set; }
        public Selection1[] selections { get; set; }
    }

    public class Selection1
    {
        public string kind { get; set; }
        public Name2 name { get; set; }
        public Argument[] arguments { get; set; }
        public Directive[] directives { get; set; }
        public Selectionset2 selectionSet { get; set; }
    }

    public class Name2
    {
        public string kind { get; set; }
        public string value { get; set; }
    }

    public class Selectionset2
    {
        public string kind { get; set; }
        public Selection2[] selections { get; set; }
    }

    public class Selection2
    {
        public string kind { get; set; }
        public Name3 name { get; set; }
        public object[] arguments { get; set; }
        public object[] directives { get; set; }
        public Selectionset3 selectionSet { get; set; }
    }

    public class Name3
    {
        public string kind { get; set; }
        public string value { get; set; }
    }

    public class Selectionset3
    {
        public string kind { get; set; }
        public Selection3[] selections { get; set; }
    }

    public class Selection3
    {
        public string kind { get; set; }
        public Name4 name { get; set; }
        public object[] arguments { get; set; }
        public object[] directives { get; set; }
        public Selectionset4 selectionSet { get; set; }
    }

    public class Name4
    {
        public string kind { get; set; }
        public string value { get; set; }
    }

    public class Selectionset4
    {
        public string kind { get; set; }
        public Selection4[] selections { get; set; }
    }

    public class Selection4
    {
        public string kind { get; set; }
        public Name5 name { get; set; }
        public object[] arguments { get; set; }
        public object[] directives { get; set; }
    }

    public class Name5
    {
        public string kind { get; set; }
        public string value { get; set; }
    }

    public class Argument
    {
        public string kind { get; set; }
        public Name6 name { get; set; }
        public Value2 value { get; set; }
    }

    public class Name6
    {
        public string kind { get; set; }
        public string value { get; set; }
    }

    public class Value2
    {
        public string kind { get; set; }
        public Value3[] values { get; set; }
    }

    public class Value3
    {
        public string kind { get; set; }
        public Name7 name { get; set; }
    }

    public class Name7
    {
        public string kind { get; set; }
        public string value { get; set; }
    }

    public class Directive
    {
        public string kind { get; set; }
        public Name8 name { get; set; }
        public Argument1[] arguments { get; set; }
    }

    public class Name8
    {
        public string kind { get; set; }
        public string value { get; set; }
    }

    public class Argument1
    {
        public string kind { get; set; }
        public Name9 name { get; set; }
        public Value4 value { get; set; }
    }

    public class Name9
    {
        public string kind { get; set; }
        public string value { get; set; }
    }

    public class Value4
    {
        public string kind { get; set; }
        public Name10 name { get; set; }
    }

    public class Name10
    {
        public string kind { get; set; }
        public string value { get; set; }
    }

    public class Alias
    {
        public string kind { get; set; }
        public string value { get; set; }
    }

    public class Argument2
    {
        public string kind { get; set; }
        public Name11 name { get; set; }
        public Value5 value { get; set; }
    }

    public class Name11
    {
        public string kind { get; set; }
        public string value { get; set; }
    }

    public class Value5
    {
        public string kind { get; set; }
        public Value6[] values { get; set; }
        public Name12 name { get; set; }
        public string value { get; set; }
    }

    public class Name12
    {
        public string kind { get; set; }
        public string value { get; set; }
    }

    public class Value6
    {
        public string kind { get; set; }
        public Field[] fields { get; set; }
        public Name13 name { get; set; }
    }

    public class Name13
    {
        public string kind { get; set; }
        public string value { get; set; }
    }

    public class Field
    {
        public string kind { get; set; }
        public Name14 name { get; set; }
        public Value7 value { get; set; }
    }

    public class Name14
    {
        public string kind { get; set; }
        public string value { get; set; }
    }

    public class Value7
    {
        public string kind { get; set; }
        public Value8[] values { get; set; }
    }

    public class Value8
    {
        public string kind { get; set; }
        public Name15 name { get; set; }
    }

    public class Name15
    {
        public string kind { get; set; }
        public string value { get; set; }
    }

    public class Variabledefinition
    {
        public string kind { get; set; }
        public Variable variable { get; set; }
        public Type type { get; set; }
        public object[] directives { get; set; }
        public Defaultvalue defaultValue { get; set; }
    }

    public class Variable
    {
        public string kind { get; set; }
        public Name16 name { get; set; }
    }

    public class Name16
    {
        public string kind { get; set; }
        public string value { get; set; }
    }

    public class Type
    {
        public string kind { get; set; }
        public Type1 type { get; set; }
        public Name18 name { get; set; }
    }

    public class Type1
    {
        public string kind { get; set; }
        public Name17 name { get; set; }
    }

    public class Name17
    {
        public string kind { get; set; }
        public string value { get; set; }
    }

    public class Name18
    {
        public string kind { get; set; }
        public string value { get; set; }
    }

    public class Defaultvalue
    {
        public string kind { get; set; }
        public string value { get; set; }
    }

    public class Render
    {
        public string id { get; set; }
        public Props props { get; set; }
        public string package { get; set; }
    }

    public class Props
    {
    }

    public class Hydration
    {
        public string id { get; set; }
        public Props1 props { get; set; }
        public string package { get; set; }
    }

    public class Props1
    {
        public string useResponsiveContainer { get; set; }
        public string withMargin { get; set; }
        public string size { get; set; }
        public string position { get; set; }
        public string reserveHeight { get; set; }
    }

}
