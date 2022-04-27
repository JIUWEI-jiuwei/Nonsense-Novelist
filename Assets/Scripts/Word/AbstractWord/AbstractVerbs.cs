using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 抽象动词类（技能）
/// </summary>
abstract class AbstractVerbs : AbstractWords0 ,ICD
{
    /// <summary>技能序号</summary>
    public int skillID;


    /// <summary>施法者特效</summary>
    public Animation userAnim;
    /// <summary>作用者特效</summary>
    public Animation aimAnim;
    /// <summary>弹道特效</summary>
    public Animation bulletAnim;


    /// <summary>技能使用者身份限制（谁不能使用）</summary>
    public List<AbstractRoleLimit> banUse=new List<AbstractRoleLimit>();
    /// <summary>目标限制（不能向谁使用）</summary>
    public List<AbstractRoleLimit> banAim=new List<AbstractRoleLimit>();


    /// <summary>技能类型 </summary>
    public AbstractSkillMode skillMode;
    /// <summary>技能强度(在这两数间取随机)，或造成 某值n%（percentage写小数） 的伤害</summary>
    public float skillMinStrength, skillMaxStrength,percentage;
    /// <summary>射程</summary>
    public float attackDistance;


    /// <summary>技能持续时长（已持续时间变量现场声明） </summary>
    public float skillTime;
    /// <summary>技能效果(特殊后续效果）持续时长 </summary>
    public float skillEffectsTime;
    /// <summary>当前能量（不用CD，改为随着时间和平A次数增长，到满可以释放）</summary>
    public float cd;//一阶段用CD
    /// <summary>总能量</summary>
    public float maxCD;//一阶段用CD
    /// <summary>消耗蓝量</summary>
    public int comsumeSP;
    /// <summary>施法时长：前摇，后摇（已施法时间变量现场声明）【不用】</summary>
    public float prepareTime,afterTime;
    /// <summary>是否允许打断 【不用】</summary>
    public bool allowInterrupt;
    /// <summary>技能概率（平A时有概率释放）【不用】</summary>
    public float possibility;

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
    /// <param name="useCharacter"></param>
    /// <param name="camp">使用者阵营</param>
    virtual public void UseVerbs(AbstractCharacter useCharacter)
    {
        cd = 0;
        aims=skillMode.CalculateAgain(attackDistance,useCharacter.gameObject);
        useCharacter.charaAnim.Play(AnimEnum.attack);
        useCharacter.sp -= comsumeSP;
    }
    /// <summary>
    /// 冷却（UseVerbs将cd重置为0）
    /// </summary>
    /// <returns>是否冷却完毕</returns>
    virtual public bool CalculateCD()
    {
        if(cd<maxCD)
        {
            cd += Time.deltaTime;
        }
        if (cd >= maxCD)
            return true;
        else 
            return false;
    }
}
