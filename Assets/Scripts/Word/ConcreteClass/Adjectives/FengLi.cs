using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FengLi : AbstractAdjectives
{
    public override void Awake()
    {
        base.Awake();
        adjID = 15;
        wordName = "������";
        bookName = BookNameEnum.allBooks;
        skillMode = gameObject.AddComponent<UpATKMode>();
        skillEffectsTime = 20;
        rarity = 0;
    }

    public override void UseVerbs(AbstractCharacter aimCharacter)
    {
        base.UseVerbs(aimCharacter);
        SpecialAbility(aimCharacter);
    }
    public override void SpecialAbility(AbstractCharacter aimCharacter)
    {
        aimCharacter.atk += 5;
    }

    

    public override void End()
    {
        base.End();
        aim.atk -= 5;
    }

}
