using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 抽象动词类（技能）
/// </summary>
abstract public class AbstractVerbs : AbstractWords0 ,ICD
{
    /// <summary>技能序号</summary>
    public int skillID;


    /// <summary>施法者特效</summary>
    public Animation userAnim;
    /// <summary>作用者特效</summary>
    public Animation aimAnim;
    /// <summary>弹道特效</summary>
    public Animation bulletAnim;

    /// <summary>技能类型 </summary>
    public AbstractSkillMode skillMode;
    /// <summary>射程</summary>
    public int attackDistance;


    /// <summary>技能持续时长（已持续时间变量现场声明） </summary>
    public float skillTime;
    /// <summary>技能效果(特殊后续效果）持续时长 </summary>
    public float skillEffectsTime;
    /// <summary>是否正在使用该技能 </summary>
    public bool isUsing;
    /// <summary>稀有度</summary>
    public int rarity;
    /// <summary>当前能量(每个技能有自己的能量值)</summary>
    public float cd;
    /// <summary>总能量</summary>
    public float maxCD;
    /// <summary>施法时长：前摇，后摇（已施法时间变量现场声明）【不用】</summary>
    public float prepareTime,afterTime;
    /// <summary>目标数组 </summary>
    protected AbstractCharacter[] aims;
    /// <summary>特殊效果存储引用</summary>
    protected List<AbstractBuff> buffs;

    public virtual void Awake()
    {
        wordSort =WordSortEnum.verb;
        OnAwake();
    }

    public delegate void AwakeHandler();
    static public event AwakeHandler OnAwake;

    /// <summary>
    /// 技能效果(特殊效果）
    /// </summary>
    virtual public void SpecialAbility(AbstractCharacter useCharacter)
    {

    }
    /// <summary>
    /// 使用技能
    /// </summary>
    /// <param name="camp">使用者阵营</param>
    virtual public void UseVerbs(AbstractCharacter useCharacter)
    {
        isUsing = true;
        cd = 0;
        aims=skillMode.CalculateAgain(attackDistance,useCharacter);
        
        stateInfo=useCharacter.charaAnim.anim.GetCurrentAnimatorStateInfo(0);
    }

    private AnimatorStateInfo stateInfo;

    virtual public void FixedUpdate()
    {
        if (cd < maxCD)
        {
            cd += Time.deltaTime;
        }
        if(isUsing && stateInfo.normalizedTime>= 0.9f )//播放完特效即为使用完毕
        {
            isUsing=false;
        }
    }

    /// <summary>
    /// 冷却（UseVerbs将cd重置为0）
    /// </summary>
    /// <returns>是否冷却完毕</returns>
    virtual public bool CalculateCD()
    {

        if (cd >= maxCD)
        {
            cd = maxCD;
            return true;
        }
        else
            return false;
    }

    private void OnDisable()
    {
        foreach(AbstractBuff buff in buffs)
        {
            Destroy(buff);
        }
    }
    private void OnDestroy()
    {
        foreach (AbstractBuff buff in buffs)
        {
            Destroy(buff);
        }
    }
}
