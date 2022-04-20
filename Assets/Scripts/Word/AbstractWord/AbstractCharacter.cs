using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 抽象角色类
/// </summary>
abstract class AbstractCharacter : AbstractWords0
{
    /// <summary>序号</summary>
    public int characterID;
    /// <summary>性别</summary>
    public GenderEnum gender;
    /// <summary>形象</summary>
    public Animator appearance;


    /// <summary>时代（用于文本）</summary>
    public string epoch;
    /// <summary>地区（用于文本）</summary>
    public string area;
    /// <summary>人物暴击默认台词（触发暴击时所说的台词）</summary>
    public string criticalSpeak;
    /// <summary>人物死亡默认台词（死亡时所说的台词）</summary>
    public string deadSpeak;


    /// <summary>阵营</summary>
    public CampEnum camp;
    /// <summary>身份</summary>
    public AbstractRole role;
    //人物的身份的类型可以不断扩充，不同的身份在战斗时对实体敌人单位的攻防加权会有影响，如大小姐，受到经济问题，社会问题的伤害较低，收到家庭问题的伤害较高
    /// <summary>性格【不用】</summary>
    public AbstractTrait trait;
    /// <summary>自带技能</summary>
    public List<AbstractVerbs> skill;
    /// <summary>血量</summary>
    public int hp = 0;
    /// <summary>总血量</summary>
    public int maxHP = 0;
    /// <summary>蓝量</summary>
    public int sp = 0;
    /// <summary>总蓝量</summary>
    public int maxSP = 0;
    /// <summary>攻击力(伤害=攻击力-防御力*0.6)</summary>
    public int atk = 0;
    /// <summary>防御力</summary>
    public int def = 0;
    /// <summary>精神力</summary>psychic force
    public int psy = 0;
    /// <summary>意志力</summary>
    public int san = 0;
    /// <summary>暴击几率</summary>
    public float criticalChance = 0;
    /// <summary>暴击倍数</summary>
    public float multipleCriticalStrike = 0;
    /// <summary>攻击间隔(检定攻击的次序，以及每两次攻击间隔时长)</summary>
    public float attackInterval = 0;
    /// <summary>技能速度(用于减少该人物所有技能的CD，尽量不要这个值)</summary>
    public float skillSpeed = 0;
    /// <summary>闪避几率(完全无视攻击的概率)</summary>
    public float dodgeChance = 0;
    /// <summary>攻击范围</summary>
    public int attackDistance = 0;
    /// <summary>幸运值</summary>
    public int luckyValue = 0;


    /// <summary>平A模式</summary>
    private AbstractSkillMode attackA;
    /// <summary>目标（其实就最近的一个）</summary>
    private GameObject[] aim;
    private void Start()
    {
       attackA=new DamageMode();
       attackA.attackRange = new SectorAttackSelector();
        attackA.extra = 120;
    }

    private float time;
    private void Update()
    {
        //防止溢出
        if (hp > maxHP)
            hp = maxHP;
        if(sp>maxSP)
            sp = maxSP;

        //平A
        time += Time.deltaTime;
        if(time>=attackInterval )
        {
            time = 0;
            aim = attackA.CalculateAgain(attackDistance, this.gameObject);
            if(aim!=null)
            aim[0].GetComponent<AbstractCharacter>().hp -= (int)(atk - def * 0.6f);
        }
    }
}

