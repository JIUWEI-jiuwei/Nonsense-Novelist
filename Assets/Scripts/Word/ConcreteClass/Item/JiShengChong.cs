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
        description = "寄生虫让其宿主颇为焦躁不安，降低3点防御，减少攻击速度。";
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.Meat;

        rarity = 1;
        if (this.gameObject.layer == LayerMask.NameToLayer("WordCollision"))
            wordCollisionShoots[0] = gameObject.AddComponent<SanShe>();

    }

    public override void UseItems(AbstractCharacter chara)
    {
        base.UseItems(chara);
        chara.def-=3;
    }

    public override void UseVerbs()
    {
        base.UseVerbs();
        buffs.Add(gameObject.AddComponent<Ill>());
        buffs[0].maxTime = 5;
    }

    public override void End()
    {
        base.End();
        aim.def+=3;
    }
}
