using Abstractions.Domain;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeConfect.Domain.Entities
{
    [Table(nameof(Product))]
    public class Product : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// Срок хранения.
        /// </summary>
        public string BestBefore { get; set; }
    }
}
