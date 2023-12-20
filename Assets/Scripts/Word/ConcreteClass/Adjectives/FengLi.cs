using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 形容词：锋利的
/// </summary>
public class FengLi : AbstractAdjectives
{
    static public string s_description = "<sprite name=\"atk\">+4，持续10s";
    static public string s_wordName = "锋利的";


    public override void Awake()
    {
        adjID = 19;
        wordName = "锋利的";
        bookName = BookNameEnum.allBooks;
<<<<<<< HEAD
        description = "<sprite name=\"atk\">+4，持续10s";
=======
        description = "攻击力+4，持续10s";
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454

        skillMode = gameObject.AddComponent<UpATKMode>();

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
        aimCharacter.atk += 4;
    }

    

    public override void End()
    {
        base.End();
        aim.atk -=4;
    }

}
