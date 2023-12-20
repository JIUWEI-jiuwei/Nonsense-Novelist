using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ���ݴʣ�������
/// </summary>
public class QingXi : AbstractAdjectives
{
    public override void Awake()
    {
        adjID = 10;
        wordName = "������";
        bookName = BookNameEnum.CrystalEnergy;
        description = "+12��־������20s";
        skillMode = gameObject.AddComponent<UpPSYMode>();
        skillEffectsTime = 20;
        rarity = 0;
        base.Awake();
    }

    public override void UseAdj(AbstractCharacter aimCharacter)
    {
        base.UseAdj(aimCharacter);
        BasicAbility(aimCharacter);
    }
    public override void BasicAbility(AbstractCharacter aimCharacter)
    {
        aimCharacter.san += 12;
    }

    

    public override void End()
    {
        base.End();
        aim.san -= 12;
    }

}
