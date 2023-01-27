using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenZao : AbstractAdjectives
{
    public override void Awake()
    {
        base.Awake();
        adjID = 12;
        wordName = "»À‘Ïµƒ";
        bookName = BookNameEnum.ElectronicGoal;
        skillMode = gameObject.AddComponent<CureMode>();
        skillEffectsTime = Mathf.Infinity;
        rarity = 0;
    }

    public override void UseAdj(AbstractCharacter aimCharacter)
    {
        base.UseAdj(aimCharacter);
        buffs.Add(aimCharacter.gameObject.AddComponent<GaiZao>());
        buffs[0] .maxTime = skillEffectsTime;
        BasicAbility(aimCharacter);
    }
    public override void BasicAbility(AbstractCharacter aimCharacter)
    {
        aimCharacter.maxHP += 20;
    }

    

    public override void End()
    {
        base.End();
        aim.maxHP -= 20;
    }

}
