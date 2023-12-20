using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 形容词：核污染的
/// </summary>
public class HeWuRan : AbstractAdjectives
{
    public override void Awake()
    {  
        base.Awake();
        adjID = 11;
        wordName = "核污染的";
        bookName = BookNameEnum.ElectronicGoal;
        description = "中毒，持续10s";

        skillMode = gameObject.AddComponent<DamageMode>();

        skillEffectsTime = 10;
        rarity = 1;
      
        if (this.gameObject.layer == LayerMask.NameToLayer("WordCollision")) 
            wordCollisionShoots[0]=gameObject.AddComponent<ChuanBoCollision>();
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
