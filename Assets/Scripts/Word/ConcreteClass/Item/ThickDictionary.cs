using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 厚字典
/// </summary>
class ThickDictionary : AbstractItems
{
    public override void Awake()
    {
        base.Awake();
        itemID = 20;
        wordName = "厚字典";
        bookName = BookNameEnum.CrystalEnergy;
        description = "加2防御";
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.Ceram;

        rarity = 0;
    }

    public override void UseItem(AbstractCharacter chara)
    {
        base.UseItem(chara);
        chara.def += 2;

    }

    public override void UseVerb()
    {
        base.UseVerb();
    }

    public override void End()
    {
        base.End();
        aim.def -= 2;
    }
}
