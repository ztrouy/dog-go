using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DogGo.Models
{
    public class Walk
    {
        public int Id { get; set; }
        
        [DisplayName("Dog")]
        public int DogId { get; set; }
        
        public Dog Dog { get; set; }
        
        [DisplayName("Walker")]
        public int WalkerId {get; set; }
        
        public Walker Walker { get; set;}
        
        public int Duration { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Date { get; set; }
    }
}