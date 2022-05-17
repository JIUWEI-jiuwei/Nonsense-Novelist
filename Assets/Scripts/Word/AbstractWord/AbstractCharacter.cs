using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharaAnim))]
[RequireComponent(typeof(AI.MyState0))]
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(BoxCollider2D))]
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
    public CampEnum camp=CampEnum.all;
    /// <summary>身份</summary>
    public AbstractRole role;
    //人物的身份的类型可以不断扩充，不同的身份在战斗时对实体敌人单位的攻防加权会有影响，如大小姐，受到经济问题，社会问题的伤害较低，收到家庭问题的伤害较高
    /// <summary>性格</summary>
    public AbstractTrait trait;
    /// <summary>自带技能</summary>
    public List<AbstractVerbs> skills=new List<AbstractVerbs>();
    /// <summary>血量</summary>
    public int hp = 0;
    /// <summary>总血量</summary>
    public int maxHP = 0;
    /// <summary>蓝量</summary>
    public int sp = 0;
    /// <summary>总蓝量</summary>
    public int maxSP = 0;
    /// <summary>攻击力</summary>
    public float atk = 0;
    /// <summary>防御力</summary>
    public float def = 0;
    /// <summary>精神力</summary>psychic force
    public float psy = 0;
    /// <summary>意志力</summary>
    public float san = 0;
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
    /// <summary>攻击射程</summary>
    public int attackDistance = 0;
    /// <summary>视野角度</summary>
    public float attackAngle=120;
    /// <summary>幸运值()</summary>
    public int luckyValue = 0;
    /// <summary>等级</summary>
    public int level = 1;
    /// <summary>经验（0-100）</summary>
    public int exp = 0;
    /// <summary>怪级别（友方为0）</summary>
    public int enemyLevel = 0;
    /// <summary>主属性</summary>
    public MainSortEnum mainSort = 0;
    /// <summary>角色动画</summary>
    public CharaAnim charaAnim;
    /// <summary>剩余眩晕时间</summary>
    public float dizzyTime;
    /// <summary>所有buff《buffID，是否有buff》</summary>
    public Dictionary<int,int> buffs;

    /// <summary>血条</summary>
    //public HealthBar healthBar;
    /// <summary>蓝条</summary>
    //public SPbar SPBar;
    virtual public void Awake()
    {
        buffs= new Dictionary<int,int>();
       charaAnim=GetComponent<CharaAnim>();
       //SPBar = gameObject.AddComponent<SPbar>();
       //healthBar = gameObject.AddComponent<HealthBar>();                  
    }

    virtual public void FixedUpdate()
    {
        if(dizzyTime>0)
        {
            dizzyTime-= Time.deltaTime;
            //负数归零写在DizzyState的Exit中
        }
        #region 数值限制
        if (hp < 0)
        {
            hp = 0;
        }
        if (sp < 0)
        {
            sp = 0;
        }
        if(hp>maxHP)
        {
            hp=maxHP;
        }
        if(sp>maxSP)
        {
            sp=maxSP;
        }
        if(def<-19)
        {
            def = -19;
        }
        if(san<-19)
        {
            san= -19;
        }
        #endregion
    }
    /// <summary>
    /// 升级
    /// </summary>
    /// <returns></returns>
    virtual public bool LevelUp()
    {
        if (exp < 100)
            return false;
        else
        {
            level++;
            exp -= 100;
            hp += role.growHP;
            atk += role.growATK;
            def += role.growDEF;
            sp+=trait.growSP;
            psy += trait.growPSY;
            san += trait.growSAN;
            return true;
        }
    }

    /// <summary>
    /// 判断该角色是否有该buff
    /// </summary>
    public bool HasBuff(int buffID)
    {
        if (!buffs.ContainsKey(buffID))
            return false;
        else if(buffs[buffID] <= 0)
            return false;
        else
            return true;
    }

    /// <summary>
    /// 加个buff
    /// </summary>
    /// <param name="buffID"></param>
    public void AddBuff(int buffID)
    {
        if (!buffs.ContainsKey(buffID))
            buffs.Add(buffID, 1);
        else
            buffs[buffID]++;
    }

    /// <summary>
    /// 去个buff
    /// </summary>
    /// <param name="buffID"></param>
    public void RemoveBuff(int buffID)
    {
            buffs[buffID]--;
    }
}

