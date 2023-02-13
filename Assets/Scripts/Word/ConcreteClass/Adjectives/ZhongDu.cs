using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZhongDu : AbstractAdjectives
{
    public override void Awake()
    {
        adjID = 20;
        wordName = "中毒的";
        bookName = BookNameEnum.allBooks;
        skillMode = gameObject.AddComponent<DamageMode>();
        skillEffectsTime = 10;
        rarity = 2;
        base.Awake();
    }

    public override void UseAdj(AbstractCharacter aimCharacter)
    {
        base.UseAdj(aimCharacter);
        buffs.Add(aimCharacter.gameObject.AddComponent<Toxic>());
        buffs.Add(aimCharacter.gameObject.AddComponent<DianDao>());
        foreach(AbstractBuff buff in buffs)
        {
            buff.maxTime = skillEffectsTime;
        }
        
    }
    public override void BasicAbility(AbstractCharacter aimCharacter)
    {
    }

    

    public override void End()
    {
        base.End();
    }

}
