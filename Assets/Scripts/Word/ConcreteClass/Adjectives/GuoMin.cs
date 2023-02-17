using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuoMin : AbstractAdjectives
{
    /// <summary>充能次数 </summary>
    public int chongNeng;
    /// <summary>充能持续时间 </summary>
    public float chongNengTime = 0.5f;

    public override void Awake()
    {
        adjID = 7;
        wordName = "过敏的";
        bookName = BookNameEnum.FluStudy;
        skillMode = gameObject.AddComponent<SelfMode>();
        skillEffectsTime = 0;
        rarity = 1;
        base.Awake();
        if (this.gameObject.layer == LayerMask.NameToLayer("WordCollision"))
            wordCollisionShoots[0]=gameObject.AddComponent<ChongNeng>();
    }

    public override void UseAdj(AbstractCharacter aimCharacter)
    {
        base.UseAdj(aimCharacter);
        //中心得到传播
        buffs.Add(aimCharacter.gameObject.AddComponent<ChuanBo>());
        //相邻得到Dizzy
        AbstractCharacter[] neighbors = (buffs[0] as ChuanBo).GetNeighbor(aimCharacter);
        foreach (AbstractCharacter n in neighbors)
        {
            buffs.Add(n.gameObject.AddComponent<Dizzy>());
        }
        //中心得到Dizzy
        buffs.Add(aimCharacter.gameObject.AddComponent<Dizzy>());

        foreach (AbstractBuff buff in buffs)
        {
            buff.maxTime = skillEffectsTime+chongNengTime*chongNeng;
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
