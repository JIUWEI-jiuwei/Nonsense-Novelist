using System.Collections;
using System.Collections.Generic;
using UnityEngine;
class HorusEyes : AbstractItems
{
    public override void Awake()
    {
        itemID = 6;
        wordName = "��³˹֮��";
        bookName = BookNameEnum.EgyptMyth;
        description = "һö�������Եı�ʯ������7�㾫����ǿ����������";
        holdEnum = HoldEnum.handSingle; 
        VoiceEnum = MaterialVoiceEnum.Ceram;
        rarity = 2;
    }
    public override void UseItems(AbstractCharacter chara)
    {
        base.UseItems(chara);
        chara.atk += 5;
    }

    public override void UseVerbs()
    {
        base.UseVerbs();
        
    }

    public override void End()
    {
        base.End();
        aim.atk -= 5;
    }
}
