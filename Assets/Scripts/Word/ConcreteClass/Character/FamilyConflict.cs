using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class FamilyConflict : AbstractCharacter
{
    override public void Awake()
    {
        base.Awake();
        characterID = 5;
        gender = GenderEnum.noGender;
        wordName = "��ͥì��";
        bookName = BookNameEnum.allBooks;
        
        criticalSpeak = "����ô��������ô������";
        deadSpeak = "���Ӿ����ǳ�����";
        role = gameObject.AddComponent<Parents>();
        trait = gameObject.AddComponent<Pride>();
        hp =maxHP = 40;
        sp=maxSP = 10;
        atk = 7;
        def = 3;
        psy = 0;
        san = 10;
        criticalChance = 0;
        multipleCriticalStrike = 2;
        attackInterval = 1.3f;
        skillSpeed = 0;
        dodgeChance = 0;
        attackDistance = 2;
        luckyValue = 0;
        enemyLevel = 2;
        mainSort = MainSortEnum.san;
        brief = "������˹�ϵ�񻯶����µĿ���";
        description = "������˹�ϵ�񻯶����µĿ���";
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
