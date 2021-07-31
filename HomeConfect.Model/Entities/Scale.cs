using Abstractions;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeConfect.Domain
{
    [Table(nameof(Scale))]
    public class Scale : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
