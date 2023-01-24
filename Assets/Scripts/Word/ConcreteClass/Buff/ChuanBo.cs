using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChuanBo: AbstractBuff
{
    override protected void Awake()
    {
        base.Awake();
        buffName = "´«²¥";
        book = BookNameEnum.FluStudy;
        upup= 1;
    }


}
