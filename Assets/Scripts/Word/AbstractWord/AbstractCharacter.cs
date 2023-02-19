using AI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(CharaAnim))]
[RequireComponent(typeof(AI.MyState0))]
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(AudioSource))]
/// <summary>
/// 抽象角色类（启用，会在Awake自动关上，需要外部脚本再启用）
/// </summary>
abstract public class AbstractCharacter : AbstractWord0
{
    protected MyState0 myState;
    /// <summary>序号</summary>
    public int characterID;
    /// <summary>性别(弃用)</summary>
    public GenderEnum gender;
    /// <summary>AudioSource</summary>
    public AudioSource source;
    /// <summary>平A音效(手动拖拽）</summary>
    public AudioClip aAttackAudio;
    /// <summary>走路音效（手动拖拽）</summary>
    public AudioClip walkAudio;
    /// <summary>人物暴击默认台词（弃用）</summary>
    //[HideInInspector] public string criticalSpeak;
    /// <summary>人物死亡默认台词（弃用）</summary>
    //[HideInInspector] public string deadSpeak;

    /// <summary>特效</summary>
    public TeXiao teXiao;
    /// <summary>子弹(手动挂）</summary>
    public GameObject bullet;
    /// <summary>发出子弹 </summary>
    public virtual void CreateBullet(GameObject aimChara) { }

    /// <summary>阵营</summary>
    public CampEnum camp;
    /// <summary>血量</summary>
    public float HP = 0;
    /// <summary>总血量</summary>
    public float maxHP = 0;
    /// <summary>攻击力</summary>
    protected float ATK = 0;

    virtual public float hp
    {
        get { return HP; }
        set 
        {
            HP = value;
            if (HP > maxHP)
            {
                HP = maxHP;
            }
            else if (HP < 0)
            {
                HP = 0;
            }
        }
    }
    virtual public float maxhp
    {
        get { return maxHP; }
        set
        {
            maxHP = value;
        }
    }
    virtual public float atk
    {
        get { return ATK; }
        set 
        {
            ATK = value;
            CaculateValue();
        }
    }
    protected float DEF = 0;
    virtual public float def
    {
        get { return DEF; }
        set 
        {
            DEF = value;
            if (DEF < -19)
                DEF= -19;
            CaculateValue();
        }
    }
    /// <summary>精神力</summary>
    protected float PSY = 0;
    /// <summary>精神力</summary>
    virtual public float psy
    {
        get { return PSY; }
        set 
        { 
            PSY = value;
            CaculateValue();
        }
    }
    /// <summary>意志力</summary>
    protected float SAN = 0;
    /// <summary>意志力</summary>
    virtual public float san
    {
        get { return SAN; }
        set
        { 
            SAN = value;
            if (SAN < -19)
            SAN= -19;
            CaculateValue();
        }
    }
    /// <summary>四维之和，节省性能 </summary>
    public float allValue { get; private set; }
    public void CaculateValue() { allValue = atk + def + psy + san; }
    /// <summary>主属性(弃用)</summary>
    public Dictionary<string,string> mainProperty=new Dictionary<string, string>();
    /// <summary>性格（弃用）</summary>
    public AbstractTrait trait;
    /// <summary>身份名</summary>
    public string roleName;
    /// <summary>拥有技能（所挂组件,自带技能/身份 在初始赋值）</summary>
    public List<AbstractVerbs> skills;
    /// <summary>暴击几率(弃用)</summary>
    [HideInInspector]public float criticalChance = 0;
    /// <summary>暴击倍数(弃用）</summary>
    [HideInInspector] public float multipleCriticalStrike = 2;
    /// <summary>攻击间隔(检定攻击的次序，以及每两次攻击间隔时长)</summary>
    public float attackInterval = 2.2f;

    /// <summary>站位</summary>
    public Situation situation;
    /// <summary>攻击射程</summary>
    public int attackDistance = 0;
    /// <summary>角色动画</summary>
    public CharaAnim charaAnim;
    /// <summary>剩余眩晕时间</summary>
    public float dizzyTime;
    /// <summary>是否有复活状态(仍不可叠加，但数量为0则不可复活)</summary>
    private int relifes;
    public int reLifes
    {
        get { return relifes; } 
        set
        { 
            relifes = value; 
            if(relifes<0)relifes=0;
        }
    }

    /// <summary>能量充能</summary>
    public float energy;

    /// <summary>所有buff《buffID，是否有buff》</summary>
    public Dictionary<int,int> buffs;


    virtual public void Awake()
    {
        energyCanvas = this.GetComponentInChildren<Canvas>();
        energyCanvas.worldCamera = GameObject.Find("MainCamera").GetComponent<Camera>();
        energySlider=this.GetComponentInChildren<Slider>();
        energyText = this.GetComponentInChildren<Text>();
        energyCanvas.gameObject.SetActive(false);

        myState = GetComponent<MyState0>();
        myState.character = this;
        myState.enabled = false;

        teXiao=GetComponentInChildren<TeXiao>();
        source=this.GetComponent<AudioSource>();
        buffs= new Dictionary<int,int>();
        charaAnim=GetComponent<CharaAnim>();

        if (GameObject.Find("AllCharacter") != null)
        {
            AbstractCharacter[] a = GameObject.Find("AllCharacter").GetComponentsInChildren<AbstractCharacter>();
            AbstractCharacter b = CollectionHelper.Find(a, p => p.wordName != wordName);
            AbstractBook.beforeFightText += ShowText(b);
        }

        this.enabled = false;
    }
    private void OnEnable()
    {
        energyCanvas.gameObject.SetActive(true);
    }

    private Canvas energyCanvas;
    private Slider energySlider;
    private Text energyText;
    public delegate void energyFull();
    public event energyFull OnEnergyFull;
    private void Update()
    {
        energy += Time.deltaTime;
        energySlider.value = energy;
        if(energy>1)
        {
            energy = 0;
            _canUseSkills = 0;
            if (OnEnergyFull != null)
                OnEnergyFull();
        }
    }
    /// <summary>能用的技能个数 </summary>
    private int _canUseSkills;
    public int canUseSkills
    {
        get
        {
            return _canUseSkills; 
        }
        set 
        {
            _canUseSkills = value;
            energyText.text = _canUseSkills.ToString();
        }
    }

    /// <summary>
    /// 平A时最先发生的事(角色对平A造成影响）
    /// </summary>
    virtual public void AttackA() 
    {
        if(OnA!=null)
        OnA();
    }

    public delegate void changeA();
    /// <summary>
    /// 对角色平A进行操作(技能等对平A造成影响）
    /// </summary>
    public event changeA OnA;
    

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
    /// <summary>
    /// 人物出场文本(加到AbstractBook.beforeFightText)
    /// </summary>
    abstract public string ShowText(AbstractCharacter otherChara);

    /// <summary>
    /// 暴击文本(加到AbstractBook.afterFightText)
    /// </summary>
    abstract public string CriticalText(AbstractCharacter otherChara);

    /// <summary>
    /// 低血量文本(加到AbstractBook.afterFightText)
    /// </summary>
    abstract public string LowHPText();

    /// <summary>
    /// 死亡文本(加到AbstractBook.afterFightText)
    /// </summary>
    abstract public string DieText();
}

