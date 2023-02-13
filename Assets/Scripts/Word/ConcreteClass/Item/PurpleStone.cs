using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ��ˮ��
/// </summary>
class PurpleStone: AbstractItems
{
    public override void Awake()
    {
        itemID = 9;
        wordName = "��ˮ��";
        bookName = BookNameEnum.CrystalEnergy;
        description = "һ������ɫ�߽��ˮ��������3�㾫��������ǿ����������";
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.Ceram;

        rarity = 1;
        wordCollisionShoots.Add(gameObject.AddComponent<JiHuo>());

    }

    public override void UseItems(AbstractCharacter chara)
    {
        base.UseItems(chara);
        chara.psy += 4;

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
        aim.psy -= 4;
    }
}
