using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class LinDaiYu : AbstractCharacter
{
    override public void Awake()
    {
        base.Awake();
        characterID = 1;
        gender = GenderEnum.girl;
        wordName = "林黛玉";
        brief = "《红楼梦》中一位性格敏感脆弱，却又极有灵性的少女。";
        description = "《红楼梦》中的角色";
        bookName = BookNameEnum.HongLouMeng;
        nickname.Add("林妹妹");
        nickname.Add("潇湘妃子");
        nickname.Add("林姑娘");
        criticalSpeak = "花谢花飞花满天";
        deadSpeak = "红消香断有谁怜？";
        camp = CampEnum.friend;
        role = gameObject.AddComponent<Noble>();
        trait = gameObject.AddComponent<Sentimental>();
        hp =maxHP  = 40;
        sp=maxSP = 40;
        atk = 3;
        def = 0;
        psy = 20;
        san = 3;
        criticalChance = 0;
        multipleCriticalStrike = 2;
        attackInterval = 1.5f;
        skillSpeed = 0;
        dodgeChance = 0;
        attackDistance = 6;
        luckyValue = 0;
        
    }
}
