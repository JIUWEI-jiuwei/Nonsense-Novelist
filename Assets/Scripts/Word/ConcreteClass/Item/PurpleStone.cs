using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 紫水晶
/// </summary>
class PurpleStone: AbstractItems
{
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
            wordCollisionShoots.Add(gameObject.AddComponent<JiHuo>());

    }

    public override void UseItems(AbstractCharacter chara)
    {
        base.UseItems(chara);
        chara.psy += 4;

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
        aim.psy -= 4;
    }
}
