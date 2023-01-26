using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HunFei : AbstractAdjectives
{
    public override void Awake()
    {
        base.Awake();
        adjID = 14;
        wordName = "»é·ÉµÄ";
        bookName = BookNameEnum.PHXTwist;
        skillMode = gameObject.AddComponent<CureMode>();
        skillEffectsTime = Mathf.Infinity;
        rarity = 1;
    }

    public override void UseVerbs(AbstractCharacter aimCharacter)
    {
        base.UseVerbs(aimCharacter);
        BasicAbility(aimCharacter);
    }
    public override void BasicAbility(AbstractCharacter aimCharacter)
    {
        aimCharacter.hp += 30;
    }

    

    public override void End()
    {
        base.End();
    }

}
