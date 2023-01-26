using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuoYingBinFen : AbstractAdjectives
{
    public override void Awake()
    {
        base.Awake();
        adjID = 17;
        wordName = "��Ӣ�ͷ׵�";
        bookName = BookNameEnum.EgyptMyth;
        skillMode = gameObject.AddComponent<UpPSYMode>();
        skillEffectsTime = Mathf.Infinity;
        rarity = 0;
    }

    public override void UseVerbs(AbstractCharacter aimCharacter)
    {
        base.UseVerbs(aimCharacter);
        buffs.Add(aimCharacter.gameObject.AddComponent<HuaBan>());
        buffs[0].maxTime = skillEffectsTime;
    }
    public override void SpecialAbility(AbstractCharacter aimCharacter)
    {
    }

    

    public override void End()
    {
        base.End();
    }

}
