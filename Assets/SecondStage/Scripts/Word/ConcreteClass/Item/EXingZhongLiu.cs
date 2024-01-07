using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 恶性肿瘤
/// </summary>
class EXingZhongLiu : AbstractItems,IChongNeng
{
    public float maxHPAdd;
    public float record;
    public override void Awake()
    {
        base.Awake();
        itemID = 16;
        wordName = "恶性肿瘤";
        bookName = BookNameEnum.FluStudy;
        description = "充能：减5%生命上限";
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.Ceram;
        rarity = 1;
        if (this.gameObject.layer == LayerMask.NameToLayer("WordCollision"))
            wordCollisionShoots[0] = gameObject.AddComponent<ChongNeng>();
    }

    public void ChongNeng(int times)
    {
        maxHPAdd += 0.05f*times;
    }

    public override void UseItem(AbstractCharacter chara)
    {
        base.UseItem(chara);
        record = chara.maxHp * maxHPAdd;
        chara.maxHp -= record;
    }

    public override void UseVerb()
    {
        base.UseVerb();
    }

    public override void End()
    {
        aim.maxHp += record;
        base.End();
    }

    
}
