using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuXiu : AbstractAdjectives
{
    public override void Awake()
    {
        
        adjID = 2;
        wordName = "�����";
        bookName = BookNameEnum.EgyptMyth;
        skillMode = gameObject.AddComponent<CureMode>();
        skillEffectsTime = Mathf.Infinity;
        rarity = 2;
        base.Awake();
    }

    public override void UseAdj(AbstractCharacter aimCharacter)
    {
        base.UseAdj(aimCharacter);
        buffs.Add(aimCharacter.gameObject.AddComponent<ReLife>());
        buffs[0].maxTime = skillEffectsTime;
        BasicAbility(aimCharacter);
    }
    public override void BasicAbility(AbstractCharacter aimCharacter)
    {
        aimCharacter.maxHP += 30;
    }

    

    public override void End()
    {
        base.End();
        aim.maxHP -= 30;
    }

}
