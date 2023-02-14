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
        description = "一种已经停产的强大机械臂，提升10点攻击，10%暴击几率。";
        holdEnum = HoldEnum.handDouble;
        VoiceEnum = MaterialVoiceEnum.Meat;

        rarity = 3;
    }

    public override void UseItems(AbstractCharacter chara)
    {
        base.UseItems(chara);
        chara.atk += 7;

    }

    public override void UseVerbs()
    {
        base.UseVerbs();
    }

    public override void End()
    {
        base.End();
        aim.atk -= 7;
    }
}
