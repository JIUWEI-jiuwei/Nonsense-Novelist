using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// buff：亢奋
/// </summary>
public class KangFen : AbstractBuff
{
    override protected void Awake()
    {
        base.Awake();
        buffName = "亢奋";
        description = "为缺少3能量及以上的动词提供1能量，消除自身";
        book = BookNameEnum.ZooManual;

        //缺少能量的补充


        Destroy(this);
    }

  
    private void OnDestroy()
    {
       
    }
}
