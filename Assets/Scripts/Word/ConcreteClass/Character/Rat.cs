using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class Rat : AbstractCharacter
{
    override public void Awake()
    {
        base.Awake();
        characterID = 6;
        wordName = "老鼠";
        bookName = BookNameEnum.ZooManual;
        gender = GenderEnum.noGender;
        hp = maxHP = 150;
        atk = 4;
        def = 4;
        psy = 3;
        san = 3;
        mainProperty.Add("攻击", "近物dps");
        trait = gameObject.AddComponent<Possessive>();
        roleName = "小偷";
        attackInterval = 1.7f;
        attackDistance = 1;
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
