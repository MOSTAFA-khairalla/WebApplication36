using System.ComponentModel.DataAnnotations;

namespace WebApplication36.Data
{
    public class Entrant
    {
        [Key]
        public int GroupId { get; set; }
        public string CategoryName { get; set; }
        public string EntrantName { get; set; }
        public string EntrantDescription { get; set; }
        public string EntrantPhotoVideoURL { get; set; }
        public string EntrantFacebookPageUrl { get; set; }
        public string EntrantTwitterHandle { get; set; }
        public string EntrantInstagramHandle { get; set; }
        public string EntrantYouTubeChannelUrl { get; set; }
        public string EntrantFullAddress { get; set; }
        public string EntrantGooglePlaceId { get; set; }
        public string EntrantPhoneNumber { get; set; }
        public string EntrantWebsiteUrl { get; set; }
        public int NumberOfWriteIns { get; set; }
        public int NumberOfVotes { get; set; }
        public string Status { get; set; }


    }
}
