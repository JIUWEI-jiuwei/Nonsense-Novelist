using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class Rat : AbstractCharacter
{
    override public void Awake()
    {
        base.Awake();
        characterID = 6;
        wordName = "林黛玉";
        bookName = BookNameEnum.ZooManual;
        gender = GenderEnum.noGender;
        hp = maxHP = 150;
        atk = 4;
        def = 4;
        psy = 3;
        san = 3;
        mainProperty.Add("攻击", "近物dps");
        trait = gameObject.AddComponent<Possessive>();
        criticalChance = 30;
        attackInterval = 2;
        attackDistance = 1;
        importantNum.AddRange(new int[] { 8 });
        brief = "肮脏且会偷窃物品的老鼠。";
        description = "肮脏且会偷窃物品的老鼠。";
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
