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
    /// <summary>克制的?????二阶段再说</summary>
    public Dictionary<int, int> restrainRole;
}
