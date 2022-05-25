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
        deadSpeak = "����Ǵ��԰��";
        camp = CampEnum.friend  ;
        role = gameObject.AddComponent<Country>();
        trait = gameObject.AddComponent<Enthusiasm>();
        hp =maxHP = 70;
        sp=maxSP = 10;
        atk = 5;
        def = 5;
        psy = 5;
        san = 10;
        criticalChance = 0;
        multipleCriticalStrike = 2;
        attackInterval = 2;
        skillSpeed = 0;
        dodgeChance = 0;
        attackDistance = 2;
        luckyValue = 0;
        importantNum.AddRange(new int[] { 4, 10 });
        bg_text = "�����ѣ��ǲ�ѩ�������й��ŵ���ѧ��������¥�Ρ��������һλ��������ƶũ��ͥ���������ʵ������ţ���֤�˼ָ���˥�����ȫ���̡�";
        mainSort = MainSortEnum.san;
    }
}
