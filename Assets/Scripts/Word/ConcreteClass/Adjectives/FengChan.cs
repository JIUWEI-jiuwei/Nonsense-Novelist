using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FengChan : AbstractAdjectives
{
    public override void Awake()
    {
        
        adjID = 9;
        wordName = "丰产的";
        bookName = BookNameEnum.EgyptMyth;
        description = "散射，获得生命上限";
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
        aimCharacter.MaxHP += 10;

    }

    

    public override void End()
    {
        base.End();
        aim.MaxHP -= 10;
    }

}
