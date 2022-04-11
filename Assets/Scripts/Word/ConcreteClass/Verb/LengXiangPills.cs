using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ¿‰œ„ÕË
/// </summary>
class LengXiangPills : AbstractVerbs
{
    public LengXiangPills()
    {
        wordName = "¿‰œ„ÕË";
        bookName = BookNameEnum.HongLouMeng;
        description = "°≠°≠";
        nickname = "°≠°≠";
        skillMode = new ReturnBlood();
        //ººƒ‹«ø∂»∏È÷√
        attackDistance = 2;
        skillTime = 0f;
        comsumeSP = 0;
        prepareTime = 0.5f;
        afterTime = 0;
        allowInterrupt = false;
        possibility = 0;
    }
    public override void Ability()
    {

    }
}
