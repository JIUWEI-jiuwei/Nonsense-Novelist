using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 形容词
/// </summary>
abstract public class AbstractAdjectives : AbstractWords0
{
    /// <summary>技能序号</summary>
    public int adjID;
    /// <summary>目标特效</summary>
    public Animation anim;
    /// <summary>技能类型 </summary>
    public AbstractSkillMode skillMode;
    /// <summary>射程(弃用）</summary>
    public int attackDistance=100;
    /// <summary>技能效果(特殊后续效果）持续时长 </summary>
    public float skillEffectsTime;
    /// <summary>弹射机制 </summary>
    public List<WordCollisionShoot> wordCollisionShoots=new List<WordCollisionShoot>();

    public AbstractCharacter aim;
    /// <summary>特殊效果存储引用</summary>
    protected List<AbstractBuff> buffs=new List<AbstractBuff>();

    public virtual void Awake()
    {
        wordKind = WordKindEnum.adj;
        nowTime = skillEffectsTime;
        aim=GetComponent<AbstractCharacter>();
    }
    /// <summary>
    /// 技能效果(特殊效果）
    /// </summary>
    abstract public void BasicAbility(AbstractCharacter aimCharacter);

    /// <summary>
    /// 使用技能
    /// </summary>
    /// <param name="aimCharacter">目标</param>
    virtual public void UseAdj(AbstractCharacter aimCharacter)
    {
        AbstractBook.afterFightText += UseText();
    }
    /// <summary>倒计时</summary>
    protected float nowTime;
    virtual protected void Update()
    {
        nowTime-=Time.deltaTime;
        if (nowTime < 0)
            Destroy(this);
    }
    virtual public void End()
    {

    }

    private void OnDestroy()
    {
        foreach (AbstractBuff buff in buffs)
        {
            Destroy(buff);
        }
        if (aim!=null)
        {
            End();
        }
    }

}
