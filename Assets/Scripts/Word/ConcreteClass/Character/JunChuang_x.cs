using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ¾ú´²
/// </summary>
 class JunChuang_x : AbstractCharacter
{
    override public void Awake()
    {
        base.Awake();
        characterID = 8;
        gender = GenderEnum.noGender;
        wordName = "¾ú´²";
        bookName = BookNameEnum.FluStudy;
        trait = gameObject.AddComponent<NullTrait>();
        hp = maxHP = 30;
        atk = 0;
        def = 3;
        psy = 0;
        san = 999;
        multipleCriticalStrike = 2;
        attackInterval = 2.2f;
        attackDistance = 100;
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
