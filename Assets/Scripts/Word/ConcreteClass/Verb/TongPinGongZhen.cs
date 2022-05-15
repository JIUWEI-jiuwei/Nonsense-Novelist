using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 同频共振
/// </summary>
class TongPinGongZhen: AbstractVerbs
{
    public void Awake()
    {
        skillID = 9;
        wordName = "同频共振";
        bookName = BookNameEnum.CrystalEnergy;
        banUse.Add(gameObject.AddComponent<Girl>());
        skillMode = gameObject.AddComponent<UpATKMode>();
        skillMode.attackRange = new CircleAttackSelector();
        percentage = 0;
        attackDistance = 5;
        skillTime = 0;
        skillEffectsTime = 1.5f;
        cd=maxCD=5;
        comsumeSP = 10;
        prepareTime = 1;
        afterTime = 0;
        allowInterrupt = false;
        possibility = 0;
    }

    private AbstractCharacter aimState;//目标的抽象角色类
    /// <summary>
    /// 让所有友军回复5点SP
    /// </summary>
    /// <param name="useCharacter">施法者</param>
    public override void UseVerbs(AbstractCharacter useCharacter)
    {
        base.UseVerbs(useCharacter);
        foreach (GameObject aim in aims)
        {
            aimState = aim.GetComponent<AbstractCharacter>();
        }
        SpecialAbility(useCharacter);
    }

    /// <summary>
    /// 让所有敌人晕眩1.5秒
    /// </summary>
    public override void SpecialAbility(AbstractCharacter useCharacter)
    {
        foreach (GameObject aim in aims)
        {
            AbstractCharacter a = aim.GetComponent<AbstractCharacter>();
            a.dizzyTime = skillEffectsTime;
            a.AddBuff(5);
        }
    }

}
