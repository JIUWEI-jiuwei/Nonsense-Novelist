using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeBan : AbstractAdjectives
{
    public override void Awake()
    {
        base.Awake();
        adjID = 4;
        wordName = "�̰��";
        bookName = BookNameEnum.ZooManual;
        skillMode = gameObject.AddComponent<SelfMode>();
        skillEffectsTime = 10;
        rarity = 0;
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
