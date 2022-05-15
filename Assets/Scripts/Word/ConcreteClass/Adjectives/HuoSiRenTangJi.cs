using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ����������(����ף�
/// </summary>
class HuoSiRenTangJi : AbstractAdjectives
{
    /// <summary>����Ŀ��</summary>
    public AI.MyState0 aimState;
    public void Awake()
    {
        adjID = 2;
        wordName = "����������";
        description = "���»����������������ܹ����������»��һ������������������øɿݡ�";
        chooseWay = ChooseWayEnum.canChoose;
        skillMode = gameObject.AddComponent<SpecialMode>();
        useAtFirst = false;


        aimState=this.GetComponent<AI.MyState0>();//2.��ȡĿ�꣨����Ŀ����ʱ��
        if (aimState != null)
        {
            //ɾ����������������
            foreach(AI.AbstractState state in aimState.allState)
            {
                state.triggers.Remove(state.triggers.Find(p=>p.id==AI.TriggerID.NoHealth));
            }
        }
    }

    override public void SpecialAbility()
    {
        
    }

    override public void UseVerbs(AbstractCharacter aimCharacter)
    {
        //1.��Ŀ����Ӵ˽ű����ýű���Start��ȡ�����ɫ��,����Update�ȴ�����Ч��
        aimCharacter.gameObject.AddComponent<HuoSiRenTangJi>();
        aimCharacter.trait = null;//��ʬ���⣺���Ը��Ϊ��
        aimCharacter.AddBuff(7);
        aimCharacter.AddBuff(9);
    }

    private void FixedUpdate()
    {
        //3.ֻ���ڹ��ڽ�ɫ�ϵĻ����ű����Ѵ�����ף�
        if(aimState!=null)
        {
            if(aimState.character.hp<=0)
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
    }
}
