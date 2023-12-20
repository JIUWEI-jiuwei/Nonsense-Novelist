using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 形容词：不朽
/// </summary>

public class BuXiu : AbstractAdjectives
{
    public override void Awake()
    {
        
        adjID = 5;
        wordName = "不朽的";
        bookName = BookNameEnum.EgyptMyth;
        description = "生命上限+60，获得复活";

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
        aimCharacter.maxHp += 60;
    }

    

    public override void End()
    {
        base.End();
        aim.maxHp -= 60;
    }

}
