using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 名词：虎眼石
/// </summary>
class HuYanShi: AbstractItems,IJiHuo
{
    static public string s_description = "未激活，<sprite name=\"atk\">+1；\n激活，<sprite name=\"atk\"> + 3，获得<color=#dd7d0e>共振</color>";
    static public string s_wordName = "虎眼石";
    /// <summary>是否激活共振 </summary>
    private bool jiHuo;
    private float record;
    public override void Awake()
    {
        base.Awake();
        itemID = 11;
        wordName = "虎眼石";
        bookName = BookNameEnum.CrystalEnergy;
<<<<<<< HEAD
        description = "未激活，<sprite name=\"atk\">+1；\n激活，<sprite name=\"atk\"> + 3，获得<color=#dd7d0e>共振</color>";
=======
        description = "未激活，攻击+1；激活，攻击 + 3，获得共振";
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454
        VoiceEnum = MaterialVoiceEnum.Ceram;

        rarity = 2;
        if (this.gameObject.layer == LayerMask.NameToLayer("WordCollision"))
            wordCollisionShoots[0] = gameObject.AddComponent<JiHuo>();
    }



    public void JiHuo(bool value)
    {
       jiHuo= value;
    }

    override public string[] DetailLable()
    {
        string[] _s = new string[2];
        _s[0] = "JiHuo";
        _s[1] = "GongZhen";
        return _s;
    }
    public override void UseItem(AbstractCharacter chara)
    {
        base.UseItem(chara);
        if (jiHuo)
        {
            record = 3;
            chara.atk += record;
            buffs.Add(gameObject.AddComponent<GongZhen>());
            buffs[0].maxTime = Mathf.Infinity;
        }
        else
        {
            record = 1;
            chara.atk += record;
        }
    }

    public override void UseVerb()
    {
        base.UseVerb();
    }

    public override void End()
    {
        base.End();
        aim.atk -= record;
    }

    
}
