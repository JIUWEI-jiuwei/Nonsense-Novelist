using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 形容词：心神激荡的
/// </summary>
public class XinShenJiDang : AbstractAdjectives,IChongNeng
{
    private int psyAdd;

    public override void Awake()
    {
        adjID = 7;
        wordName = "心神激荡的";
        bookName = BookNameEnum.Salome;
        description = "每次碰撞获得2精神，并获得颠倒";
        skillMode = gameObject.AddComponent<SelfMode>();
        skillEffectsTime = 10;
        rarity = 1;
        base.Awake();
        if (this.gameObject.layer == LayerMask.NameToLayer("WordCollision"))
            wordCollisionShoots[0] = gameObject.AddComponent<ChongNeng>();
    }
    /// <summary>
    /// 每次弹射，增加2精神，持续10s（这个叠加只加精神 持续时间续不增加|| 无碰撞直接发射 就是0）
    /// </summary>
    /// <param name="times"></param>
    public void ChongNeng(int times)
    {
        psyAdd += 2*times;
    }

    public override void UseAdj(AbstractCharacter aimCharacter)
    {
        base.UseAdj(aimCharacter);

        buffs.Add(aimCharacter.gameObject.AddComponent<DianDao>());
        buffs[0].maxTime = skillEffectsTime;

        BasicAbility(aimCharacter);

    }
    public override void BasicAbility(AbstractCharacter aimCharacter)
    {
        aimCharacter.psy += psyAdd;
    }

    public override void End()
    {
        aim.psy -= psyAdd;
        base.End();
    }
    
}
