using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class Rat : AbstractCharacter
{
    public void Awake()
    {
        characterID = 9;
        gender = GenderEnum.noGender;
        wordName = "����";
        bookName = BookNameEnum.allBooks;
        camp = CampEnum.enemy ;
        role = new Beast ();
        trait=new NullTrait ();
        hp=maxHP  = 20;
        sp=maxSP = 0;
        atk = 7;
        def = 1;
        psy = 0;
        san = 999;
        criticalChance = 0;
        multipleCriticalStrike = 2;
        attackInterval = 1.3f;
        skillSpeed = 0;
        dodgeChance = 0;
        attackDistance = 1;
        luckyValue = 0;
        enemyLevel = 1;
    }
}
