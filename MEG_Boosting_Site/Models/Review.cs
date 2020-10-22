using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MEG_Boosting_Site.Models
{
    public class Review
    {
        public Review()
        {
            Time = DateTime.Now.ToString("dd.MM.yyyy");
        }
        
        public int Id { get; set; }
        
        [Required, StringLength(100), DisplayName("Title")]
        public string Title { get; set; }
        
        [Required, StringLength(5000), DisplayName("Content")]
        public string Content { get; set; }
        
        [Required, DataType(DataType.DateTime)]
        public string Time { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

    }
}