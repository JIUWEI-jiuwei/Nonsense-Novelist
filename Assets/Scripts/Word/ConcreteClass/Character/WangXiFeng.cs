using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class WangXiFeng : AbstractCharacter
{
    override public void Awake()
    {
        base.Awake();
        characterID = 4;
        gender = GenderEnum.girl;
        wordName = "������";
        bookName = BookNameEnum.HongLouMeng;
        brief = "����¥�Ρ���һλ�����Ҽ��߱�������Ů�ˡ�";
        criticalSpeak = "��������������ǽ������";
        deadSpeak = "���һ����㾡����";
        camp = CampEnum.all;
        trait = gameObject.AddComponent<Spicy>();
        role = gameObject.AddComponent<Parents>();
        hp=maxHP = 50;
        sp=maxSP = 15;
        atk = 10;
        def = 1;
        psy = 10;
        san = 3;
        criticalChance = 0;
        multipleCriticalStrike = 2;
        attackInterval = 1.3f;
        skillSpeed = 0;
        dodgeChance = 0;
        attackDistance = 2;
        luckyValue = 0;
        importantNum.AddRange(new int[] { 3 });

    }
}
