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
        description = "一颗纯洁无暇的白色水晶，提升四维属性各1点。";
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.Ceram;

        rarity = 0;
        if (this.gameObject.layer == LayerMask.NameToLayer("WordCollision"))
            wordCollisionShoots[0] = gameObject.AddComponent<SanShe>();

    }

    public override void UseItems(AbstractCharacter chara)
    {
        base.UseItems(chara);
    }

    public override void UseVerbs()
    {
        base.UseVerbs();
        buffs.Add(gameObject.AddComponent<GaiZao>());
        buffs[0].maxTime = Mathf.Infinity;
    }

    public override void End()
    {
        base.End();
    }
}
