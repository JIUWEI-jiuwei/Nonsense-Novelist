using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ����Ч��
/// </summary>
class SpecialMode : AbstractSkillMode
{
    public void Awake()
    {
        skillModeID = 4;
        skillModeName = "��������״̬";
    }
    public override void UseMode(AbstractCharacter useCharacter, float value, AbstractCharacter aimCharacter)
    {
    }
}
