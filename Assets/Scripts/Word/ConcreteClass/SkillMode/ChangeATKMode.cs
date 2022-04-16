using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class ChangeATKMode : AbstractSkillMode
{
    public ChangeATKMode()
    {
        skillModeID = 3;
        skillModeName = "��������";
    }
    public override void UseMode(int value, AbstractCharacter character)
    {
        character.atk+=value;
        
    }
}
