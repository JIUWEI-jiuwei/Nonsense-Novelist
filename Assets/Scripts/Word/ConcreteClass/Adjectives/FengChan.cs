using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FengChan : AbstractAdjectives
{
    public override void Awake()
    {
        
        adjID = 9;
        wordName = "·á²úµÄ";
        bookName = BookNameEnum.EgyptMyth;
        skillMode = gameObject.AddComponent<CureMode>();
        skillEffectsTime = Mathf.Infinity;
        rarity = 1;
        wordCollisionShoots.Add(gameObject.AddComponent<SanShe>());
        base.Awake();
    }

    public override void UseAdj(AbstractCharacter aimCharacter)
    {
        base.UseAdj(aimCharacter);
        BasicAbility(aimCharacter);
    }
    public override void BasicAbility(AbstractCharacter aimCharacter)
    {
        aimCharacter.maxHP += 10;

    }

    

    public override void End()
    {
        base.End();
        aim.maxHP -= 10;
    }

}
