using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class FamilyConflict : AbstractCharacter
{
    public FamilyConflict()
    {
        characterID = 5;
        gender = GenderEnum.noGender;
        appearance = 5;
        wordName = "家庭矛盾";
        bookName = BookNameEnum.allBooks;
        nickname = null;
        criticalSpeak = "我怎么养了你这么个东西";
        deadSpeak = "孩子究竟是长大了";
        maxHP = 40;
        maxSP = 10;
        atk = 7;
        def = 3;
        psy = 0;
        san = 10;
        criticalChance = 0;
        multipleCriticalStrike = 2;
        attackSpeed = 1.3f;
        skillSpeed = 0;
        luckyValue = 0;
    }
}
