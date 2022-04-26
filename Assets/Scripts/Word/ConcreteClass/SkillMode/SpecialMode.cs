using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ÌØÊâĞ§¹û
/// </summary>
class SpecialMode : AbstractSkillMode
{
    public void Awake()
    {
        skillModeID = 4;
        skillModeName = "¸³Óè×´Ì¬";
    }
    public override void UseMode(int value, AbstractCharacter character)
    {
    }
}
