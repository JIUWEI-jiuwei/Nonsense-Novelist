using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class ChangePSYMode : AbstractSkillMode
{
    public ChangePSYMode()
    {
        skillModeID = 5;
        skillModeName = "改变精神力";
    }
    public override void UseMode(int value, AbstractCharacter character)
    {
        character.psy += value;
    }
}
