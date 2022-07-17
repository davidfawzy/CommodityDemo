using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AA.CommoditiesDashboard.Api.Models
{
    [Table("Commodity")]
    public class Commodity
    {

        [Key]
        public int Id { get; set; }
        public int ModelId { get; set; }
        public string  Name { get; set; }
       
    }
}
 
 