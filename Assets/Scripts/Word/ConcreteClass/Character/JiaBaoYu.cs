using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class JiaBaoYu : AbstractCharacter
{
    override public void Awake()
    {
        base.Awake();
        characterID = 3;
        wordName = "�ֱ���";
        bookName = BookNameEnum.HongLouMeng;
        gender = GenderEnum.girl;
        hp = maxHP = 80;
        atk = 3;
        def = 3;
        psy = 5;
        san = 3;
        mainProperty.Add("����", "Զ��dps");
        trait = gameObject.AddComponent<Sentimental>();
        attackInterval = 2.2f;
        attackDistance = 5;
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
