using System.Collections;
using System.Collections.Generic;
using UnityEngine;
class DuXian : AbstractItems
{
    public override void Awake()
    {
        itemID = 18;
        wordName = "毒腺";
        bookName = BookNameEnum.CrystalEnergy;
        description = "一颗金色华丽的宝石，提升3点攻击，少量增强暴击倍数。";
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.Ceram;

        rarity = 0;
    }

    public override void UseItems(AbstractCharacter chara)
    {
        base.UseItems(chara);

    }

    public override void UseVerbs()
    {
        base.UseVerbs();
        buffs.Add(gameObject.AddComponent<FuShi>());
        buffs[0].maxTime = 12;
    }

    public override void End()
    {
        base.End();
    }
}
