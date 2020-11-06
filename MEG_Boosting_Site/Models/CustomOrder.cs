using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace MEG_Boosting_Site.Models
{
    public class CustomOrder
    {
        public CustomOrder(){}
        
        // Unique identifier for the product 
        public int Id { get; set; }
        
        // A name for the specific service, for example: WoWRetailGladiator
        public string Name { get; set; }
        
        // Details about the service
        public string Details { get; set; }
        
        public ApplicationUser ApplicationUser { get; set; }
    }
}