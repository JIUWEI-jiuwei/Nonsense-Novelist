using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class FamilyConflict_x : AbstractCharacter
{
    override public void Awake()
    {
        base.Awake();
        characterID = 5;
        gender = GenderEnum.noGender;
        wordName = "��ͥì��";
        bookName = BookNameEnum.allBooks;
        
        trait = gameObject.AddComponent<Pride>();
        hp =maxHP = 40;
        atk = 7;
        def = 3;
        psy = 0;
        san = 10;
        multipleCriticalStrike = 2;
        attackInterval = 2.2f;
        attackDistance = 200;
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
