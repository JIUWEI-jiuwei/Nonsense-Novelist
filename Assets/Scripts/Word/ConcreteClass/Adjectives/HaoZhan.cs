using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaoZhan : AbstractAdjectives
{
    public override void Awake()
    {
        base.Awake();
        adjID = 0;
        wordName = "ºÃÕ½µÄ";
        bookName = BookNameEnum.PHXTwist;
        skillMode = gameObject.AddComponent<SelfMode>();
        skillEffectsTime = Mathf.Infinity;
        rarity = 0;
    }

    public override void UseAdj(AbstractCharacter aimCharacter)
    {
        base.UseAdj(aimCharacter);
        BasicAbility(aimCharacter);
    }
    public override void BasicAbility(AbstractCharacter aimCharacter)
    {
        aimCharacter.attackInterval -= 0.5f;
    }

    

    public override void End()
    {
        base.End();
        aim.attackInterval += 0.5f;
    }

}
