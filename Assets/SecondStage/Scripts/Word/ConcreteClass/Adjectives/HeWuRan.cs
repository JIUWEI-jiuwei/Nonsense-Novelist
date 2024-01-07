using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeWuRan : AbstractAdjectives
{
    public override void Awake()
    {
        adjID = 5;
        wordName = "����Ⱦ��";
        bookName = BookNameEnum.EgyptMyth;
        description = "����ж�";
        skillMode = gameObject.AddComponent<DamageMode>();
        skillEffectsTime = 3;
        rarity = 1;
        base.Awake();
        if (this.gameObject.layer == LayerMask.NameToLayer("WordCollision")) 
            wordCollisionShoots[0]=gameObject.AddComponent<SanShe>();
    }

    public override void UseAdj(AbstractCharacter aimCharacter)
    {
        base.UseAdj(aimCharacter);
        aimCharacter.gameObject.AddComponent<Toxic>()
            .maxTime = skillEffectsTime;
    }
    public override void BasicAbility(AbstractCharacter aimCharacter)
    {
    }

    

    public override void End()
    {
        base.End();
    }

}
