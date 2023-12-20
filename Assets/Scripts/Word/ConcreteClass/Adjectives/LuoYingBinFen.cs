using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ÐÎÈÝ´Ê£ºÂäÓ¢çÍ·×µÄ
/// </summary>
public class LuoYingBinFen : AbstractAdjectives
{
    public override void Awake()
    {
        adjID = 21;
        wordName = "ÂäÓ¢çÍ·×µÄ";
        bookName = BookNameEnum.allBooks;
        description = "»ñµÃ»¨°ê";
        skillMode = gameObject.AddComponent<DamageMode>();
        skillEffectsTime = Mathf.Infinity;
        rarity = 0;
        base.Awake();

        if (this.gameObject.layer == LayerMask.NameToLayer("WordCollision"))
            wordCollisionShoots[0] = gameObject.AddComponent<SanShe>();
    }

    public override void UseAdj(AbstractCharacter aimCharacter)
    {
        base.UseAdj(aimCharacter);
        buffs.Add(aimCharacter.gameObject.AddComponent<HuaBan>());
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
