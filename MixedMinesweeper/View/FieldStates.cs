using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MixedMinesweeper.View
{
    public enum FieldStates : int
    {
        Covered = 0,
        RedFlag = 1,
        BlueFlag = 2,
        GreenFlag = 3,
        YellowFlag = 4,
        QuestioMark = 5,
        Uncoverd = 6
    }
}
