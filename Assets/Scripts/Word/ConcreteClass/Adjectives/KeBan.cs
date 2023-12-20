using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ���ݴʣ��̰��
/// </summary>
public class KeBan : AbstractAdjectives
{
    public override void Awake()
    {
        adjID = 3;
        wordName = "�̰��";
        bookName = BookNameEnum.ZooManual;
        description = "12s���޷�����";
        skillMode = gameObject.AddComponent<SelfMode>();
        skillEffectsTime = 12;
        rarity = 0;
        base.Awake();
    }

    public override void UseAdj(AbstractCharacter aimCharacter)
    {
        base.UseAdj(aimCharacter);
        buffs.Add(aimCharacter.gameObject.AddComponent<Upset>());
            buffs[0].maxTime = skillEffectsTime;
    }
    public override void BasicAbility(AbstractCharacter aimCharacter)
    {
        
    }
    
}
