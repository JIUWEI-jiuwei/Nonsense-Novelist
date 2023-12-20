using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ���ݴʣ���ǣ���ӵ�
/// </summary>
public class HunQianMengYing : AbstractAdjectives
{
    public override void Awake()
    {
        adjID = 0;
        wordName = "��ǣ���ӵ�";
        bookName = BookNameEnum.Salome;
        description = "�����ɫ����������7s";

        skillMode = gameObject.AddComponent<DamageMode>();

        skillEffectsTime = 7;
        rarity = 0;
        base.Awake();
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
