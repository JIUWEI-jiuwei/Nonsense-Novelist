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
    public override void Awake()
    {
        base.Awake();
        wordSort = WordSortEnum.adj;
        adjID = 2;
        wordName = "����������";
        bookName = BookNameEnum.StudentOfWitch;
        description = "�ý�ɫ���һ�θ���Ļ��ᣬ����ʧȥ��ݺ��Ը�";
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

    override public void UseVerbs(AbstractCharacter aimCharacter)
    {
        base.UseVerbs(aimCharacter);
        if (!aimCharacter.buffs.ContainsKey(7) || aimCharacter.buffs[7] < 5)//��ߵ�5��
        {
            //1.��Ŀ����Ӵ˽ű����ýű���Start��ȡ�����ɫ��,����Update�ȴ�����Ч��
            aimCharacter.gameObject.AddComponent<HuoSiRenTangJi>();
            aimCharacter.trait = null;//��ʬ���⣺���Ը��Ϊ��
            aimCharacter.AddBuff(7);
            aimCharacter.AddBuff(9);
        }
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

    public override void SpecialAbility(AbstractCharacter aimCharacter)
    {
        
    }
    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return "һλ�ձ�����Ů�˴ӿڴ����ó�����ƿ��ɫ��ҩ����"+character.wordName+"��Ȼ���������������������ɡ�˵�ձ㷢�����ɢ�ܵ�ľ���ӵ�Ц����ֻ��Ҫ�����Ĵ���Ҳ����ͬ�ġ���";
    }
}
