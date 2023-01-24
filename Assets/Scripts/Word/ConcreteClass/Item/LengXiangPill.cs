using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ��ҩ
/// </summary>
class LengXiangPill : AbstractItems
{
    public void Awake()
    {
        itemID = 2;
        wordName = "������";
        bookName = BookNameEnum.HongLouMeng;
        getWay = GetWayEnum.NormalWord;
        description = "һö�����൱���ӵ�ҩ�裬����3�������";
        holdEnum = HoldEnum.handSingle;
        VoiceEnum = MaterialVoiceEnum.materialNull;
        withSkill = gameObject.AddComponent<FuYao>();


    }
    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return "��ĵ������׺ɻ������ܽ�ػ����÷������......��ʮ��δ�ض����������������������أ���" + character.wordName + "˵����";

    }
}
