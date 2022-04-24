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
        skillMode = new DamageMode();  
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
    override public void CDTime(float cd, float maxCD, bool isFirst, bool b_CDCooled)//只有开局摇盒子时，isFirst=true，其他时候为false
    {
        this.cd = cd;
        this.maxCD = maxCD;
        this.isFirst = isFirst;
        this.b_CdCooled = b_CDCooled;
        
        //开局
        if (isFirst) b_CDCooled = true;

        //局中
        else
        {
            b_CDCooled = false;
            cd += Time.deltaTime;

            //CD已好
            if (cd == maxCD)
            {
                b_CDCooled = true;

            }
        }
    }
}
