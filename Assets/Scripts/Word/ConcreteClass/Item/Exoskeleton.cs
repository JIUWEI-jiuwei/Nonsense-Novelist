using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
///外骨骼
/// </summary>
class Exoskeleton : AbstractItems
{
    public override void Awake()
    {
        base.Awake();
        itemID = 17;
        wordName = "外骨骼";
        bookName = BookNameEnum.PHXTwist;
        description = "加3防御，加快攻速";
        holdEnum = HoldEnum.clothes;
        VoiceEnum = MaterialVoiceEnum.Meat;

        rarity = 1;
    }

    public override void UseItem(AbstractCharacter chara)
    {
        base.UseItem(chara);
        chara.def += 3;
        chara.attackInterval -= 0.2f;
    }

    public override void UseVerb()
    {
        base.UseVerb();
    }

    public override void End()
    {
        base.End();
        aim.def -= 3;
        aim.attackInterval += 0.2f;
    }
}
