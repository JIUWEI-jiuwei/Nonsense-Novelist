using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 虎眼石
/// </summary>
class TigerStone: AbstractItems
{
    /// <summary>是否激活共振 </summary>
    public bool jiHuo;

    public override void Awake()
    {
        base.Awake();
        itemID = 10;
        wordName = "虎眼石";
        bookName = BookNameEnum.CrystalEnergy;
        description = "一颗金色华丽的宝石，提升3点攻击，少量增强暴击倍数。";
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.Ceram;

        rarity = 2;
        if (this.gameObject.layer == LayerMask.NameToLayer("WordCollision"))
            wordCollisionShoots[0] = gameObject.AddComponent<JiHuo>();

    }

    public override void UseItems(AbstractCharacter chara)
    {
        base.UseItems(chara);
        if (jiHuo)
        {
            chara.atk += 5;

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
            aim.atk -= 5;
        }
    }
}
