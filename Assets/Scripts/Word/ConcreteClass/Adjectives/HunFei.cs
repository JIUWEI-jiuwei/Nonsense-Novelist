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
        wordName = "��ɵ�";
        bookName = BookNameEnum.PHXTwist;
        skillMode = gameObject.AddComponent<CureMode>();
        skillEffectsTime = Mathf.Infinity;
        rarity = 1;
        wordCollisionShoots.Add(gameObject.AddComponent<SanShe>());
    }

    public override void UseAdj(AbstractCharacter aimCharacter)
    {
        base.UseAdj(aimCharacter);
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
