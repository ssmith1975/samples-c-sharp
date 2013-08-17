using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcAuction.Models
{
    public class Auction
    {
        [Required]
        public long Id {get; set;}

        
        [Required]
        [DataType(DataType.Text)]
        public string Category {get; set;}

        [Required]
        [DataType(DataType.Text)]
        [StringLength(maximumLength:200, MinimumLength=5)]
        public string Title {get; set;}

        [DataType(DataType.MultilineText)]
        [Display(Name = "Auction Description")]
        public string Description {get; set;}

        [DataType(DataType.Url)]
        [Display(Name = "Image Url")]
        public string ImageUrl {get; set;}

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Start Time")]
        public DateTime StartTime {get; set;}

        [DataType(DataType.DateTime)]
        [Display(Name = "End Time")]
        public DateTime EndTime {get; set;}

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Starting Price")]
        public decimal StartPrice {get; set;}

        [DataType(DataType.Currency)]
        [Display(Name = "Current Bid Price")]
        public decimal? CurrentPrice {get; set;}

        public virtual Collection<Bid>Bids {get; set;}


        public Auction(){
            Bids = new Collection<Bid>();
        }

        public int BidCount
        {
            get {return Bids.Count;}
        }
    }
}