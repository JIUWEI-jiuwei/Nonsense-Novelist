using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 厚字典
/// </summary>
class HouZiDian : AbstractItems
{
    static public string s_description = "<sprite name=\"def\">+3";
    static public string s_wordName = "厚字典";
    public override void Awake()
    {
        base.Awake();
        itemID = 21;
        wordName = "厚字典";
        bookName = BookNameEnum.allBooks;
<<<<<<< HEAD
        description = "<sprite name=\"def\">+3";
=======
        description = "防御+3";
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454

        VoiceEnum = MaterialVoiceEnum.Ceram;

        rarity = 0;
    }

    public override void UseItem(AbstractCharacter chara)
    {
        base.UseItem(chara);
        chara.def += 3;

    }

    public override void UseVerb()
    {
        base.UseVerb();
    }

    public override void End()
    {
        base.End();
        aim.def -= 3;
    }
}
