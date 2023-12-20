using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ���ݴʣ���ս��
/// </summary>
public class HaoZhan : AbstractAdjectives
{
    public override void Awake()
    {        
        base.Awake();
        adjID = 18;
        wordName = "��ս��";
        bookName = BookNameEnum.PHXTwist;
        description = "���ٹ���������5s";

        skillMode = gameObject.AddComponent<SelfMode>();
        skillEffectsTime = 5;

        rarity = 0;

    }

    public override void UseAdj(AbstractCharacter aimCharacter)
    {
        base.UseAdj(aimCharacter);
        BasicAbility(aimCharacter);
    }
    public override void BasicAbility(AbstractCharacter aimCharacter)
    {
        aimCharacter.attackInterval -= 1.2f;
    }

    

    public override void End()
    {
        base.End();
        aim.attackInterval += 1.2f;
    }

}
