using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 所有词条的CD
/// </summary>
public interface ICD
{
    /// <summary>
    /// 词条CD冷却
    /// </summary>
    /// <param name="cd"></param>
    /// <param name="maxCD"></param>
    /// <param name="isFirst"></param>
    /// <param name="b_CDCooled"></param>
   abstract public void CDTime(float cd, float maxCD,bool isFirst, bool b_CDCooled);
}
