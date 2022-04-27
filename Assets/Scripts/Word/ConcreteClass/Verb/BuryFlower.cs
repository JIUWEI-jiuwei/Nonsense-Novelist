using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 葬花
/// </summary>
class BuryFlower : AbstractVerbs
{
    public void Awake()
    {
        skillID = 3;
        wordName = "葬花";
        bookName = BookNameEnum.HongLouMeng;
        description = "平生葬花杀人，我以落花剑葬你，不枉你异人之名";
        skillMode = gameObject.AddComponent<UpPSYMode>();
        skillMode.attackRange = new CircleAttackSelector();//
        attackDistance = 0;
        skillTime = 7;
        skillEffectsTime = 0;
        cd=maxCD=40;
        comsumeSP = 15;
        prepareTime = 1f;
        afterTime = 0;
        allowInterrupt = true;
        possibility = 0;

    }

    public override void SpecialAbility()
    {

    }
    
}
