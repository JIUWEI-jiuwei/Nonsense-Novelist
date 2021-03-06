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
        wordName = "家庭矛盾";
        bookName = BookNameEnum.allBooks;
        brief = "因与家人关系恶化而导致的苦恼";
        description = "因与家人关系恶化而导致的苦恼";
        criticalSpeak = "我怎么养了你这么个东西";
        deadSpeak = "孩子究竟是长大了";
        camp = CampEnum.enemy;
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
        bg_text = "因与家人关系恶化而导致的苦恼";
        mainSort = MainSortEnum.san;
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
