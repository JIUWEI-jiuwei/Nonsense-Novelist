using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HunFei : AbstractAdjectives
{
    public override void Awake()
    {
        adjID = 14;
        wordName = "»é·ÉµÄ";
        bookName = BookNameEnum.PHXTwist;
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
        aimCharacter.hp += 30;
    }

    

    public override void End()
    {
        base.End();
    }

}
