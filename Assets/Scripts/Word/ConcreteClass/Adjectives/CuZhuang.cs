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
        wordName = "´Ö×³µÄ";
        bookName = BookNameEnum.allBooks;
        skillMode = gameObject.AddComponent<CureMode>();
        skillEffectsTime = Mathf.Infinity;
        rarity = 0;
    }

    public override void UseVerbs(AbstractCharacter aimCharacter)
    {
        base.UseVerbs(aimCharacter);
        SpecialAbility(aimCharacter);
    }
    public override void SpecialAbility(AbstractCharacter aimCharacter)
    {
        aimCharacter.maxHP += 20;
    }

    

    public override void End()
    {
        base.End();
        aim.maxHP -= 20;
    }

}
