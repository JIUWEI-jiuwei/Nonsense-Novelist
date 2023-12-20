using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 名词：先知的头颅
/// </summary>
class XianZhiHead : AbstractItems
{
    static public string s_description = "<sprite name=\"psy\">+30%，<sprite name=\"san\">-30%";
    static public string s_wordName = "先知的头颅";
    public override void Awake()
    {
        base.Awake();
        itemID = 8;
        wordName = "先知的头颅";
        bookName = BookNameEnum.Salome;
<<<<<<< HEAD
        description = "<sprite name=\"psy\">+30%，<sprite name=\"san\">-30%";
=======
        description = "精神+30%，意志-30%";
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454
        VoiceEnum = MaterialVoiceEnum.Ceram;
        rarity = 2;
    }

    public override void UseItem(AbstractCharacter chara)
    {
        base.UseItem(chara);
        chara.psyMul += 0.3f;
        chara.sanMul -= 0.3f;
    }

    public override void UseVerb()
    {
        base.UseVerb();
        
    }

    public override void End()
    {
        base.End();
        aim.psyMul -= 0.3f;
        aim.sanMul += 0.3f;
    }
}
