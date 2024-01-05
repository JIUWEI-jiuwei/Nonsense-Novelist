using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QingXi : AbstractAdjectives
{
    public override void Awake()
    {
        adjID = 11;
        wordName = "清晰的";
        bookName = BookNameEnum.CrystalEnergy;
        description = "获得精神";
        skillMode = gameObject.AddComponent<UpPSYMode>();
        skillEffectsTime = Mathf.Infinity;
        rarity = 1;
        base.Awake();
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
