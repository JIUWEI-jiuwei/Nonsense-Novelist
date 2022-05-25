using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class JiaGrandma : AbstractCharacter
{
    override public void Awake()
    {
        base.Awake();
        characterID = 10;
        gender = GenderEnum.girl;
        wordName = "��ĸ";
        bookName = BookNameEnum.HongLouMeng;
        nickname.Add( "ʷ̫��");
        camp = CampEnum.all;
        role = gameObject.AddComponent<Parents>();
        trait=gameObject.AddComponent<Mercy>();
        hp=maxHP = 40;
        sp=maxSP = 10;
        atk = 7;
        def = 5;
        psy = 7;
        san = 7;
        criticalChance = 0;
        multipleCriticalStrike = 2;
        attackInterval = 1.3f;
        skillSpeed = 0;
        dodgeChance = 0;
        attackDistance = 5;
        luckyValue = 0;
        importantNum.AddRange(new int[] { 8, 3 });
        bg_text = "��ĸ���ֳ�ʷ��̫�����ָ����������Ϊ����̫̫�����������ڡ����ǲ�ѩ�������й��ŵ�С˵����¥�Ρ��е���Ҫ��ɫ֮һ���Ǽָ������ϵ����ͳ���ߣ�һ�����ٻ�����";
        mainSort = MainSortEnum.san;
    }
}
