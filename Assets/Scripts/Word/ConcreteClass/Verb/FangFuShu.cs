using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ������
/// </summary>
class FangFuShu : AbstractVerbs
{
    public override void Awake()
    {
        base.Awake();
        wordSort = WordSortEnum.verb;
        skillID = 7;
        wordName = "������";
        bookName = BookNameEnum.EgyptMyth;
        skillMode = gameObject.AddComponent<CureMode>();
        skillMode.attackRange = new CircleAttackSelector();
        percentage = 0;
        attackDistance = 5;
        skillTime = 0;
        skillEffectsTime = 20;
        cd=maxCD=50;
        comsumeSP = 20;
        prepareTime = 0;
        afterTime = 0;
        allowInterrupt = false;
        possibility = 0;

        aimState = this.GetComponent<AI.MyState0>();//2.��ȡĿ�꣨����Ŀ����ʱ��
        if (aimState != null)
        {
            //ɾ����������������
            foreach (AI.AbstractState state in aimState.allState)
            {
                state.triggers.Remove(state.triggers.Find(p => p.id == AI.TriggerID.NoHealth));
            }
        }
    }


    /// <summary>
    /// ���ʹ���ѻ��20�ɸ����״̬
    /// </summary>
    public override void SpecialAbility(AbstractCharacter useCharacter)
    {
        foreach(GameObject aim in aims)
        {
            //1.��Ŀ����Ӵ˽ű����ýű���Start��ȡ�����ɫ��,����Update�ȴ�����Ч��
            aim.gameObject.AddComponent<FangFuShu>();
            AbstractCharacter a=aim.GetComponent<AbstractCharacter>();
            a.AddBuff(7);
        }
    }

    private float now = 0;//��ʱ
    override public void FixedUpdate()
    {
        base.FixedUpdate();
        if (now < skillEffectsTime)
        {
            now += Time.deltaTime;
        }
        //3.ֻ���ڹ��ڽ�ɫ�ϵĻ����ű����Ѵ�����ף�
        if (aimState != null)
        {
            if (aimState.character.hp <= 0)
            {
                aimState.character.hp = aimState.character.maxHP;
                //��ӻش�������������
                foreach (AI.AbstractState state in aimState.allState)
                {
                    state.triggers.Add(this.GetComponent<AI.NoHealthTrigger>());
                }
                aimState.character.RemoveBuff(7);
                Destroy(this);//�����Լ����ű������
            }
        }
        //4.��ʱ��20�룩
        if (now >= skillEffectsTime)
        {
            //��ӻش�������������
            foreach (AI.AbstractState state in aimState.allState)
            {
                state.triggers.Add(this.GetComponent<AI.NoHealthTrigger>());
            }
            aimState.character.RemoveBuff(7);
            Destroy(this);//�����Լ����ű������
        }
    }

    /// <summary>����Ŀ��</summary>
    public AI.MyState0 aimState;
    public override void UseVerbs(AbstractCharacter useCharacter)
    {
        base.UseVerbs(useCharacter);
        SpecialAbility(useCharacter);
        
    }
}
