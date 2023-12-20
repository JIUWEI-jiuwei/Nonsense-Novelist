using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 形容词：坚如磐石的
/// </summary>
public class JianRuPanShi : AbstractAdjectives
{
    static public string s_description = "<sprite name=\"def\">+12，持续10s";
    static public string s_wordName = "坚如磐石的";
    public override void Awake()
    {
        adjID = 23;
        wordName = "坚如磐石的";
        bookName = BookNameEnum.allBooks;
<<<<<<< HEAD
        description = "<sprite name=\"def\">+12，持续10s";
=======
        description = "防御+12，持续10s";
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454
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
