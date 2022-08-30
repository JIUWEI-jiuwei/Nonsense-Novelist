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
        wordName = "贾宝玉";
        bookName = BookNameEnum.HongLouMeng;
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
        importantNum.AddRange(new int[] { 1, 10 });
        bg_text = "贾宝玉，中国古典名著《红楼梦》中的男主角。前世真身为赤霞宫神瑛侍者，荣国府贾政与王夫人所生的次子。因衔通灵宝玉而诞，系贾府玉字辈嫡孙，故名贾宝玉，贾府通称宝二爷。他与林黛玉青梅竹马，互为知己，发展成一段世间少有的纯洁感情，自身又在家族安排下糊里糊涂与薛宝钗结婚，致使林黛玉泪尽而逝";
        mainSort = MainSortEnum.psy;
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
