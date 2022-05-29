using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class WangXiFeng : AbstractCharacter
{
    override public void Awake()
    {
        base.Awake();
        characterID = 4;
        gender = GenderEnum.girl;
        wordName = "王熙凤";
        bookName = BookNameEnum.HongLouMeng;
        brief = "《红楼梦》中一位泼辣且极具备能力的女人。";
        criticalSpeak = "你这赖狗扶不上墙的种子";
        deadSpeak = "纵我机关算尽……";
        camp = CampEnum.all;
        trait = gameObject.AddComponent<Spicy>();
        role = gameObject.AddComponent<Parents>();
        hp=maxHP = 50;
        sp=maxSP = 15;
        atk = 10;
        def = 1;
        psy = 10;
        san = 3;
        criticalChance = 0;
        multipleCriticalStrike = 2;
        attackInterval = 1.3f;
        skillSpeed = 0;
        dodgeChance = 0;
        attackDistance = 2;
        luckyValue = 0;
        importantNum.AddRange(new int[] { 3 });
        bg_text = "王熙凤，曹雪芹所著中国古典小说《红楼梦》中的人物，金陵十二钗之一，贾琏的妻子。在贾府掌握实权，为人心狠手辣，八面玲珑，敢爱敢恨，做事决绝。因其深爱丈夫贾琏，故而十分善妒，暗中算计害死尤二姐。王熙凤在被休后王家不容她,在监牢里血崩病发,流尽鲜血而死。";
        mainSort = MainSortEnum.atk;
    }
    private void Start()
    {
        camp = CampEnum.friend;
    }
}
