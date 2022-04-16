using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class ChangeDEFMode : AbstractSkillMode
{
    public ChangeDEFMode()
    {
        skillModeID = 4;
        skillModeName = "ÌáÉý·ÀÓù";
    }
    public override void UseMode(int value, AbstractCharacter character)
    {
        character.def+=value;   
    }
}
