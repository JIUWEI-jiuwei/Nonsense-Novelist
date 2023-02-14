using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 白水晶
/// </summary>
class WhiteStone: AbstractItems
{
    public override void Awake()
    {
        base.Awake();
        itemID = 8;
        wordName = "白水晶";
        bookName = BookNameEnum.CrystalEnergy;
        description = "一颗纯洁无暇的白色水晶，提升四维属性各1点。";
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.Ceram;

        rarity = 1;
        if (this.gameObject.layer == LayerMask.NameToLayer("WordCollision")) 
            wordCollisionShoots.Add(gameObject.AddComponent<JiHuo>());
    }

    public override void UseItems(AbstractCharacter chara)
    {
        base.UseItems(chara);
        chara.hp += 40;

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
    }
}
