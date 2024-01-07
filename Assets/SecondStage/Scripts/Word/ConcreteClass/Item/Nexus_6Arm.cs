using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
///Nexus-6型手臂
/// </summary>
class Nexus_6Arm : AbstractItems
{
    public override void Awake()
    {
        base.Awake();
        itemID = 12;
        wordName = "Nexus-6型手臂";
        bookName = BookNameEnum.ElectronicGoal;
        description = "加7攻击";
        holdEnum = HoldEnum.handDouble;
        VoiceEnum = MaterialVoiceEnum.Meat;

        rarity = 3;
    }

    public override void UseItem(AbstractCharacter chara)
    {
        base.UseItem(chara);
        chara.atk += 7;

    }

    public override void UseVerb()
    {
        base.UseVerb();
    }

    public override void End()
    {
        base.End();
        aim.atk -= 7;
    }
}
