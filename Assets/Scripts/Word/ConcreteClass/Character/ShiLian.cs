using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ʧ��
/// </summary>
class ShiLian : AbstractCharacter
{
    override public void Awake()
    {
        base.Awake();
        characterID = 12;
        wordName = "ʧ��";
        bookName = BookNameEnum.Salome;
        gender = GenderEnum.noGender;
        hp = maxHP = 120;
        atk = 3;
        def = 4;
        psy = 5;
        san = 3;
        mainProperty.Add("����", "�з�dps");
        trait = gameObject.AddComponent<Vicious>();
        attackInterval = 2.2f;
        attackDistance = 3;
        brief = "����¥�Ρ���һλ�Ը����д�����ȴ�ּ������Ե���Ů��";
        description = "�������й��ŵ���������¥�Ρ���Ů���ǣ�����ʮ��������˫��֮һ��������Ӱ�����ɲ�ת��������ڼֱ���Ѧ���δ��֮ҹ�ᾡ���š���������ò����������ʫ�ţ��ǹŴ���ѧ��Ʒ�м��������ľ���Ů������" +
            "\n���ǣ�" +
            "\n��̾ͣ���£�����ӽ���š�" +
            "\n������йң�����ѩ����";
    }

    public override string ShowText(AbstractCharacter otherChara)
    {
        return "";
    }

    public override string CriticalText(AbstractCharacter otherChara)
    {
        return "";
    }

    public override string LowHPText()
    {
        return "";
    }
    public override string DieText()
    {
        return "";
    }
}
