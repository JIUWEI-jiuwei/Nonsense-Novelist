using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class JiaGrandma : AbstractCharacter
{
    public void Awake()
    {
        characterID = 10;
        gender = GenderEnum.girl;
        wordName = "¼ÖÄ¸";
        bookName = BookNameEnum.HongLouMeng;
        nickname.Add( "Ê·Ì«¾ý");
        camp = CampEnum.all;
        role = new Parents();
        trait=new Mercy();
        hp=maxHP = 40;
        sp=maxSP = 10;
        atk = 7;
        def = 5;
        psy = 7;
        san = 7;
        criticalChance = 0;
        multipleCriticalStrike = 2;
        attackInterval = 1.3f;
        skillSpeed = 0;
        dodgeChance = 0;
        attackDistance = 5;
        luckyValue = 0;
    }
}
