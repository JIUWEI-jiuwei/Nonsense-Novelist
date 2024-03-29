using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 荷鲁斯之眼
/// </summary>
class HorusEyes : AbstractItems
{
    public override void Awake()
    {
        base.Awake();
        itemID = 6;
        wordName = "荷鲁斯之眼";
        bookName = BookNameEnum.EgyptMyth;
        description = "加5攻击";
        holdEnum = HoldEnum.handSingle; 
        VoiceEnum = MaterialVoiceEnum.Ceram;
        rarity = 2;
    }
    public override void UseItem(AbstractCharacter chara)
    {
        base.UseItem(chara);
        chara.atk += 5;
    }

    public override void UseVerb()
    {
        base.UseVerb();
        
    }

    public override void End()
    {
        base.End();
        aim.atk -= 5;
    }
}
