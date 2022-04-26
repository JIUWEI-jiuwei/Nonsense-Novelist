using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class LinDaiYu : AbstractCharacter
{
    public void Awake()
    {
        characterID = 1;
        gender = GenderEnum.girl;
        wordName = "������";
        description = "����¥�Ρ��еĽ�ɫ";
        bookName = BookNameEnum.HongLouMeng;
        nickname.Add("������");
        nickname.Add("��������");
        nickname.Add("�ֹ���");
        criticalSpeak = "��л���ɻ�����";
        deadSpeak = "���������˭����";
        camp = CampEnum.friend;
        role = new Noble();
        trait = new Sentimental();
        hp =maxHP  = 50;
        sp=maxSP = 40;
        atk = 3;
        def = 0;
        psy = 20;
        san = 3;
        criticalChance = 0;
        multipleCriticalStrike = 2;
        attackInterval = 1.5f;
        skillSpeed = 0;
        dodgeChance = 0;
        attackDistance = 6;
        luckyValue = 0;
        
    }
}
