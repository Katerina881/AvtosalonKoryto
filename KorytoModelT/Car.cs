using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace KorytoModel
{
    [DataContract]
    public class Car
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        [Required]
        public string CarName { get; set; }

        [Required]
        [DataMember]
        public decimal Price { get; set; }

        [Required]
        [DataMember]
        public int Year { get; set; }

        [ForeignKey("CarId")]
        public virtual List<CarDetail> CarDetails { get; set; }

        [ForeignKey("CarId")]
        public virtual List<OrderCar> OrderCars { get; set; }
    }
}
