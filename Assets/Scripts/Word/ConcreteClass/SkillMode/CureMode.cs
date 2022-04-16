using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class CureMode : AbstractSkillMode
{
    public CureMode()
    {
        skillModeID = 1;
        skillModeName = "÷Œ¡∆ººƒ‹";
    }
    public override void UseMode(int value, AbstractCharacter character)
    {
        character.hp+=value;
    }
}
