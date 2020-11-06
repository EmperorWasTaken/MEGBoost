using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace MEG_Boosting_Site.Models
{
    public class CustomOrder
    {
        
        public CustomOrder()
        {
            Time = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }
        
        // Unique identifier for the product 
        public int Id { get; set; }
        
        // A name for the specific service, for example: WoWRetailGladiator
        [Required, StringLength(50), DisplayName("Name")]
        public string Name { get; set; }
        
        // Details about the service
        [Required, StringLength(5000), DisplayName("Details")]
        public string Details { get; set; }
        
        // Sets date and time
        [Required, DataType(DataType.DateTime)]
        public string Time { get; set; }
        
        
        public ApplicationUser ApplicationUser { get; set; }
    }
}