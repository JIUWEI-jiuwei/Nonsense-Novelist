using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 先知的头颅
/// </summary>
class XianZhiHead : AbstractItems
{
    public override void Awake()
    {
        base.Awake();
        itemID = 7;
        wordName = "先知的头颅";
        bookName = BookNameEnum.Salome;
        description = "一枚熠熠生辉的宝石，提升7点精神，增强暴击倍数。";
        holdEnum = HoldEnum.handSingle; 
        VoiceEnum = MaterialVoiceEnum.Ceram;
        rarity = 2;
    }

    float recordPsy, recordSan;
    public override void UseItems(AbstractCharacter chara)
    {
        base.UseItems(chara);
        recordPsy = chara.psy * 0.15f;
        recordSan = chara.san * 0.1f;
        chara.psy += recordPsy;
        chara.san -=recordSan;
    }

    public override void UseVerbs()
    {
        base.UseVerbs();
        
    }

    public override void End()
    {
        base.End();
        aim.psy -= recordPsy;
        aim.san += recordSan;
    }
}
