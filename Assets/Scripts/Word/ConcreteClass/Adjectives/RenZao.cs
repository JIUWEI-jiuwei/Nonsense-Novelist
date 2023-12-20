using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 形容词：人造的
/// </summary>
public class RenZao : AbstractAdjectives
{
    public override void Awake()
    {
        adjID = 12;
        wordName = "人造的";
        bookName = BookNameEnum.ElectronicGoal;
        description = "生命上限+20，获得改造";
        skillMode = gameObject.AddComponent<CureMode>();
        skillEffectsTime = Mathf.Infinity;
        rarity = 0;
        base.Awake();
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
        aimCharacter.maxHp += 20;
    }

    

    public override void End()
    {
        base.End();
        aim.maxHp -= 20;
    }

}
