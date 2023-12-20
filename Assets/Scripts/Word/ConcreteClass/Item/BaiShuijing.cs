using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 名词：白水晶
/// </summary>
class BaiShuijing: AbstractItems,IJiHuo
{
<<<<<<< HEAD
    static public string s_description = "未激活，<sprite name=\"hpmax\">+20；\n激活，<sprite name=\"hp\"> + 60，获得<color=#dd7d0e>共振</color>";
    static public string s_wordName = "白水晶";
=======
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454
    /// <summary>是否激活共振 </summary>
    private bool jiHuo;
    public override void Awake()
    {
        base.Awake();
        itemID = 9;
        wordName = "白水晶";
        bookName = BookNameEnum.CrystalEnergy;
<<<<<<< HEAD
        description = "未激活，<sprite name=\"hpmax\">+20；\n激活，<sprite name=\"hp\"> + 60，获得<color=#dd7d0e>共振</color>";
=======
        description = "未激活，生命上限+20；激活，生命 + 60，获得共振";
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454
        VoiceEnum = MaterialVoiceEnum.Ceram;
        rarity = 1;

        if (this.gameObject.layer == LayerMask.NameToLayer("WordCollision"))
            wordCollisionShoots[0] = gameObject.AddComponent<JiHuo>();
    }
<<<<<<< HEAD
    override public string[] DetailLable()
    {
        string[] _s = new string[2];
        _s[0] = "GongZhen";
        _s[1] = "JiHuo";
        return _s;
    }

=======
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454

    public void JiHuo(bool value)
    {
        jiHuo= value;
    }

    public override void UseItem(AbstractCharacter chara)
    {
        base.UseItem(chara);
        if (jiHuo)
        {
            chara.CreateFloatWord(60, FloatWordColor.heal, false);
            chara.hp += 60;
           buffs.Add(gameObject.AddComponent<GongZhen>());
           buffs[0].maxTime = Mathf.Infinity;
        }
        else
        {
            chara.CreateFloatWord(20, FloatWordColor.heal, false);
            chara.maxHp += 20;
        }
    }

    public override void UseVerb()
    {
        base.UseVerb();
    }

    public override void End()
    {
        base.End();

        if (jiHuo)
            aim.hp -= 60;
        else
            aim.maxHp -= 20;
    }

    
}
