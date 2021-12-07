using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.Domain.Entities
{
    public class BaseEntity<TId> // TId Representa um objeto que fornece um Id único.
    {
        public int Id { get; protected set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
