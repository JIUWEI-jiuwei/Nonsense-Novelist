using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 毒腺
/// </summary>
class DuXian : AbstractItems
{
    public override void Awake()
    {
        base.Awake();
        itemID = 18;
        wordName = "毒腺";
        bookName = BookNameEnum.CrystalEnergy;
        description = "攻击附带“腐蚀”";
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
