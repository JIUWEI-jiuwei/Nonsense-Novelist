using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HunFei : AbstractAdjectives
{
    public override void Awake()
    {
        adjID = 14;
        wordName = "婚飞的";
        bookName = BookNameEnum.PHXTwist;
        description = "散射，恢复生命";
        skillMode = gameObject.AddComponent<CureMode>();
        skillEffectsTime = Mathf.Infinity;
        rarity = 1;
        base.Awake();
        if (this.gameObject.layer == LayerMask.NameToLayer("WordCollision")) 
            wordCollisionShoots[0]=gameObject.AddComponent<SanShe>();
    }

    public override void UseAdj(AbstractCharacter aimCharacter)
    {
        base.UseAdj(aimCharacter);
        BasicAbility(aimCharacter);
    }
    public override void BasicAbility(AbstractCharacter aimCharacter)
    {
        aimCharacter.CreateFloatWord(
            skillMode.UseMode(null,30,aimCharacter)
            , FloatWordColor.heal, true);
    }

    

    public override void End()
    {
        base.End();
    }

}
