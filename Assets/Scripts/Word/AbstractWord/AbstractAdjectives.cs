using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 形容词（状态）
/// </summary>
abstract class AbstractAdjectives : AbstractWords0
{
    /// <summary>技能序号</summary>
    public int adjID;
    /// <summary>身份限制（不能获得该形容词的身份）</summary>
    public List<AbstractRole> banRole;
    /// <summary>状态持续时间 </summary>
    public float maxTime;
    /// <summary>状态效果《状态类型，数值》 </summary>
    public Dictionary<AbstractAdjMode, int> effect;
}
