using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.Domain.Entities
{
    public class DiaryPage : BaseEntity<int>
    {
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
