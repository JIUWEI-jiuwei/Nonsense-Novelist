using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SanFaFeiLuoMeng : AbstractAdjectives,IJiHuo
{
    /// <summary>是否激活起舞 </summary>
    private bool jiHuo;
    public override void Awake()
    {
        adjID = 13;
        wordName = "散发费洛蒙的";
        bookName = BookNameEnum.EgyptMyth;
        description = "获得“起舞”";
        skillMode = gameObject.AddComponent<DamageMode>();
        skillEffectsTime = 10;
        rarity = 2;
        base.Awake();
        if (this.gameObject.layer == LayerMask.NameToLayer("WordCollision"))
            wordCollisionShoots[0] = gameObject.AddComponent<JiHuo>();
    }
    public void JiHuo(bool value)
    {
        jiHuo= value;
    }

    public override void UseAdj(AbstractCharacter aimCharacter)
    {
        base.UseAdj(aimCharacter);
        buffs.Add(aimCharacter.gameObject.AddComponent<QiWu>());
        //起舞(激活)
        if (jiHuo)
        {
            skillEffectsTime = 10;
        }
        else
        {
            skillEffectsTime = 3;
        }
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
