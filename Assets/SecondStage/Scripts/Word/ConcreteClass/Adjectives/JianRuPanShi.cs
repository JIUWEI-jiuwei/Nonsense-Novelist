using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JianRuPanShi : AbstractAdjectives
{
    public override void Awake()
    {
        adjID = 19;
        wordName = "坚如磐石的";
        bookName = BookNameEnum.allBooks;
        description = "获得防御";
        skillMode = gameObject.AddComponent<UpDEFMode>();
        skillEffectsTime = 10;
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
        aimCharacter.def += 10;
    }

    

    public override void End()
    {
        base.End();
        aim.def -= 10;
    }

}
