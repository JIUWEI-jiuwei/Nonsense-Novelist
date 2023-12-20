using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 名词：先知的头颅
/// </summary>
class XianZhiHead : AbstractItems
{
    public override void Awake()
    {
        base.Awake();
        itemID = 8;
        wordName = "先知的头颅";
        bookName = BookNameEnum.Salome;
        description = "精神+30%，意志-30%";
        VoiceEnum = MaterialVoiceEnum.Ceram;
        rarity = 2;
    }

    public override void UseItem(AbstractCharacter chara)
    {
        base.UseItem(chara);
        chara.psyMul += 0.3f;
        chara.sanMul -= 0.3f;
    }

    public override void UseVerb()
    {
        base.UseVerb();
        
    }

    public override void End()
    {
        base.End();
        aim.psyMul -= 0.3f;
        aim.sanMul += 0.3f;
    }
}
