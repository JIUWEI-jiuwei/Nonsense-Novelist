using AI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuHuo : AbstractBuff
{
    override protected void Awake()
    {
        base.Awake();
        buffName = "����";
        book = BookNameEnum.Salome;
        upup = 1;

        if (GameObject.Find("���н�ɫ�ĸ�����").GetComponentsInChildren<FuHuo>().Length == 1)
        AbstractVerbs.OnAwake += FuHuoSkill;

        AttackState attackState = GetComponent<AttackState>();
        if(attackState!=null && attackState.attackA.GetType()==typeof(DamageMode))
        {
            FuHuoMode newMode= gameObject.AddComponent<FuHuoMode>();
            newMode.attackRange = attackState.attackA.attackRange;
            Destroy(attackState.attackA);
            attackState.attackA = newMode;
        }
        FuHuoSkill();
    }

    private void FuHuoSkill()
    {
        AbstractVerbs[] allVerb = GetComponents<AbstractVerbs>();
        foreach (AbstractVerbs verb in allVerb)
        {
            if (verb.skillMode.GetType() == typeof(DamageMode))
            {
                FuHuoMode newMode = gameObject.AddComponent<FuHuoMode>();
                newMode.attackRange = verb.skillMode.attackRange;
                Destroy(verb.skillMode);
                verb.skillMode = newMode;
            }
        }
    }

    private void OnDestroy()
    {
       if(this.GetComponents<FuHuo>().Length<=1)//ֻ���Լ�
        {
            if(GameObject.Find("���н�ɫ�ĸ�����").GetComponentsInChildren<FuHuo>().Length<=1)
                AbstractVerbs.OnAwake -= FuHuoSkill;

            AttackState attackState = GetComponent<AttackState>();
            if (attackState != null && attackState.attackA.GetType() == typeof(FuHuoMode))
            {
                DamageMode newMode = gameObject.AddComponent<DamageMode>();
                newMode.attackRange = attackState.attackA.attackRange;
                Destroy(attackState.attackA);
                attackState.attackA = newMode;
            }
            AbstractVerbs[] allVerb = GetComponents<AbstractVerbs>();
            foreach (AbstractVerbs verb in allVerb)
            {
                if (verb.skillMode.GetType() == typeof(FuHuoMode))
                {
                    DamageMode newMode = gameObject.AddComponent<DamageMode>();
                    newMode.attackRange = verb.skillMode.attackRange;
                    Destroy(verb.skillMode);
                    verb.skillMode = newMode;
                }
            }
        }
    }

}

class FuHuoMode : AbstractSkillMode
{
    /// <summary>
    /// ��Ŀ��ʵ��Ӱ��
    /// </summary>
    /// <param name="value">ʵ���˺�</param>
    /// <param name="character">Ŀ�꣨����Ŀ�����飩</param>
    public override void UseMode(AbstractCharacter useCharacter, float value, AbstractCharacter aimCharacter)
    {
        if (useCharacter != null)//��ɫʹ��
        {
            float a = Random.Range(0, 100);//�����齱
            if (a <= useCharacter.criticalChance * 100)//����
            {
                value *= useCharacter.multipleCriticalStrike;
                aimCharacter.teXiao.PlayTeXiao("BaoJi");
                AbstractBook.afterFightText += useCharacter.CriticalText(aimCharacter);
            }

            /*if(useCharacter.trait.restrainRole.Contains(aimCharacter.trait.traitEnum))//�����߿˱�������,����30%�˺�
            {
                aimCharacter.hp -= value * 1.3f;
            }
            else//һ��*/
            {
                aimCharacter.hp -= value;
            }
        }
        else//���ʹ�ã����ݴʣ�
            aimCharacter.hp -= (int)value;
    }
    /// <summary>
    /// �ٴμ���������Ŀ��
    /// </summary>
    /// <param name="character">ʩ����</param>
    /// <returns></returns>
    override public AbstractCharacter[] CalculateAgain(int attackDistance, AbstractCharacter character)
    {
        AbstractCharacter[] a = attackRange.CaculateRange(attackDistance, character.situation, NeedCampEnum.friend);//���ȹ����ѷ����ڼ��˺����룬������ָ�
        return a;
    }
}

