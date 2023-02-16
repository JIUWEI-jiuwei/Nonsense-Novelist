using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 紫水晶
/// </summary>
class PurpleStone: AbstractItems
{
    /// <summary>是否激活共振 </summary>
    public bool jiHuo;

    public override void Awake()
    {
        base.Awake();
        itemID = 9;
        wordName = "紫水晶";
        bookName = BookNameEnum.CrystalEnergy;
        description = "一颗深紫色高洁的水晶，提升3点精神，少量增强暴击倍数。";
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.Ceram;

        rarity = 1;
        if (this.gameObject.layer == LayerMask.NameToLayer("WordCollision"))
            wordCollisionShoots[0] = gameObject.AddComponent<JiHuo>();

    }

    public override void UseItems(AbstractCharacter chara)
    {
        base.UseItems(chara);
        if (jiHuo)
        {
            chara.psy += 4;

        }

    }

    public override void UseVerbs()
    {
        base.UseVerbs();
        if (jiHuo)
        {
            buffs.Add(gameObject.AddComponent<GongZhen>());
            buffs[0].maxTime = Mathf.Infinity;

        }
    }

    public override void End()
    {
        base.End();
        if (jiHuo)
        {
            aim.psy -= 4;
        }
    }
}
