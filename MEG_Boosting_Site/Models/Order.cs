using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MEG_Boosting_Site.Models
{
    public class Order
    {
        public Order()
        {
            Time = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }
        
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        
        public string Server { get; set; }
        [Required]
        public string CurrentRank { get; set; }
        
        public string CurrentTier { get; set; }
        
        public string BoostedRank { get; set; }
        
        public string BoostedTier { get; set; }
        [Required]
        public double Price { get; set; }
        
        public int Wins { get; set; }
        
        public bool Duo { get; set; }
        
        // Sets date and time
        [Required, DataType(DataType.DateTime)]
        public string Time { get; set; }
        
        public ApplicationUser ApplicationUser { get; set; }
        
        public string Description { get; set; }
        
        public string Platform { get; set; }
    }
    
    
}