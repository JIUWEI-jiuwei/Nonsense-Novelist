using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuXiu : AbstractAdjectives
{
    public override void Awake()
    {
        base.Awake();
        adjID = 2;
        wordName = "�����";
        bookName = BookNameEnum.EgyptMyth;
        skillMode = gameObject.AddComponent<CureMode>();
        skillEffectsTime = Mathf.Infinity;
        rarity = 2;
    }

    public override void UseVerbs(AbstractCharacter aimCharacter)
    {
        base.UseVerbs(aimCharacter);
        buffs.Add(aimCharacter.gameObject.AddComponent<ReLife>());
        buffs[0].maxTime = skillEffectsTime;
        SpecialAbility(aimCharacter);
    }
    public override void SpecialAbility(AbstractCharacter aimCharacter)
    {
        aimCharacter.maxHP += 30;
    }

    

    public override void End()
    {
        base.End();
        aim.maxHP -= 30;
    }

}
