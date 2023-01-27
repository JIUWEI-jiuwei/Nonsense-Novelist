using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeWuRan : AbstractAdjectives
{
    public override void Awake()
    {
        base.Awake();
        adjID = 5;
        wordName = "ºËÎÛÈ¾µÄ";
        bookName = BookNameEnum.EgyptMyth;
        skillMode = gameObject.AddComponent<DamageMode>();
        skillEffectsTime = 3;
        rarity = 1;
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
