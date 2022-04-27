using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ������
/// </summary>
class LengXiangPill : AbstractItems
{
    public void Awake()
    {
        itemID = 2;
        wordName = "������";
        bookName = BookNameEnum.HongLouMeng;
        description = "һ�����д����ġ������ɷ������������൱���ӵ�ҩ��";
        camp = CampEnum.all;
        banUse.Add(gameObject.AddComponent<Biology>());
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.materialNull;
        withSkill = gameObject.AddComponent<LengXiangPillSkill>();
        level = 1;
    }
}
