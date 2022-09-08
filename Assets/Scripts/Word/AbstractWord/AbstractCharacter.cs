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
    /// <summary>���</summary>
    public int characterID;
    /// <summary>�Ա�</summary>
    public GenderEnum gender;
    /// <summary>����</summary>
    public Animator appearance;
    /// <summary>AudioSource</summary>
    public AudioSource source;
    /// <summary>ƽA��Ч(�ֶ���ק��</summary>
    public AudioClip aAttackAudio;
    /// <summary>��·��Ч���ֶ���ק��</summary>
    public AudioClip walkAudio;
    /// <summary>���ﱩ��Ĭ��̨�ʣ����ã�</summary>
    public string criticalSpeak;
    /// <summary>��������Ĭ��̨�ʣ����ã�</summary>
    public string deadSpeak;
    /// <summary>���(���ã�</summary>
    public AbstractRole role;

    /// <summary>��Ч</summary>
    public TeXiao teXiao;
    /// <summary>�ӵ�(�ֶ��ң�</summary>
    public GameObject bullet;
    /// <summary>�����ӵ� </summary>
    public virtual void CreateBullet(GameObject aimChara) { }

    /// <summary>��Ӫ</summary>
    public CampEnum camp;
    /// <summary>Ѫ��</summary>
    public float hp = 0;
    /// <summary>��Ѫ��</summary>
    public float maxHP = 0;
    /// <summary>���������ã�</summary>
    public float sp = 0;
    /// <summary>�����������ã�</summary>
    public float maxSP = 0;
    /// <summary>������</summary>
    protected float ATK = 0;
    virtual public float atk
    {
        get { return ATK; }
        set { ATK = value; }
    }
    /// <summary>������</summary>
    protected float DEF = 0;
    virtual public float def
    {
        get { return DEF; }
        set { DEF = value; }
    }
    /// <summary>������</summary>psychic force
    protected float PSY = 0;
    virtual public float psy
    {
        get { return PSY; }
        set { PSY = value; }
    }
    /// <summary>��־��</summary>
    protected float SAN = 0;
    virtual public float san
    {
        get { return SAN; }
        set { SAN = value; }
    }
    /// <summary>������</summary>
    public Dictionary<string,string> mainProperty;
    /// <summary>�Ը�</summary>
    public AbstractTrait trait;
    /// <summary>�����</summary>
    public string roleName;
    /// <summary>ӵ�м��ܣ��������,�Դ�����/��� �ڳ�ʼ��ֵ��</summary>
    public List<AbstractVerbs> skills;
    /// <summary>��������(������Ϊ2��)</summary>
    public float criticalChance = 0;
    /// <summary>��������(���ã�</summary>
    public float multipleCriticalStrike = 0;
    /// <summary>�������(�춨�����Ĵ����Լ�ÿ���ι������ʱ��)</summary>
    public float attackInterval = 0;
    /// <summary>�����ٶ�(���ã�(���ڼ��ٸ��������м��ܵ�CD��������Ҫ���ֵ)</summary>
    public float skillSpeed = 0;
    /// <summary>���ܼ���(����)</summary>
    public float dodgeChance = 0;

    /// <summary>վλ</summary>
    public Situation situation;
    /// <summary>�������</summary>
    public int attackDistance = 0;
    /// <summary>����ֵ(����)</summary>
    public int luckyValue = 0;
    /// <summary>�ȼ�(���ã�</summary>
    public int level = 1;
    /// <summary>����(���ã���0-100��</summary>
    public int exp = 0;
    /// <summary>�ּ���(���ã����ѷ�Ϊ0��</summary>
    public int enemyLevel = 0;
    /// <summary>������(���ã�</summary>
    public MainSortEnum mainSort = 0;
    /// <summary>��ɫ����</summary>
    public CharaAnim charaAnim;
    /// <summary>ʣ��ѣ��ʱ��</summary>
    public float dizzyTime;
    /// <summary>�Ƿ��и���״̬</summary>
    public bool reLifes;
    /// <summary>����buff��buffID���Ƿ���buff��</summary>
    public Dictionary<int,int> buffs;
    /// <summary>��Ҫ֮�����</summary>
    public List<int> importantNum=new List<int>();
    

    virtual public void Awake()
    {
        teXiao=GetComponentInChildren<TeXiao>();
        source=this.GetComponent<AudioSource>();
        buffs= new Dictionary<int,int>();
        charaAnim=GetComponent<CharaAnim>();

        AbstractCharacter[] a= GameObject.Find("SelfCharacter").GetComponentsInChildren<AbstractCharacter>();
        AbstractCharacter b=CollectionHelper.Find(a,p=>p.wordName!=wordName); 
        AbstractBook.beforeFightText += ShowText(b);
    }

    virtual public void FixedUpdate()
    {
        if(dizzyTime>0)
        {
            dizzyTime-= Time.deltaTime;
            //��������д��DizzyState��Exit��
        }
        #region ��ֵ����
        if (hp < 0)
        {
            hp = 0;
        }
        if(hp>maxHP)
        {
            hp=maxHP;
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
    /// ����
    /// </summary>
    /// <returns></returns>
    /*virtual public bool LevelUp()
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
    }*/

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

