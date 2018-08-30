using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AprendeNetCore2.Application.Models
{

    public class PageInfo
    {
        public int totalResults { get; set; }
        public int resultsPerPage { get; set; }
    }

    public class Default
    {
        public string url { get; set; }
    }

    public class Medium
    {
        public string url { get; set; }
    }

    public class High
    {
        public string url { get; set; }
    }

    public class Thumbnails
    {
        public Default @default { get; set; }
        public Medium medium { get; set; }
        public High high { get; set; }
    }

    public class Localized
    {
        public string title { get; set; }
        public string description { get; set; }
    }

    public class Snippet
    {
        public string title { get; set; }
        public string description { get; set; }
        public string customUrl { get; set; }
        public DateTime publishedAt { get; set; }
        public Thumbnails thumbnails { get; set; }
        public string defaultLanguage { get; set; }
        public Localized localized { get; set; }
        public string country { get; set; }
    }

    public class RelatedPlaylists
    {
        public string uploads { get; set; }
        public string watchHistory { get; set; }
        public string watchLater { get; set; }
    }

    public class ContentDetails
    {
        public RelatedPlaylists relatedPlaylists { get; set; }
    }

    public class Statistics
    {
        public string viewCount { get; set; }
        public string commentCount { get; set; }
        public string subscriberCount { get; set; }
        public bool hiddenSubscriberCount { get; set; }
        public string videoCount { get; set; }
    }

    public class TopicDetails
    {
        public List<string> topicIds { get; set; }
        public List<string> topicCategories { get; set; }
    }

    public class Channel
    {
        public string title { get; set; }
        public string description { get; set; }
        public string keywords { get; set; }
        public string defaultTab { get; set; }
        public string trackingAnalyticsAccountId { get; set; }
        public bool showRelatedChannels { get; set; }
        public bool showBrowseView { get; set; }
        public string featuredChannelsTitle { get; set; }
        public List<string> featuredChannelsUrls { get; set; }
        public string unsubscribedTrailer { get; set; }
        public string profileColor { get; set; }
        public string defaultLanguage { get; set; }
        public string country { get; set; }
    }

    public class Image
    {
        public string bannerImageUrl { get; set; }
        public string bannerMobileImageUrl { get; set; }
        public string bannerTabletLowImageUrl { get; set; }
        public string bannerTabletImageUrl { get; set; }
        public string bannerTabletHdImageUrl { get; set; }
        public string bannerTabletExtraHdImageUrl { get; set; }
        public string bannerMobileLowImageUrl { get; set; }
        public string bannerMobileMediumHdImageUrl { get; set; }
        public string bannerMobileHdImageUrl { get; set; }
        public string bannerMobileExtraHdImageUrl { get; set; }
        public string bannerTvImageUrl { get; set; }
        public string bannerTvLowImageUrl { get; set; }
        public string bannerTvMediumImageUrl { get; set; }
        public string bannerTvHighImageUrl { get; set; }
    }

    public class Hint
    {
        public string property { get; set; }
        public string value { get; set; }
    }

    public class BrandingSettings
    {
        public Channel channel { get; set; }
        public Image image { get; set; }
        public List<Hint> hints { get; set; }
    }

    public class Item
    {
        public string kind { get; set; }
        public string etag { get; set; }
        public string id { get; set; }
        public Snippet snippet { get; set; }
        public ContentDetails contentDetails { get; set; }
        public Statistics statistics { get; set; }
        public TopicDetails topicDetails { get; set; }
        public BrandingSettings brandingSettings { get; set; }
    }

    public class Youtube
    {
        public string kind { get; set; }
        public string etag { get; set; }
        public PageInfo pageInfo { get; set; }
        public List<Item> items { get; set; }
    }
}
