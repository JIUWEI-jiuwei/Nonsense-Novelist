using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShenYouHuanJing : AbstractAdjectives
{
    public override void Awake()
    {
        adjID = 3;
        wordName = "神游幻境的";
        bookName = BookNameEnum.HongLouMeng;
        skillMode = gameObject.AddComponent<SelfMode>();
        skillEffectsTime = 10;
        rarity = 1;
        
        base.Awake();
        if (this.gameObject.layer == LayerMask.NameToLayer("WordCollision"))
        {
            wordCollisionShoots[0] = gameObject.AddComponent<XuWu_YunSu>();
        }
    }

    public override void UseAdj(AbstractCharacter aimCharacter)
    {
        base.UseAdj(aimCharacter);
        buffs.Add(aimCharacter.gameObject.AddComponent<DianDao>());
        buffs[0].maxTime = skillEffectsTime;
    }
    public override void BasicAbility(AbstractCharacter aimCharacter)
    {
        
    }
    
}
