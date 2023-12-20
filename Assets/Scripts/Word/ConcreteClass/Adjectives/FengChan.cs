using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 形容词：丰产的
/// </summary>
public class FengChan : AbstractAdjectives
{
    public override void Awake()
    {
        
        adjID = 6;
        wordName = "丰产的";
        bookName = BookNameEnum.EgyptMyth;
        description = "生命上限+30";
        skillMode = gameObject.AddComponent<CureMode>();
        skillEffectsTime = Mathf.Infinity;
        rarity = 1;
        
        base.Awake();
        if (this.gameObject.layer == LayerMask.NameToLayer("WordCollision"))
        {
            wordCollisionShoots[0] = gameObject.AddComponent<SanShe>();

        }
    }

    public override void UseAdj(AbstractCharacter aimCharacter)
    {
        base.UseAdj(aimCharacter);
        BasicAbility(aimCharacter);
    }
    public override void BasicAbility(AbstractCharacter aimCharacter)
    {
        aimCharacter.maxHp += 30;

    }

    

    public override void End()
    {
        base.End();
        aim.maxHp -= 30;
    }

}
