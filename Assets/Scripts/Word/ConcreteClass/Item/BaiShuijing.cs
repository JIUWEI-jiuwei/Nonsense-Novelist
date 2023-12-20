using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 名词：白水晶
/// </summary>
class BaiShuijing: AbstractItems,IJiHuo
{
    /// <summary>是否激活共振 </summary>
    private bool jiHuo;
    public override void Awake()
    {
        base.Awake();
        itemID = 9;
        wordName = "白水晶";
        bookName = BookNameEnum.CrystalEnergy;
        description = "未激活，生命上限+20；激活，生命 + 60，获得共振";
        VoiceEnum = MaterialVoiceEnum.Ceram;
        rarity = 1;

        if (this.gameObject.layer == LayerMask.NameToLayer("WordCollision"))
            wordCollisionShoots[0] = gameObject.AddComponent<JiHuo>();
    }

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
