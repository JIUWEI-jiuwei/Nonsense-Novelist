using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 影响区域（直线、扇形、圆形）
/// </summary>
public interface  IAttackRange
{
    /// <summary>
    /// 计算影响区域内目标
    /// </summary>
    /// <param name="attackDistance">射程</param>
    /// <param name="ownTrans">使用者位置</param>
    /// <param name="extra">额外值</param>
    /// <returns>返回区域内目标数组</returns>
    abstract public GameObject[] AttackRange(float attackDistance,Transform ownTrans,float extra);
}
