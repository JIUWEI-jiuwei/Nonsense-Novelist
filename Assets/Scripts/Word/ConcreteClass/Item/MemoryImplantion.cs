using System.Collections;
using System.Collections.Generic;
using UnityEngine;
class MemoryImplantion : AbstractItems
{
    public override void Awake()
    {
        itemID = 13;
        wordName = "被植入的记忆";
        bookName = BookNameEnum.ElectronicGoal;
        description = "一种已经停产的强大机械臂，提升10点攻击，10%暴击几率。";
        holdEnum = HoldEnum.handDouble;
        VoiceEnum = MaterialVoiceEnum.Meat;

        rarity = 1;
    }

    public override void UseItems(AbstractCharacter chara)
    {
        base.UseItems(chara);
        chara.psy-= chara.psy * 0.15f;
        chara.san-= chara.san * 0.15f;
    }

    public override void UseVerbs()
    {
        base.UseVerbs();
    }

    public override void End()
    {
        base.End();
    }
}
