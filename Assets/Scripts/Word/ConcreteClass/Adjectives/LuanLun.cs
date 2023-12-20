using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 形容词：乱伦的
/// </summary>
public class LuanLun : AbstractAdjectives
{
    public override void Awake()
    {
        base.Awake();
        adjID = 8;
        wordName = "乱伦的";
        bookName = BookNameEnum.Salome;
        description = "俘获一群角色，攻击队友7s";
        skillMode = gameObject.AddComponent<DamageMode>();
        skillEffectsTime =7;
        rarity = 1;

        if (this.gameObject.layer == LayerMask.NameToLayer("WordCollision"))
            wordCollisionShoots[0] = gameObject.AddComponent<ChuanBoCollision>();

    }

    public override void UseAdj(AbstractCharacter aimCharacter)
    {
        base.UseAdj(aimCharacter);
        buffs.Add(aimCharacter.gameObject.AddComponent<FuHuo>());
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
