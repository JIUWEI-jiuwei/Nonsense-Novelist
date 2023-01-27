using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuZhuang : AbstractAdjectives
{
    public override void Awake()
    {
        base.Awake();
        adjID = 18;
        wordName = "��׳��";
        bookName = BookNameEnum.allBooks;
        skillMode = gameObject.AddComponent<CureMode>();
        skillEffectsTime = Mathf.Infinity;
        rarity = 0;
    }

    public override void UseAdj(AbstractCharacter aimCharacter)
    {
        base.UseAdj(aimCharacter);
        BasicAbility(aimCharacter);
    }
    public override void BasicAbility(AbstractCharacter aimCharacter)
    {
        aimCharacter.maxHP += 20;
    }

    

    public override void End()
    {
        base.End();
        aim.maxHP -= 20;
    }

}
