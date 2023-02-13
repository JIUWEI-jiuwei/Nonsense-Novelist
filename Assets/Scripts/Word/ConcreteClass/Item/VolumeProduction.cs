using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ������װ��
/// </summary>
class VolumeProduction : AbstractItems
{
    public override void Awake()
    {
        itemID = 14;
        wordName = "������װ��";
        bookName = BookNameEnum.ElectronicGoal;
        description = "һ�Ŵ�����Ͼ�İ�ɫˮ����������ά���Ը�1�㡣";
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.Ceram;

        rarity = 0;
        wordCollisionShoots.Add(gameObject.AddComponent<SanShe>());

    }

    public override void UseItems(AbstractCharacter chara)
    {
        base.UseItems(chara);
    }

    public override void UseVerbs()
    {
        base.UseVerbs();
        buffs.Add(gameObject.AddComponent<GaiZao>());
        buffs[0].maxTime = Mathf.Infinity;
    }

    public override void End()
    {
        base.End();
    }
}
