using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChuanBo: AbstractBuff
{
    override protected void Awake()
    {
        base.Awake();
        buffName = "����";
        book = BookNameEnum.FluStudy;
        upup= 1;
    }


}
