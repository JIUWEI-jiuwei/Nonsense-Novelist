using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 名词：被植入的记忆
/// </summary>
class BeiZhiRuDeJiYi : AbstractItems
{
<<<<<<< HEAD
    static public string s_description = "<sprite name=\"psy\">-15%，<sprite name=\"san\">-15%，获得<color=#dd7d0e>改造</color>";
    static public string s_wordName = "被植入的记忆";
=======
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454
    public override void Awake()
    {
        base.Awake();
        itemID = 14;
        wordName = "被植入的记忆";
        bookName = BookNameEnum.ElectronicGoal;
<<<<<<< HEAD
        description = "<sprite name=\"psy\">-15%，<sprite name=\"san\">-15%，获得<color=#dd7d0e>改造</color>";
=======
        description = "精神-15%，意志-15%，获得改造";
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454
        VoiceEnum = MaterialVoiceEnum.Meat;

        rarity = 1;
    }

<<<<<<< HEAD
    override public string[] DetailLable()
    {
        string[] _s = new string[1];
        _s[0] = "GaiZao";
        return _s;
    }

=======
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454
    public override void UseItem(AbstractCharacter chara)
    {
        base.UseItem(chara);
        chara.psyMul -= 0.15f;
        chara.sanMul -= 0.15f;
<<<<<<< HEAD
        buffs.Add(chara.gameObject.AddComponent<GaiZao>());
   

=======
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454
    }

    public override void UseVerb()
    {
        base.UseVerb();
    }

    public override void End()
    {
        base.End();
        aim.psyMul += 0.15f;
        aim.sanMul += 0.15f;
    }
}
