using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QingXi : AbstractAdjectives
{
    public override void Awake()
    {
        base.Awake();
        adjID = 11;
        wordName = "ÇåÎúµÄ";
        bookName = BookNameEnum.CrystalEnergy;
        skillMode = gameObject.AddComponent<UpPSYMode>();
        skillEffectsTime = Mathf.Infinity;
        rarity = 1;
    }

    public override void UseAdj(AbstractCharacter aimCharacter)
    {
        base.UseAdj(aimCharacter);
        BasicAbility(aimCharacter);
    }
    public override void BasicAbility(AbstractCharacter aimCharacter)
    {
        aimCharacter.psy += 5;
    }

    

    public override void End()
    {
        base.End();
        aim.psy-= 5;
    }

}
