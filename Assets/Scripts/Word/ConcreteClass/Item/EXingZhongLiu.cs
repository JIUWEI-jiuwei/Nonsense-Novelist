using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 恶性肿瘤
/// </summary>
class EXingZhongLiu : AbstractItems
{
    /// <summary>充能次数 </summary>
    public int chongNeng;

    public override void Awake()
    {
        base.Awake();
        itemID = 16;
        wordName = "恶性肿瘤";
        bookName = BookNameEnum.FluStudy;
        description = " ";
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.Ceram;

        rarity = 1;
        if (this.gameObject.layer == LayerMask.NameToLayer("WordCollision")) 
            wordCollisionShoots.Add(gameObject.AddComponent<ChongNeng>());
    }

    public override void UseItems(AbstractCharacter chara)
    {
        base.UseItems(chara);
        //充能效果
        chara.maxhp -= 0.05f *chongNeng* chara.maxHP;
    }

    public override void UseVerbs()
    {
        base.UseVerbs();
    }

    public override void End()
    {
        base.End();
    }
}
