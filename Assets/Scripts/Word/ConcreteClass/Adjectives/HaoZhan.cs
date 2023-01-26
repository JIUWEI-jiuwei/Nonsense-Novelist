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
        wordName = "��ս��";
        bookName = BookNameEnum.PHXTwist;
        skillMode = gameObject.AddComponent<SelfMode>();
        skillEffectsTime = Mathf.Infinity;
        rarity = 0;
    }

    public override void UseVerbs(AbstractCharacter aimCharacter)
    {
        base.UseVerbs(aimCharacter);
        SpecialAbility(aimCharacter);
    }
    public override void SpecialAbility(AbstractCharacter aimCharacter)
    {
        aimCharacter.attackInterval -= 0.5f;
    }

    

    public override void End()
    {
        base.End();
        aim.attackInterval += 0.5f;
    }

}
