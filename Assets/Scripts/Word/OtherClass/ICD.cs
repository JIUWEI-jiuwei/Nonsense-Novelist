using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ���д�����CD
/// </summary>
public interface ICD
{
    /// <summary>
    /// ����CD��ȴ
    /// </summary>
    /// <param name="cd"></param>
    /// <param name="maxCD"></param>
    /// <param name="isFirst"></param>
    /// <param name="b_CDCooled"></param>
   abstract public void CDTime(float cd, float maxCD,bool isFirst, bool b_CDCooled);
}
