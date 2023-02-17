using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 玫瑰石英
/// </summary>
class MeiGuiShiYing : AbstractItems
{
    /// <summary>是否激活共振 </summary>
    public bool jiHuo;

    public override void Awake()
    {
        base.Awake();
        itemID = 11;
        wordName = "玫瑰石英";
        bookName = BookNameEnum.CrystalEnergy;
        description = "激活后，加6防御，获得共振";
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
            chara.def += 6;

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
            aim.def -= 6;

        }
    }
}
