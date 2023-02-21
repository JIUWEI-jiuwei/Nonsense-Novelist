using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuZhuang : AbstractAdjectives
{
    public override void Awake()
    {
        adjID = 18;
        wordName = "粗壮的";
        bookName = BookNameEnum.allBooks;
        description = "获得生命上限";
        skillMode = gameObject.AddComponent<CureMode>();
        skillEffectsTime = Mathf.Infinity;
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
        aimCharacter.MaxHP += 20;
    }

    

    public override void End()
    {
        base.End();
        aim.MaxHP -= 20;
    }

}
