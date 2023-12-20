using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 形容词：坚如磐石的
/// </summary>
public class JianRuPanShi : AbstractAdjectives
{
    public override void Awake()
    {
        adjID = 23;
        wordName = "坚如磐石的";
        bookName = BookNameEnum.allBooks;
        description = "防御+12，持续10s";
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
        aimCharacter.def += 12;
    }

    

    public override void End()
    {
        base.End();
        aim.def -= 12;
    }

}
