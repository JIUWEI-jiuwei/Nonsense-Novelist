using AI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharaAnim))]
[RequireComponent(typeof(AI.MyState0))]
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(AudioSource))]
/// <summary>
/// �����ɫ��
/// </summary>
abstract public class AbstractCharacter : AbstractWords0
{
    protected MyState0 myState;
    /// <summary>���</summary>
    public int characterID;
    /// <summary>�Ա�</summary>
    public GenderEnum gender;
    /// <summary>AudioSource</summary>
    public AudioSource source;
    /// <summary>ƽA��Ч(�ֶ���ק��</summary>
    public AudioClip aAttackAudio;
    /// <summary>��·��Ч���ֶ���ק��</summary>
    public AudioClip walkAudio;
    /// <summary>���ﱩ��Ĭ��̨�ʣ����ã�</summary>
    //[HideInInspector] public string criticalSpeak;
    /// <summary>��������Ĭ��̨�ʣ����ã�</summary>
    //[HideInInspector] public string deadSpeak;

    /// <summary>��Ч</summary>
    public TeXiao teXiao;
    /// <summary>�ӵ�(�ֶ��ң�</summary>
    public GameObject bullet;
    /// <summary>�����ӵ� </summary>
    public virtual void CreateBullet(GameObject aimChara) { }

    /// <summary>��Ӫ</summary>
    public CampEnum camp;
    /// <summary>Ѫ��</summary>
    public float HP = 0;
    /// <summary>��Ѫ��</summary>
    public float maxHP = 0;
    /// <summary>������</summary>
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
    /// <summary>������</summary>
    protected float PSY = 0;
    /// <summary>������</summary>
    virtual public float psy
    {
        get { return PSY; }
        set 
        { 
            PSY = value;
            CaculateValue();
        }
    }
    /// <summary>��־��</summary>
    protected float SAN = 0;
    /// <summary>��־��</summary>
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
    /// <summary>��ά֮�ͣ���ʡ���� </summary>
    public float allValue { get; private set; }
    public void CaculateValue() { allValue = atk + def + psy + san; }
    /// <summary>������(����)</summary>
    public Dictionary<string,string> mainProperty;
    /// <summary>�Ը����ã�</summary>
    public AbstractTrait trait;
    /// <summary>�����</summary>
    public string roleName;
    /// <summary>ӵ�м��ܣ��������,�Դ�����/��� �ڳ�ʼ��ֵ��</summary>
    public List<AbstractVerbs> skills;
    /// <summary>��������(����)</summary>
    [HideInInspector]public float criticalChance = 0;
    /// <summary>��������(���ã�</summary>
    [HideInInspector] public float multipleCriticalStrike = 2;
    /// <summary>�������(�춨�����Ĵ����Լ�ÿ���ι������ʱ��)</summary>
    public float attackInterval = 2.2f;

    /// <summary>վλ</summary>
    public Situation situation;
    /// <summary>�������</summary>
    public int attackDistance = 0;
    /// <summary>��ɫ����</summary>
    public CharaAnim charaAnim;
    /// <summary>ʣ��ѣ��ʱ��</summary>
    public float dizzyTime;
    /// <summary>�Ƿ��и���״̬(�Բ��ɵ��ӣ�������Ϊ0�򲻿ɸ���)</summary>
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

    /// <summary>��������</summary>
    public float energy;

    /// <summary>����buff��buffID���Ƿ���buff��</summary>
    public Dictionary<int,int> buffs;
    

    virtual public void Awake()
    {
        myState = GetComponent<MyState0>();
        teXiao=GetComponentInChildren<TeXiao>();
        source=this.GetComponent<AudioSource>();
        buffs= new Dictionary<int,int>();
        charaAnim=GetComponent<CharaAnim>();

        AbstractCharacter[] a= GameObject.Find("SelfCharacter").GetComponentsInChildren<AbstractCharacter>();
        AbstractCharacter b=CollectionHelper.Find(a,p=>p.wordName!=wordName); 
        AbstractBook.beforeFightText += ShowText(b);
    }

    public delegate void energyFull();
    public event energyFull OnEnergyFull;
    private void Update()
    {
        energy += Time.deltaTime;
        if(energy>1)
        {
            energy = 0;
            if (OnEnergyFull != null)
                OnEnergyFull();
        }
    }

    /// <summary>
    /// ƽAʱ���ȷ�������(��ɫ��ƽA���Ӱ�죩
    /// </summary>
    virtual public void AttackA() 
    {
        if(OnA!=null)
        OnA();
    }

    public delegate void changeA();
    /// <summary>
    /// �Խ�ɫƽA���в���(���ܵȶ�ƽA���Ӱ�죩
    /// </summary>
    public event changeA OnA;
    

    /// <summary>
    /// �жϸý�ɫ�Ƿ��и�buff
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
    /// �Ӹ�buff
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
    /// ȥ��buff
    /// </summary>
    /// <param name="buffID"></param>
    public void RemoveBuff(int buffID)
    {
            buffs[buffID]--;
    }
    /// <summary>
    /// ��������ı�(�ӵ�AbstractBook.beforeFightText)
    /// </summary>
    abstract public string ShowText(AbstractCharacter otherChara);

    /// <summary>
    /// �����ı�(�ӵ�AbstractBook.afterFightText)
    /// </summary>
    abstract public string CriticalText(AbstractCharacter otherChara);

    /// <summary>
    /// ��Ѫ���ı�(�ӵ�AbstractBook.afterFightText)
    /// </summary>
    abstract public string LowHPText();

    /// <summary>
    /// �����ı�(�ӵ�AbstractBook.afterFightText)
    /// </summary>
    abstract public string DieText();
}

