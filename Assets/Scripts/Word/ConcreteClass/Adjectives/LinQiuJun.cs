using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ÁÜÇò¾ú
/// </summary>
class LinQiuJun : AbstractAdjectives
{

    public override void Awake()
    {
        base.Awake();
        adjID = 6;
        wordName = "ÁÜÇò¾ú";
        bookName = BookNameEnum.Epidemiology;
        chooseWay = ChooseWayEnum.canChoose;
        banAim.Add(gameObject.AddComponent<Biology>());
        skillMode=gameObject.AddComponent<DamageMode>();
        percentage = 10;
        skillEffectsTime = 3;
        useAtFirst = false;

    }


    /// <summary>
    /// 10¹Ì¶¨ÎïÀíÉËº¦
    /// </summary>
    /// <param name="aimCharacter"></param>
    override public void UseVerbs(AbstractCharacter aimCharacter)
    {
        aimCharacter.hp-=(int)percentage; 
    }

    public override void SpecialAbility(AbstractCharacter aimCharacter)
    {
       
    }

        
}
