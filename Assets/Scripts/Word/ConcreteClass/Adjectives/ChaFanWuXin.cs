using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaFanWuXin : AbstractAdjectives
{
    public override void Awake()
    {
        
        adjID = 1;
        wordName = "�跹���ĵ�";
        bookName = BookNameEnum.HongLouMeng;
        description = "��ý϶ྫ�񣬻�á���ɥ��";
        skillMode = gameObject.AddComponent<UpPSYMode>();
        skillEffectsTime = 10;
        rarity = 0;
        base.Awake();
    }

    public override void UseAdj(AbstractCharacter aimCharacter)
    {
        base.UseAdj(aimCharacter);
        buffs.Add(aimCharacter.gameObject.AddComponent<Upset>());
        buffs[0].maxTime = skillEffectsTime;
        BasicAbility(aimCharacter);
    }
    public override void BasicAbility(AbstractCharacter aimCharacter)
    {
        aimCharacter.psy += 10;
    }

    public override void End()
    {
        base.End();
        aim.psy -= 10;
    }
}
