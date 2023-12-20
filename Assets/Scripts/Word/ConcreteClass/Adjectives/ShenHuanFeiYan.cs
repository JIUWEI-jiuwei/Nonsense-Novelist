using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShenHuanFeiYan : AbstractAdjectives
{
    public override void Awake()
    {
        adjID = 13;
        wordName = "�����׵�";
        bookName = BookNameEnum.FluStudy;
        description = "����������20s";
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
        ////���ĵõ�����
        //buffs.Add(aimCharacter.gameObject.AddComponent<ChuanBo>());
        ////���ڵõ�����
        //AbstractCharacter[] neighbors = (buffs[0] as ChuanBo).GetNeighbor(aimCharacter);
        //foreach (AbstractCharacter n in neighbors)
        //{
        //    buffs.Add(n.gameObject.AddComponent<Ill>());
        //}
        ////���ĵõ�����
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
