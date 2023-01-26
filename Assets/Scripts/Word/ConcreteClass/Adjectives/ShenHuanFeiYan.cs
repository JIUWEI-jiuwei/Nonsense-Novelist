using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShenHuanFeiYan : AbstractAdjectives
{
    public override void Awake()
    {
        base.Awake();
        adjID = 6;
        wordName = "�����׵�";
        bookName = BookNameEnum.FluStudy;
        skillMode = gameObject.AddComponent<DamageMode>();
        skillEffectsTime = 5;
        rarity = 1;
    }

    public override void UseVerbs(AbstractCharacter aimCharacter)
    {
        base.UseVerbs(aimCharacter);
        //���ĵõ�����
        buffs.Add(aimCharacter.gameObject.AddComponent<ChuanBo>());
        //���ڵõ�����
        AbstractCharacter[] neighbors = (buffs[0] as ChuanBo).GetNeighbor(aimCharacter);
        foreach (AbstractCharacter n in neighbors)
        {
            buffs.Add(n.gameObject.AddComponent<Ill>());
        }
        //���ĵõ�����
        buffs.Add(aimCharacter.gameObject.AddComponent<Ill>());

        foreach (AbstractBuff buff in buffs)
        {
            buff.maxTime = skillEffectsTime;
        }
    }
    public override void SpecialAbility(AbstractCharacter aimCharacter)
    {
    }

    

    public override void End()
    {
        base.End();
    }

}
