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
    /// <summary>���</summary>
    public int attackDistance;


    /// <summary>���ܳ���ʱ�����ѳ���ʱ������ֳ������� </summary>
    public float skillTime;
    /// <summary>����Ч��(�������Ч��������ʱ�� </summary>
    public float skillEffectsTime;
    /// <summary>�Ƿ�����ʹ�øü��� </summary>
    public bool isUsing;
    /// <summary>ϡ�ж�</summary>
    public int rarity;
    /// <summary>��ǰ����(ÿ���������Լ�������ֵ)</summary>
    public float cd;
    /// <summary>������</summary>
    public float maxCD;
    /// <summary>ʩ��ʱ����ǰҡ����ҡ����ʩ��ʱ������ֳ������������á�</summary>
    public float prepareTime,afterTime;
    /// <summary>Ŀ������ </summary>
    protected AbstractCharacter[] aims;
    /// <summary>����Ч���洢����</summary>
    protected List<AbstractBuff> buffs;

    public virtual void Awake()
    {
        wordSort =WordSortEnum.verb;
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
