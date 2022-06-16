using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class Rat : AbstractCharacter
{
    override public void Awake()
    {
        base.Awake();
        characterID = 9;
        gender = GenderEnum.noGender;
        wordName = "¿œ Û";
        bookName = BookNameEnum.allBooks;
        camp = CampEnum.enemy ;
        role = gameObject.AddComponent<Beast>();
        trait=gameObject.AddComponent<NullTrait>();
        hp=maxHP  = 60;
        sp=maxSP = 20;
        atk = 7;
        def = 0;
        psy = 0;
        san = 3;
        criticalChance = 0;
        multipleCriticalStrike = 2;
        attackInterval = 1.5f;
        skillSpeed = 0;
        dodgeChance = 0;
        attackDistance = 1;
        luckyValue = 0;
        enemyLevel = 1;
        mainSort = MainSortEnum.atk;
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
