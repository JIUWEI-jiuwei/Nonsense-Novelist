using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 淋球菌
/// </summary>
class LinQiuJun : AbstractAdjectives
{

    public override void Awake()
    {
        base.Awake();
        adjID = 6;
        wordName = "淋球菌";
        bookName = BookNameEnum.Epidemiology;
        chooseWay = ChooseWayEnum.canChoose;
        banAim.Add(gameObject.AddComponent<Biology>());
        skillMode=gameObject.AddComponent<DamageMode>();
        percentage = 10;
        skillEffectsTime = 3;
        useAtFirst = false;
        description = "全称为淋病奈瑟球菌，仅寄生于人类，以性传播为主。";
    }


    /// <summary>
    /// 10固定物理伤害
    /// </summary>
    /// <param name="aimCharacter"></param>
    override public void UseVerbs(AbstractCharacter aimCharacter)
    {
        base.UseVerbs(aimCharacter);
        aimCharacter.hp-=(int)percentage; 
    }

    public override void SpecialAbility(AbstractCharacter aimCharacter)
    {
       
    }

    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return character.wordName + "的身体开始产生一些令人作呕的分泌物，而这似乎会传播至其他人。";

    }
}
