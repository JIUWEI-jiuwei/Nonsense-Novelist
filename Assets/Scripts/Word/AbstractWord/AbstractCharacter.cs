using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharaAnim))]
[RequireComponent(typeof(AI.MyState0))]
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(BoxCollider2D))]
/// <summary>
/// �����ɫ��
/// </summary>
abstract class AbstractCharacter : AbstractWords0
{
    /// <summary>���</summary>
    public int characterID;
    /// <summary>�Ա�</summary>
    public GenderEnum gender;
    /// <summary>����</summary>
    public Animator appearance;


    /// <summary>ʱ���������ı���</summary>
    public string epoch;
    /// <summary>�����������ı���</summary>
    public string area;
    /// <summary>���ﱩ��Ĭ��̨�ʣ���������ʱ��˵��̨�ʣ�</summary>
    public string criticalSpeak;
    /// <summary>��������Ĭ��̨�ʣ�����ʱ��˵��̨�ʣ�</summary>
    public string deadSpeak;


    /// <summary>��Ӫ</summary>
    public CampEnum camp=CampEnum.all;
    /// <summary>���</summary>
    public AbstractRole role;
    //�������ݵ����Ϳ��Բ������䣬��ͬ�������ս��ʱ��ʵ����˵�λ�Ĺ�����Ȩ����Ӱ�죬���С�㣬�ܵ��������⣬���������˺��ϵͣ��յ���ͥ������˺��ϸ�
    /// <summary>�Ը�</summary>
    public AbstractTrait trait;
    /// <summary>�Դ�����</summary>
    public List<AbstractVerbs> skills=new List<AbstractVerbs>();
    /// <summary>Ѫ��</summary>
    public float hp = 0;
    /// <summary>��Ѫ��</summary>
    public float maxHP = 0;
    /// <summary>����</summary>
    public float sp = 0;
    /// <summary>������</summary>
    public float maxSP = 0;
    /// <summary>������</summary>
    public float atk = 0;
    /// <summary>������</summary>
    public float def = 0;
    /// <summary>������</summary>psychic force
    public float psy = 0;
    /// <summary>��־��</summary>
    public float san = 0;
    /// <summary>��������</summary>
    public float criticalChance = 0;
    /// <summary>��������</summary>
    public float multipleCriticalStrike = 0;
    /// <summary>�������(�춨�����Ĵ����Լ�ÿ���ι������ʱ��)</summary>
    public float attackInterval = 0;
    /// <summary>�����ٶ�(���ڼ��ٸ��������м��ܵ�CD��������Ҫ���ֵ)</summary>
    public float skillSpeed = 0;
    /// <summary>���ܼ���(��ȫ���ӹ����ĸ���)</summary>
    public float dodgeChance = 0;
    /// <summary>�������</summary>
    public int attackDistance = 0;
    /// <summary>��Ұ�Ƕ�</summary>
    public float attackAngle=120;
    /// <summary>����ֵ()</summary>
    public int luckyValue = 0;
    /// <summary>�ȼ�</summary>
    public int level = 1;
    /// <summary>���飨0-100��</summary>
    public int exp = 0;
    /// <summary>�ּ����ѷ�Ϊ0��</summary>
    public int enemyLevel = 0;
    /// <summary>������</summary>
    public MainSortEnum mainSort = 0;
    /// <summary>��ɫ����</summary>
    public CharaAnim charaAnim;
    /// <summary>ʣ��ѣ��ʱ��</summary>
    public float dizzyTime;
    /// <summary>����buff��buffID���Ƿ���buff��</summary>
    public Dictionary<int,int> buffs;
    /// <summary>��Ҫ֮�����</summary>
    public List<int> importantNum=new List<int>();
    /// <summary>��ƽ����</summary>
    public string bg_text; 

    virtual public void Awake()
    {
        buffs= new Dictionary<int,int>();
        charaAnim=GetComponent<CharaAnim>();                 
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
    /// ����
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
}

