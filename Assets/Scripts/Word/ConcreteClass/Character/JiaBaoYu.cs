using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class JiaBaoYu : AbstractCharacter
{
    override public void Awake()
    {
        base.Awake();
        characterID = 8;
        gender = GenderEnum.boy;
        wordName = "¼Ö±¦Óñ";
        bookName = BookNameEnum.HongLouMeng;
        camp = CampEnum.friend;
        role = gameObject.AddComponent<Noble>();
        trait = gameObject.AddComponent<Obsessed>();
        hp=maxHP  = 60;
        sp=maxSP = 10;
        atk = 7;
        def = 3;
        psy = 8;
        san = 0;
        criticalChance = 0;
        multipleCriticalStrike = 2;
        attackInterval = 1.3f;
        skillSpeed = 0;
        dodgeChance = 0;
        attackDistance = 6;
        luckyValue = 0;
        
    }
}
