using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SanFaFeiLuoMeng : AbstractAdjectives
{
    /// <summary>是否激活起舞 </summary>
    public bool jiHuo;
    public override void Awake()
    {
        adjID = 13;
        wordName = "散发费洛蒙的";
        bookName = BookNameEnum.EgyptMyth;
        skillMode = gameObject.AddComponent<DamageMode>();
        skillEffectsTime = 10;
        rarity = 2;
        if (this.gameObject.layer == LayerMask.NameToLayer("WordCollision")) 
            wordCollisionShoots.Add(gameObject.AddComponent<JiHuo>());
        base.Awake();
    }

    public override void UseAdj(AbstractCharacter aimCharacter)
    {
        base.UseAdj(aimCharacter);
        buffs.Add(aimCharacter.gameObject.AddComponent<QiWu>());
        buffs[0].maxTime = skillEffectsTime;

        //起舞(激活)
        if (jiHuo)
        {
            buffs[0].maxTime = 3;
        }
    }
    public override void BasicAbility(AbstractCharacter aimCharacter)
    {
    }

    public override void End()
    {
        base.End();
    }

}
