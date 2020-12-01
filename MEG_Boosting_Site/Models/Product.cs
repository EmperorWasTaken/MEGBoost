namespace MEG_Boosting_Site.Models
{
    public class Product
    {
        public Product()
        {
            BestSeller = false;
        }

        // Unique identifier for the product 
        public int Id { get; set; }

        public bool BestSeller { get; set; }
        
        // What type of product is this? WoWRetail, WoWClassic, Overwatch, LoL, CSGO
        // R1, R2, M1, M2, M3, DM1, DM2, Custom
        public string Service { get; set; }
        
        // A name for the specific service, for example: WoWRetailGladiator
        public string Name { get; set; }
        
        // Details about the service
        public string Details { get; set; }
        
        // A picture for the boost
        public string Image { get; set; }
        
        // The price of the service. 
        public decimal Price { get; set; }
    }
}