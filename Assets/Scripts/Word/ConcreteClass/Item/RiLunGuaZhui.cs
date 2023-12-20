using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 日轮挂坠
/// </summary>
class RiLunGuaZhui : AbstractItems
{
    public override void Awake()
    {
        base.Awake();
        itemID = 6;

        wordName = "日轮挂坠";
        bookName = BookNameEnum.EgyptMyth;
        description = "生命上限+30，恢复+3";
        VoiceEnum = MaterialVoiceEnum.Ceram;
        rarity = 2;
    }
    public override void UseItem(AbstractCharacter chara)
    {
        base.UseItem(chara);
        //生命上限+30，恢复+3

        chara.maxHp += 30;
       
    }

    public override void UseVerb()
    {
        base.UseVerb();
        
    }

    public override void End()
    {
        base.End();
        aim.maxHp -= 5;
    }
}
