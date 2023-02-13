using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuoYingBinFen : AbstractAdjectives
{
    public override void Awake()
    {
        adjID = 17;
        wordName = "ÂäÓ¢çÍ·×µÄ";
        bookName = BookNameEnum.EgyptMyth;
        skillMode = gameObject.AddComponent<UpPSYMode>();
        skillEffectsTime = Mathf.Infinity;
        rarity = 0;
        base.Awake();
    }

    public override void UseAdj(AbstractCharacter aimCharacter)
    {
        base.UseAdj(aimCharacter);
        buffs.Add(aimCharacter.gameObject.AddComponent<HuaBan>());
        buffs[0].maxTime = skillEffectsTime;
    }
    public override void BasicAbility(AbstractCharacter aimCharacter)
    {
    }

    

    public override void End()
    {
        base.End();
    }

}
