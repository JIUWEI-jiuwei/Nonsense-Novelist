using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 量产改装件
/// </summary>
class VolumeProduction : AbstractItems
{
    public override void Awake()
    {
        base.Awake();
        itemID = 14;
        wordName = "量产改装件";
        bookName = BookNameEnum.ElectronicGoal;
        description = "散射，获得改造";
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.Ceram;

        rarity = 0;
        if (this.gameObject.layer == LayerMask.NameToLayer("WordCollision"))
            wordCollisionShoots[0] = gameObject.AddComponent<SanShe>();

    }

    public override void UseItem(AbstractCharacter chara)
    {
        base.UseItem(chara);
    }

    public override void UseVerb()
    {
        base.UseVerb();
        buffs.Add(gameObject.AddComponent<GaiZao>());
        buffs[0].maxTime = Mathf.Infinity;
    }

    public override void End()
    {
        base.End();
    }
}
