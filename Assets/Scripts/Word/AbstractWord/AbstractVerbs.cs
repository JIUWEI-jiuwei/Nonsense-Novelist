using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 抽象动词类（技能）
/// </summary>
abstract class AbstractVerbs : AbstractWords0 
{
    /// <summary>技能序号</summary>
    public int skillID;

    //施法者技能特效序号

    //作用者技能特效序号

    /// <summary>技能使用者身份限制（谁不能使用）</summary>
    public List<AbstractRole> banUse;
    /// <summary>目标限制（不能向谁使用）</summary>
    public List<AbstractRole> banAim;


    /// <summary>技能类型 </summary>
<<<<<<< HEAD
    public AbstractSkillMode skillMode;
    /// <summary>射程</summary>
    public float attackDistance;
    /// <summary>影响区域（直线、扇形、圆形）</summary>
    public AbstractAttackRange attackRange;
    /// <summary>攻击次数（比如三连击）</summary>
    public int attacktimes=1;
=======
    public AbstractSkillMode skillMode;   
>>>>>>> master
    /// <summary>技能强度(在这两数间取随机)，或额外造成 某值 的n%伤害</summary>
    public float skillMinStrength, skillMaxStrength;


    /// <summary>消耗蓝量</summary>
    public float comsumeSP;
    /// <summary>当前能量（不用CD，改为随着时间和平A次数增长，到满可以释放）</summary>
    public float nowEnergy;
    /// <summary>总能量</summary>
    public float maxEnergy;


    /// <summary>技能持续时长（已持续时间变量现场声明） </summary>
    public float skillTime;
    /// <summary>施法时长：前摇，后摇（已施法时间变量现场声明）【不用】</summary>
    public float prepareTime,afterTime;
    /// <summary>是否允许打断 【不用】</summary>
    public bool allowInterrupt;
    /// <summary>技能概率（能量满后，有概率释放）【不用】</summary>
    public float possibility;

    /// <summary>
    /// 技能效果
    /// </summary>
    abstract public void Ability();

}
