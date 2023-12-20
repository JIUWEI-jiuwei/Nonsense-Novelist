using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
///名词：寄生虫
/// </summary>
class JiShengChong : AbstractItems
{
    static public string s_description = "<sprite name=\"def\">-3，自身与随从的攻击附带<color=#dd7d0e>患病</color>";
    static public string s_wordName = "寄生虫";
    public override void Awake()
    {
        base.Awake();
        itemID = 16;
        wordName = "寄生虫";
        bookName = BookNameEnum.FluStudy;
<<<<<<< HEAD
        description = "<sprite name=\"def\">-3，自身与随从的攻击附带<color=#dd7d0e>患病</color>";
=======
        description = "防御-3，自身与随从的攻击附带患病";
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454

        VoiceEnum = MaterialVoiceEnum.Meat;

        rarity = 1;
        if (this.gameObject.layer == LayerMask.NameToLayer("WordCollision"))
            wordCollisionShoots[0] = gameObject.AddComponent<SanShe>();

    }

    override public string[] DetailLable()
    {
        string[] _s = new string[2];
        _s[0] = "SanShe";
        _s[1] = "Ill";
        return _s;
    }

    public override void UseItem(AbstractCharacter chara)
    {
        base.UseItem(chara);
        chara.def-=3;
    }

    public override void UseVerb()
    {
        base.UseVerb();
        //buffs.Add(gameObject.AddComponent<Ill>());
        //buffs[0].maxTime = 5;
    }

    public override void End()
    {
        base.End();
        aim.def+=3;
    }
}
