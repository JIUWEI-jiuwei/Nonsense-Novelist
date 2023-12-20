using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 名词：被植入的记忆
/// </summary>
class BeiZhiRuDeJiYi : AbstractItems
{
    public override void Awake()
    {
        base.Awake();
        itemID = 14;
        wordName = "被植入的记忆";
        bookName = BookNameEnum.ElectronicGoal;
        description = "精神-15%，意志-15%，获得改造";
        VoiceEnum = MaterialVoiceEnum.Meat;

        rarity = 1;
    }

    public override void UseItem(AbstractCharacter chara)
    {
        base.UseItem(chara);
        chara.psyMul -= 0.15f;
        chara.sanMul -= 0.15f;
    }

    public override void UseVerb()
    {
        base.UseVerb();
    }

    public override void End()
    {
        base.End();
        aim.psyMul += 0.15f;
        aim.sanMul += 0.15f;
    }
}
