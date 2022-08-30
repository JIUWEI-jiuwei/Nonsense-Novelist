using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class JiaGrandma : AbstractCharacter
{
    override public void Awake()
    {
        base.Awake();
        characterID = 10;
        gender = GenderEnum.girl;
        wordName = "贾母";
        bookName = BookNameEnum.HongLouMeng;
        nickname.Add( "史太君");
        role = gameObject.AddComponent<Parents>();
        trait=gameObject.AddComponent<Mercy>();
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
        importantNum.AddRange(new int[] { 8, 3 });
        bg_text = "贾母，又称史老太君，贾府上下尊称她为“老太太”、“老祖宗”，是曹雪芹所著中国古典小说《红楼梦》中的主要角色之一，是贾府名义上的最高统治者，一生享尽荣华富贵。";
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
