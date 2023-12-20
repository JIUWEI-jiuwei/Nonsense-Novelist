using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
///名词： 紫水晶
/// </summary>
class ZiShuiJIng: AbstractItems,IJiHuo
{
    /// <summary>是否激活共振 </summary>
    private bool jiHuo;
    private float record;

    public override void Awake()
    {
        base.Awake();
        itemID = 10;
        wordName = "紫水晶";
        bookName = BookNameEnum.CrystalEnergy;
        description = "未激活，精神+1；激活，精神 + 3，获得共振";
        VoiceEnum = MaterialVoiceEnum.Ceram;
        rarity = 1;

        if (this.gameObject.layer == LayerMask.NameToLayer("WordCollision"))
            wordCollisionShoots[0] = gameObject.AddComponent<JiHuo>();
    }
    public void JiHuo(bool value)
    {
        jiHuo = value;
    }

    public override void UseItem(AbstractCharacter chara)
    {
        base.UseItem(chara);
        if (jiHuo)
        {
            record = 3;
            chara.psy += record;
            buffs.Add(gameObject.AddComponent<GongZhen>());
            buffs[0].maxTime = Mathf.Infinity;
        }
        else
        {
            record = 1;
            chara.psy += record;
        }
    }

    public override void UseVerb()
    {
        base.UseVerb();
    }

    public override void End()
    {
        base.End();
        aim.psy -= record;
    }

    
}
