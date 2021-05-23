using System;
using System.Collections.Generic;

#nullable disable

namespace Dao.Entities
{
    public partial class Question
    {
        public Question()
        {
            Answers = new HashSet<Answer>();
        }

        public long Id { get; set; }
        public string Content { get; set; }
        public long UserId { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }
    }
}
