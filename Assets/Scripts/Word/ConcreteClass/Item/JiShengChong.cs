using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
///寄生虫
/// </summary>
class JiShengChong : AbstractItems
{
    public override void Awake()
    {
        base.Awake();
        itemID = 15;
        wordName = "寄生虫";
        bookName = BookNameEnum.FluStudy;
        description = "散射，减少防御，加快攻速，攻击附带“患病”";
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.Meat;

        rarity = 1;
        if (this.gameObject.layer == LayerMask.NameToLayer("WordCollision"))
            wordCollisionShoots[0] = gameObject.AddComponent<SanShe>();

    }

    public override void UseItem(AbstractCharacter chara)
    {
        base.UseItem(chara);
        chara.def-=3;
    }

    public override void UseVerb()
    {
        base.UseVerb();
        buffs.Add(gameObject.AddComponent<Ill>());
        buffs[0].maxTime = 5;
    }

    public override void End()
    {
        base.End();
        aim.def+=3;
    }
}
