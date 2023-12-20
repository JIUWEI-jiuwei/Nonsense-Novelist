using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 名词：毒腺
/// </summary>
class DuXian : AbstractItems
{
    static public string s_description = "自身与随从的攻击附带<color=#dd7d0e>腐蚀</color>";
    static public string s_wordName = "毒腺";
    public override void Awake()
    {
        base.Awake();
        itemID = 19;
        wordName = "毒腺";
        bookName = BookNameEnum.CrystalEnergy;

<<<<<<< HEAD
        description = "自身与随从的攻击附带<color=#dd7d0e>腐蚀</color>";
=======
        description = "自身与随从的攻击附带腐蚀";
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.Ceram;

        rarity = 2;
    }

    override public string[] DetailLable()
    {
        string[] _s = new string[1];
        _s[0] = "FuShi";
        return _s;
    }
    public override void UseItem(AbstractCharacter chara)
    {
        base.UseItem(chara);
    }

    public override void UseVerb()
    {
        base.UseVerb();
        buffs.Add(gameObject.AddComponent<FuShi>());
        buffs[0].maxTime = 12;
    }

    public override void End()
    {
        base.End();
    }
}
