using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaFanWuXin : AbstractAdjectives
{
    public override void Awake()
    {
        base.Awake();
        adjID = 1;
        wordName = "²è·¹ÎÞÐÄµÄ";
        bookName = BookNameEnum.HongLouMeng;
        skillMode = gameObject.AddComponent<UpPSYMode>();
        skillEffectsTime = 10;
        rarity = 0;
    }

    public override void UseVerbs(AbstractCharacter aimCharacter)
    {
        base.UseVerbs(aimCharacter);
        buffs.Add(aimCharacter.gameObject.AddComponent<Upset>());
        buffs[0].maxTime = skillEffectsTime;
        BasicAbility(aimCharacter);
    }
    public override void BasicAbility(AbstractCharacter aimCharacter)
    {
        aimCharacter.psy += 10;
    }

    public override void End()
    {
        base.End();
        aim.psy -= 10;
    }
}
