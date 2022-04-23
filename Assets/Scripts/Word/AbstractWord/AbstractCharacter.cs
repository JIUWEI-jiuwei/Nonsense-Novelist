using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharaAnim))]
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
    /// <summary>�Ը񡾲��á�</summary>
    public AbstractTrait trait;
    /// <summary>�Դ�����</summary>
    public List<AbstractVerbs> skill;
    /// <summary>Ѫ��</summary>
    public int hp = 0;
    /// <summary>��Ѫ��</summary>
    public int maxHP = 0;
    /// <summary>����</summary>
    public int sp = 0;
    /// <summary>������</summary>
    public int maxSP = 0;
    /// <summary>������(�˺�=������-������*0.6)</summary>
    public int atk = 0;
    /// <summary>������</summary>
    public int def = 0;
    /// <summary>������</summary>psychic force
    public int psy = 0;
    /// <summary>��־��</summary>
    public int san = 0;
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
    /// <summary>������Χ</summary>
    public int attackDistance = 0;
    /// <summary>����ֵ</summary>
    public int luckyValue = 0;
    /// <summary>�ּ����ѷ�Ϊ0��</summary>
    public int enemyLevel = 0;

    /// <summary>��ɫ����</summary>
    public CharaAnim charaAnim;

    /// <summary>ƽAģʽ</summary>
    private AbstractSkillMode attackA;
    /// <summary>Ŀ�꣨��ʵ�������һ����</summary>
    private GameObject[] aim;
    private void Awake()
    {
       attackA=new DamageMode();//ƽA���˺�����
       attackA.attackRange = new SectorAttackSelector();
       attackA.extra = 120;
        charaAnim=GetComponent<CharaAnim>();
    }

    private float time;
    private void Update()
    {
        //��ֹ���
        if (hp > maxHP)
            hp = maxHP;
        if(sp>maxSP)
            sp = maxSP;

        //ƽA
        time += Time.deltaTime;
        if(time>=attackInterval )
        {
            time = 0;
            aim = attackA.CalculateAgain(attackDistance, this.gameObject);
            if (aim != null)
                attackA.UseMode((int)(atk-def*0.6f), aim[0].GetComponent<AbstractCharacter>());
        }
    }
}

