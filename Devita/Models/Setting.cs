using System.ComponentModel.DataAnnotations;

namespace Devita.Models
{
    public class Setting
    {
        public int Id { get; set; }
        [StringLength(maximumLength:30)]
        public string HeaderLogo { get; set; }
        [StringLength(maximumLength:30)]
        public string SupportPhone { get; set; }
        [StringLength(maximumLength:40)]
        public string ContactPhone { get; set; }
        [StringLength(maximumLength: 50)]
        public string Address { get; set; }
        [StringLength(maximumLength: 50)]
        public string Email { get; set; }
        [StringLength(maximumLength: 100)]
        public string OpeningTimeF { get; set; }
        [StringLength(maximumLength: 100)]
        public string OpeningTimeS { get; set; }
        [StringLength(maximumLength: 100)]
        public string FooterTitle { get; set; }
        [StringLength(maximumLength: 30)]
        public string AboutTitle { get; set; }
        [StringLength(maximumLength: 250)]
        public string AboutDescF { get; set; }
        [StringLength(maximumLength: 250)]
        public string AboutDescS { get; set; }
        [StringLength(maximumLength: 20)]
        public string AboutDescBtnTxt { get; set; }
        [StringLength(maximumLength: 20)]
        public string AboutImg { get; set; }
        [StringLength(maximumLength: 50)]
        public string ConnectTitle { get; set; }
        [StringLength(maximumLength: 150)]
        public string ConnectSubtitle { get; set; }
        public int ConnectPrice { get; set; }
        [StringLength(maximumLength: 20)]
        public string ConnectBtnTxt { get; set; }
        [StringLength(maximumLength: 20)]
        public string ConnectBgImg { get; set; }
        [StringLength(maximumLength: 20)]
        public string NewsLetterIcon { get; set; }
        [StringLength(maximumLength: 30)]
        public string NewsLetterTitle { get; set; }
        [StringLength(maximumLength: 30)]
        public string NewsLetterSubtitle { get; set; }
        [StringLength(maximumLength: 30)]
        public string ShopUpPromotingImg { get; set; }



    }
}
