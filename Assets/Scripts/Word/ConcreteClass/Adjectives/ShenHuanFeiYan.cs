using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShenHuanFeiYan : AbstractAdjectives
{
    public override void Awake()
    {
        adjID = 13;
        wordName = "身患肺炎的";
        bookName = BookNameEnum.FluStudy;
        description = "患病，持续20s";
        skillMode = gameObject.AddComponent<DamageMode>();

        skillEffectsTime = 20;
        rarity = 1;
        base.Awake();
        if (this.gameObject.layer == LayerMask.NameToLayer("WordCollision"))
            wordCollisionShoots[0] = gameObject.AddComponent<ChuanBoCollision>();
    }

    public override void UseAdj(AbstractCharacter aimCharacter)
    {
        base.UseAdj(aimCharacter);
        ////中心得到传播
        //buffs.Add(aimCharacter.gameObject.AddComponent<ChuanBo>());
        ////相邻得到患病
        //AbstractCharacter[] neighbors = (buffs[0] as ChuanBo).GetNeighbor(aimCharacter);
        //foreach (AbstractCharacter n in neighbors)
        //{
        //    buffs.Add(n.gameObject.AddComponent<Ill>());
        //}
        ////中心得到患病
        buffs.Add(aimCharacter.gameObject.AddComponent<HuanBing>());
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
