using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.Domain.Enumerables
{
    public enum MoodSwingEnum
    {
        [Description("Happy")]
        Happy = 1,
        [Description("Up")]
        Up = 2,
        [Description("Ok")]
        Ok = 3,
        [Description("Down")]
        Down = 4,
        [Description("Sad")]
        Sad = 5

    }
}
