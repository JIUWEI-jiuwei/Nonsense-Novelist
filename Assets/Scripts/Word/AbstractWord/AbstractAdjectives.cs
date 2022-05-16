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
    /// <summary>目标特效</summary>
    public Animation anim;
    /// <summary>作用范围类型（具体实现在UI脚本判断此字段）</summary>
    public ChooseWayEnum chooseWay;
    /// <summary>目标限制（不能向谁使用）</summary>
    public List<AbstractRoleLimit> banAim=new List<AbstractRoleLimit>();
    /// <summary>技能类型 </summary>
    public AbstractSkillMode skillMode;
    /// <summary>技能强度(在这两数间取随机)，或造成 某值n%（percentage写小数） 的伤害</summary>
    public float skillMinStrength, skillMaxStrength, percentage;
    /// <summary>射程</summary>
    public float attackDistance;
    /// <summary>技能持续时长（已持续时间变量现场声明） </summary>
    public float skillTime;
    /// <summary>技能效果(特殊后续效果）持续时长 </summary>
    public float skillEffectsTime;
    /// <summary>是否抽到时释放</summary>
    public bool useAtFirst;

    public virtual void Awake()
    {
        wordSort = WordSortEnum.adj;
    }
    /// <summary>
    /// 技能效果(特殊效果）
    /// </summary>
    virtual public void SpecialAbility()
    {

    }

    /// <summary>
    /// 仅用于↓（目标数组）
    /// </summary>
    protected GameObject[] aims;
    /// <summary>
    /// 使用技能
    /// </summary>
    /// <param name="aimCharacter">目标</param>
    virtual public void UseVerbs(AbstractCharacter aimCharacter)
    {
        
    }
}
