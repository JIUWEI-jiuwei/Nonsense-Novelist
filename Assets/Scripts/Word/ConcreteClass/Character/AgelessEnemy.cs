using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class AgelessEnemy : AbstractCharacter
{
    public void Awake()
    {
        characterID = 6;
        gender = GenderEnum.noGender;
        wordName = "�޵�";
        bookName = BookNameEnum.allBooks;
        description = "�����������ȥ�����Ҳ�֪Ϊ�����ǻ᲻�������Է�";
        criticalSpeak = "�������̫����";
        deadSpeak = "����㣿��ô���ܣ�";
        camp = CampEnum.enemy;
        role = new OldEnemy();
        trait=new Pride();
        hp=maxHP = 70;
        sp=maxSP = 20;
        atk = 15;
        def = 2;
        psy = 7;
        san = 2;
        criticalChance = 0;
        multipleCriticalStrike = 2;
        attackInterval = 1.3f;
        skillSpeed = 0;
        dodgeChance = 0;
        attackDistance = 6;
        luckyValue = 0;
        enemyLevel = 3;
    }
}
