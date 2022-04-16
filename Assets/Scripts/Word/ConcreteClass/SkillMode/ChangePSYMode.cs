using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class ChangePSYMode : AbstractSkillMode
{
    public ChangePSYMode()
    {
        skillModeID = 5;
        skillModeName = "�ı侫����";
    }
    public override void UseMode(int value, AbstractCharacter character)
    {
        character.psy += value;
    }
}
