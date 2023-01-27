using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class LiuGrandma : AbstractCharacter
{
    override public void Awake()
    {
        base.Awake();
        characterID = 3;
        gender = GenderEnum.girl;
        wordName = "������";
        bookName = BookNameEnum.HongLouMeng;
        nickname.Add( "ĸ�ȳ�");
        trait = gameObject.AddComponent<Enthusiasm>();
        hp =maxHP = 70;
        atk = 5;
        def = 5;
        psy = 5;
        san = 10;
        multipleCriticalStrike = 2;
        attackInterval = 2.2f;
        attackDistance = 200;
        description = "�����ѣ��ǲ�ѩ�������й��ŵ���ѧ��������¥�Ρ��������һλ��������ƶũ��ͥ���������ʵ������ţ���֤�˼ָ���˥�����ȫ���̡�";
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
