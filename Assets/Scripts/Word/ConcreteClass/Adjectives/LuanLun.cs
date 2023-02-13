using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LuanLun : AbstractAdjectives
{
    public override void Awake()
    {
        adjID = 0;
        wordName = "ÂÒÂ×µÄ";
        bookName = BookNameEnum.Salome;
        skillMode = gameObject.AddComponent<SelfMode>();
        skillEffectsTime =5;
        rarity = 1;
        wordCollisionShoots.Add(gameObject.AddComponent<SanShe>());
        base.Awake();
    }

    public override void UseAdj(AbstractCharacter aimCharacter)
    {
        base.UseAdj(aimCharacter);
        buffs.Add(aimCharacter.gameObject.AddComponent<FuHuo>());
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
