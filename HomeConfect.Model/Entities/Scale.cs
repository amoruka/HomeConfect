using Abstractions.Domain;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeConfect.Domain.Entities
{
    [Table(nameof(Scale))]
    public class Scale : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
