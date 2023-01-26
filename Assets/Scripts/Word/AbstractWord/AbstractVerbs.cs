using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// ���󶯴��ࣨ���ܣ�
/// </summary>
abstract public class AbstractVerbs : AbstractWords0 ,ICD
{
    /// <summary>�������</summary>
    public int skillID;


    /// <summary>ʩ������Ч</summary>
    public Animation userAnim;
    /// <summary>��������Ч</summary>
    public Animation aimAnim;
    /// <summary>������Ч</summary>
    public Animation bulletAnim;

    /// <summary>�������� </summary>
    public AbstractSkillMode skillMode;

    /// <summary>��̣������ã� </summary>
    public int attackDistance=100;
    /// <summary>����Ч������ʱ�� </summary>
    public float skillEffectsTime;
    /// <summary>�Ƿ�����ʹ�øü��� </summary>
    public bool isUsing;
    
    /// <summary>��ǰ����(ÿ���������Լ�������ֵ)</summary>
    private int cd;
    public int CD
    { 
        get
        {
            return cd;
        }
        set
        {
            cd = value;
        }
    }
    /// <summary>�ͷ�һ����������</summary>
    public int needCD;
    /// <summary>ʩ��ʱ����ǰҡ����ҡ����ʩ��ʱ������ֳ��������������ã�</summary>
    public float prepareTime,afterTime;
    /// <summary>����Ч���洢����</summary>
    protected List<AbstractBuff> buffs;

    public virtual void Awake()
    {
        OnAwake();
    }

    public delegate void AwakeHandler();
    static public event AwakeHandler OnAwake;

    /// <summary>
    /// ����Ч��(����Ч����
    /// </summary>
    virtual public void SpecialAbility(AbstractCharacter useCharacter)
    {

    }
    /// <summary>
    /// ʹ�ü���
    /// </summary>
    /// <param name="camp">ʹ������Ӫ</param>
    virtual public void UseVerbs(AbstractCharacter useCharacter)
    {
        isUsing = true;
        CD = 0;
        stateInfo=useCharacter.charaAnim.anim.GetCurrentAnimatorStateInfo(0);
    }

    private AnimatorStateInfo stateInfo;

    virtual public void FixedUpdate()
    {
        if(isUsing && stateInfo.normalizedTime>= 0.9f )//��������Ч��Ϊʹ�����
        {
            isUsing=false;
        }
    }

    /// <summary>
    /// ��ȴ��UseVerbs��cd����Ϊ0��
    /// </summary>
    /// <returns>�Ƿ���ȴ���</returns>
    virtual public bool CalculateCD()
    {

        if (CD >= needCD)
        {
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
