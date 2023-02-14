using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 虎眼石
/// </summary>
class TigerStone: AbstractItems
{
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
        wordCollisionShoots.Add(gameObject.AddComponent<JiHuo>());

    }

    public override void UseItems(AbstractCharacter chara)
    {
        base.UseItems(chara);
        chara.atk += 5;

    }

    public override void UseVerbs()
    {
        base.UseVerbs();
        buffs.Add(gameObject.AddComponent<GongZhen>());
        buffs[0].maxTime = Mathf.Infinity;
    }

    public override void End()
    {
        base.End();
        aim.atk -= 5;
    }
}
