using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
///名词：外骨骼
/// </summary>
class WaiGuGe : AbstractItems
{
    static public string s_description = "<sprite name=\"def\">+5";
    static public string s_wordName = "外骨骼";
    public override void Awake()
    {
        base.Awake();
        itemID = 18;
        wordName = "外骨骼";

        bookName = BookNameEnum.PHXTwist;
<<<<<<< HEAD
        description = "<sprite name=\"def\">+5";
=======
        description = "防御+5";
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454

        VoiceEnum = MaterialVoiceEnum.Meat;

        rarity = 0;
    }

    public override void UseItem(AbstractCharacter chara)
    {
        base.UseItem(chara);
        chara.def += 5;
    }

    public override void UseVerb()
    {
        base.UseVerb();
    }

    public override void End()
    {
        base.End();
        aim.def -= 5;
    }
}
