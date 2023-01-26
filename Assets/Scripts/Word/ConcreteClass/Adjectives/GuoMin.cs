using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuoMin : AbstractAdjectives
{
    public override void Awake()
    {
        base.Awake();
        adjID = 7;
        wordName = "������";
        bookName = BookNameEnum.FluStudy;
        skillMode = gameObject.AddComponent<SelfMode>();
        skillEffectsTime = 0;
        rarity = 1;
    }

    public override void UseVerbs(AbstractCharacter aimCharacter)
    {
        base.UseVerbs(aimCharacter);
        //���ĵõ�����
        buffs.Add(aimCharacter.gameObject.AddComponent<ChuanBo>());
        //���ڵõ�Dizzy
        AbstractCharacter[] neighbors = (buffs[0] as ChuanBo).GetNeighbor(aimCharacter);
        foreach (AbstractCharacter n in neighbors)
        {
            buffs.Add(n.gameObject.AddComponent<Dizzy>());
        }
        //���ĵõ�Dizzy
        buffs.Add(aimCharacter.gameObject.AddComponent<Dizzy>());

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
