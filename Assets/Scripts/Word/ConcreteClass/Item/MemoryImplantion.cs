using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 被植入的记忆
/// </summary>
class MemoryImplantion : AbstractItems
{
    public override void Awake()
    {
        base.Awake();
        itemID = 13;
        wordName = "被植入的记忆";
        bookName = BookNameEnum.ElectronicGoal;
        description = "减15%精神与意志";
        holdEnum = HoldEnum.handDouble;
        VoiceEnum = MaterialVoiceEnum.Meat;

        rarity = 1;
    }

    public override void UseItem(AbstractCharacter chara)
    {
        base.UseItem(chara);
        chara.psy-= chara.psy * 0.15f;
        chara.san-= chara.san * 0.15f;
    }

    public override void UseVerb()
    {
        base.UseVerb();
    }

    public override void End()
    {
        base.End();
    }
}
