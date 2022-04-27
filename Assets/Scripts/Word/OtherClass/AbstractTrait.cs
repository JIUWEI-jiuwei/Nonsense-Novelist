using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 抽象性格【不用】
/// </summary>
abstract class AbstractTrait : MonoBehaviour
{
    /// <summary>性格ID </summary>
    public int traitID;
    /// <summary>性格名 </summary>
    public string traitName;
    /// <summary>性格描述 </summary>
    public string description;
    /// <summary>蓝量成长 </summary>
    public int growSP;
    /// <summary>精神力成长 </summary>
    public float growPSY;
    /// <summary>意志力成长 </summary>
    public float growSAN;
    /// <summary>受克制的性格序号，克制强度（小数）</summary>
    public Dictionary<int, float> restrainRole=new  Dictionary<int, float>();
}
