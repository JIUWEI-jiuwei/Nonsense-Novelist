using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �޵У���ʱ���ã�
/// </summary>
class AgelessEnemy : AbstractCharacter
{
    override public void Awake()
    {
        base.Awake();
        characterID = -1;
        gender = GenderEnum.noGender;
        wordName = "�޵�";
        bookName = BookNameEnum.allBooks;
        description = "�����������ȥ�����Ҳ�֪Ϊ�����ǻ᲻�������Է�";
        criticalSpeak = "�������̫����";
        deadSpeak = "����㣿��ô���ܣ�";     
        role = gameObject.AddComponent<OldEnemy>();
        trait = gameObject.AddComponent<Pride>();
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
