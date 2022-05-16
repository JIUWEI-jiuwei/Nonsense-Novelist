using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ��ʫ
/// </summary>
class WritePoem : AbstractVerbs
{
    public override void Awake()
    {
        base.Awake();
        wordSort = WordSortEnum.verb;
        skillID = 1;
        wordName = "��ʫ";
        bookName = BookNameEnum.HongLouMeng;
        description = "��ʫ���ԣ��ò����";
        nickname.Add("��ʫ");
        attackDistance = 5;
        skillMode = gameObject.AddComponent<UpATKMode>();
        skillMode.attackRange = new CircleAttackSelector();//
        attackDistance = 5;
        skillTime = 0;
        skillEffectsTime = 5;
        cd=maxCD=18;
        comsumeSP = 10;
        prepareTime = 2;
        afterTime = 0;
        allowInterrupt = true;
        possibility = 0;
    }

    private float now = 0;//��ʱ
    private float[] records;//��¼�����Ĺ�����
    /// <summary>
    /// ����30%�������Ĺ�����,����5��
    /// </summary>
    public override void SpecialAbility(AbstractCharacter useCharacter)
    {
        records=new float[aims.Length];
        now = 0;
        for(int i=0;i<aims.Length;i++)
        {
            AbstractCharacter a = aims[i].GetComponent<AbstractCharacter>();
            records[i] = a.psy * 0.3f;
            skillMode.UseMode(null,records[i], a);
            a.AddBuff(1);
        }
        
    }
    override public void FixedUpdate()
    {
        base.FixedUpdate();
        if (now < skillEffectsTime)
        {
            now += Time.deltaTime;
        }
        else if (now >= skillEffectsTime &&records!=null)
        {
            for (int i = 0; i < aims.Length; i++)
            {
                AbstractCharacter a=aims[i].GetComponent<AbstractCharacter>();
                a.atk -=records[i];
                a.RemoveBuff(1);
            }
            records = null;
        }
    }

    public override void UseVerbs(AbstractCharacter useCharacter)
    {
        base.UseVerbs(useCharacter);
        SpecialAbility(useCharacter);
    }
}
