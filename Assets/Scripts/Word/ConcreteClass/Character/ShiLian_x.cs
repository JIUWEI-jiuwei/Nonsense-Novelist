using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ʧ����2���֣�
/// </summary>
class ShiLian_x : AbstractCharacter
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
        criticalChance = 0;
        attackInterval = 2;
        attackDistance = 3;
        importantNum.AddRange(new int[] { 8 });
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
