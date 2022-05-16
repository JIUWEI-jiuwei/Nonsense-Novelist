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
        getWay = GetWayEnum.NormalWord;
        description = "һ�����д����ġ������ɷ������������൱���ӵ�ҩ��";
        camp = CampEnum.all;
        banUse.Add(gameObject.AddComponent<Biology>());
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.materialNull;
        withSkill = gameObject.AddComponent<LengXiangPillSkill>();


    }
    public override string PlaySentence()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return "�����¶ˮ�����ۡ�����������䷽��ô��ô���ӣ���" + character.wordName + "˵����";

    }
}
