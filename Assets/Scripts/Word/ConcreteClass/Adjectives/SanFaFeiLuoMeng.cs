using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SanFaFeiLuoMeng : AbstractAdjectives
{
    public override void Awake()
    {
        base.Awake();
        adjID = 13;
        wordName = "ɢ�������ɵ�";
        bookName = BookNameEnum.EgyptMyth;
        skillMode = gameObject.AddComponent<DamageMode>();
        skillEffectsTime = 10;
        rarity = 2;
    }

    public override void UseVerbs(AbstractCharacter aimCharacter)
    {
        base.UseVerbs(aimCharacter);
        buffs.Add(aimCharacter.gameObject.AddComponent<QiWu>());
        buffs[0].maxTime = skillEffectsTime;
    }
    public override void SpecialAbility(AbstractCharacter aimCharacter)
    {
    }

    

    public override void End()
    {
        base.End();
    }

}
