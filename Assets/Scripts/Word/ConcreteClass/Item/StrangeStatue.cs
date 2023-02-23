using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 奇怪石像
/// </summary>
class StrangeStatue : AbstractItems
{
    public override void Awake()
    {
        base.Awake();
        itemID = 21;
        wordName = "奇怪石像";
        bookName = BookNameEnum.CrystalEnergy;
        description = "加2精神";
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.Ceram;

        rarity = 0;
    }

    public override void UseItem(AbstractCharacter chara)
    {
        base.UseItem(chara);
        chara.psy += 2;
    }

    public override void UseVerb()
    {
        base.UseVerb();
    }

    public override void End()
    {
        base.End();
        aim.psy -= 2;
    }
}
