using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JianRuPanShi : AbstractAdjectives
{
    public override void Awake()
    {
        base.Awake();
        adjID = 19;
        wordName = "坚如磐石的";
        bookName = BookNameEnum.allBooks;
        skillMode = gameObject.AddComponent<UpDEFMode>();
        skillEffectsTime = 10;
        rarity = 0;
    }

    public override void UseVerbs(AbstractCharacter aimCharacter)
    {
        base.UseVerbs(aimCharacter);
        SpecialAbility(aimCharacter);
    }
    public override void SpecialAbility(AbstractCharacter aimCharacter)
    {
        aimCharacter.def += 10;
    }

    

    public override void End()
    {
        base.End();
        aim.def -= 10;
    }

}
