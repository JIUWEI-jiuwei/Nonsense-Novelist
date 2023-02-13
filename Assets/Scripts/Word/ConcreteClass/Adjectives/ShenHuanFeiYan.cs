using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShenHuanFeiYan : AbstractAdjectives
{
    public override void Awake()
    {
        adjID = 6;
        wordName = "身患肺炎的";
        bookName = BookNameEnum.FluStudy;
        skillMode = gameObject.AddComponent<DamageMode>();
        skillEffectsTime = 5;
        rarity = 1;
        base.Awake();
    }

    public override void UseAdj(AbstractCharacter aimCharacter)
    {
        base.UseAdj(aimCharacter);
        //中心得到传播
        buffs.Add(aimCharacter.gameObject.AddComponent<ChuanBo>());
        //相邻得到患病
        AbstractCharacter[] neighbors = (buffs[0] as ChuanBo).GetNeighbor(aimCharacter);
        foreach (AbstractCharacter n in neighbors)
        {
            buffs.Add(n.gameObject.AddComponent<Ill>());
        }
        //中心得到患病
        buffs.Add(aimCharacter.gameObject.AddComponent<Ill>());

        foreach (AbstractBuff buff in buffs)
        {
            buff.maxTime = skillEffectsTime;
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
