using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnimalFarm.Models
{
    [Table("animals")]
    public partial class Animal : IEntity
    {
        // Referencing the id insite IEntity, since the table will (in this case) have an ID of Id.
        // We have to tell Entity Framework that this Id is the id we want to use, and it has to be get - set.
        [Key]
        public new int Id { get; set; }
        public string animalName { get; set; }
        public string animalImage { get; set; }
    }
}