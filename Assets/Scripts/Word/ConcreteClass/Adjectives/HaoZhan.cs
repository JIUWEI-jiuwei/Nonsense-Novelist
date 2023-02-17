using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaoZhan : AbstractAdjectives
{
    public override void Awake()
    {
        adjID = 0;
        wordName = "好战的";
        bookName = BookNameEnum.PHXTwist;
        description = "加快攻速";
        skillMode = gameObject.AddComponent<SelfMode>();
        skillEffectsTime = Mathf.Infinity;
        rarity = 0;
        base.Awake();
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
