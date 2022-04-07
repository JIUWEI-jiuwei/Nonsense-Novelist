using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 抽象身份
/// </summary>
abstract class AbstractRole : MonoBehaviour
{
    /// <summary>身份序号 </summary>
    public int rooleID;
    /// <summary>身份名称 </summary>
    public string name;
    /// <summary>身份描述 </summary>
    public string description;
    /// <summary>克制的?????二阶段再说 </summary>
    public Dictionary<int, int> restrainRole;
}
