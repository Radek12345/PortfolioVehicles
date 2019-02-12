using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PortfolioVehicles.API.Core.Models
{
    [Table("Makes")]
    public class Make
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public ICollection<VehicleModel> Models { get; set; } = new Collection<VehicleModel>(); 
    }
}