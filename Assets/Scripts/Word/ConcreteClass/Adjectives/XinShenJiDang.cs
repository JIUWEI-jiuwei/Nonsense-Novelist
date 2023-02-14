using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XinShenJiDang : AbstractAdjectives
{
    public override void Awake()
    {
        adjID = 10;
        wordName = "���񼤵���";
        bookName = BookNameEnum.Salome;
        skillMode = gameObject.AddComponent<SelfMode>();
        skillEffectsTime = 10;
        rarity = 2;
        if (this.gameObject.layer == LayerMask.NameToLayer("WordCollision")) 
            wordCollisionShoots.Add(gameObject.AddComponent<ChongNeng>());
        base.Awake();
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

    

    public override void End()
    {
        base.End();
    }

}
