using System;
using System.Collections.Generic;

#nullable disable

namespace Dao.Entities
{
    public partial class Answer
    {
        public long Id { get; set; }
        public string Content { get; set; }
        public long QuestionId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public long UserId { get; set; }

        public virtual Question Question { get; set; }
    }
}
