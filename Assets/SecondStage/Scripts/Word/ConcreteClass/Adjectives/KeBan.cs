using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeBan : AbstractAdjectives
{
    public override void Awake()
    {
        adjID = 4;
        wordName = "¿Ì°åµÄ";
        bookName = BookNameEnum.ZooManual;
        description = "ÎÞ·¨¹¥»÷";
        skillMode = gameObject.AddComponent<SelfMode>();
        skillEffectsTime = 10;
        rarity = 0;
        base.Awake();
    }

    public override void UseAdj(AbstractCharacter aimCharacter)
    {
        base.UseAdj(aimCharacter);
        buffs.Add(aimCharacter.gameObject.AddComponent<Upset>());
            buffs[0].maxTime = skillEffectsTime;
    }
    public override void BasicAbility(AbstractCharacter aimCharacter)
    {
        
    }
    
}
