using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class JiaGrandma_x : AbstractCharacter
{
    override public void Awake()
    {
        base.Awake();
        characterID = 10;
        gender = GenderEnum.girl;
        wordName = "��ĸ";
        bookName = BookNameEnum.HongLouMeng;
        nickname.Add( "ʷ̫��");
        trait=gameObject.AddComponent<Mercy>();
        hp=maxHP = 40;
        atk = 7;
        def = 5;
        psy = 7;
        san = 7;
        multipleCriticalStrike = 2;
        attackInterval = 2.2f;
        attackDistance = 5;
        description = "��ĸ���ֳ�ʷ��̫�����ָ����������Ϊ����̫̫�����������ڡ����ǲ�ѩ�������й��ŵ�С˵����¥�Ρ��е���Ҫ��ɫ֮һ���Ǽָ������ϵ����ͳ���ߣ�һ�����ٻ�����";
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
