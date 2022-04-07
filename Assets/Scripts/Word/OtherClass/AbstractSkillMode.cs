using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 技能类型
/// </summary>
public class AbstractSkillMode : MonoBehaviour
{
    /// <summary>技能类型序号</summary>
    public int skillModeID;
    /// <summary>技能类型名称</summary>
    public string skillModeName;
    /// <summary>目标阵营优先级</summary>
    private List<CampEnum> campOrder;
    /// <summary>目标身份优先级(和↓二选一）</summary>
    private List<AbstractRole> roleOrder;
    /// <summary>目标性格优先级(和↑二选一）</summary>
    private List<AbstractTrait> traitOrder;

    /// <summary>是否优先选择低血量</summary>
    private bool chooseMinHp;
}
