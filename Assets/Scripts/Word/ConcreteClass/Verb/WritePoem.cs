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
        description = "ѧ�ḳʫ��������Χ���Ѿ����ܣ����30%�������Ĺ����ӳɡ�";
        nickname.Add("��ʫ");
        attackDistance = 5;
        skillMode = gameObject.AddComponent<UpATKMode>();
        skillMode.attackRange = new SingleSelector();
        attackDistance = 5;
        skillTime = 0;
        skillEffectsTime = 5;
        cd = 18;
        maxCD=18;
        prepareTime = 2;
        afterTime = 0;
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
            records[i] = aims[i].psy * 0.3f;
            skillMode.UseMode(null,records[i], aims[i]);
            aims[i].AddBuff(1);
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
                aims[i].atk -=records[i];
                aims[i].RemoveBuff(1);
            }
            records = null;
        }
    }

    public override void UseVerbs(AbstractCharacter useCharacter)
    {
        base.UseVerbs(useCharacter);
        SpecialAbility(useCharacter);
    }

    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return character.wordName + "����ߵ��������𺳣����ɵ�ʫ�Դ󷢣��̳�����ʫ�衰��ɽ��������ɽ���ۺ��������ں�����ӽ֮�䣬��������֮������";

    }
}
