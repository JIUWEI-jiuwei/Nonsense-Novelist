using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShenYouHuanJing : AbstractAdjectives
{
    public override void Awake()
    {
        base.Awake();
        adjID = 3;
        wordName = "���λþ���";
        bookName = BookNameEnum.HongLouMeng;
        skillMode = gameObject.AddComponent<SelfMode>();
        skillEffectsTime = 10;
        rarity = 1;
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
