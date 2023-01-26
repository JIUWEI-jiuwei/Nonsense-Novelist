using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FengChan : AbstractAdjectives
{
    public override void Awake()
    {
        base.Awake();
        adjID = 9;
        wordName = "�����";
        bookName = BookNameEnum.EgyptMyth;
        skillMode = gameObject.AddComponent<CureMode>();
        skillEffectsTime = Mathf.Infinity;
        rarity = 1;
    }

    public override void UseVerbs(AbstractCharacter aimCharacter)
    {
        base.UseVerbs(aimCharacter);
        SpecialAbility(aimCharacter);
    }
    public override void SpecialAbility(AbstractCharacter aimCharacter)
    {
        aimCharacter.maxHP += 10;

    }

    

    public override void End()
    {
        base.End();
        aim.maxHP -= 10;
    }

}
