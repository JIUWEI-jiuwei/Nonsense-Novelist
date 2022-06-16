using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ����
/// </summary>
class HeartBroken : AbstractVerbs
{
    public override void Awake()
    {
        base.Awake();
        wordSort = WordSortEnum.verb;
        skillID = 2;
        wordName = "����";
        bookName = BookNameEnum.allBooks;
        description = "�����е�ʹ����Է����絶�ʣ�����ƣ���ߡ�";
        nickname.Add( "��ʹ");
        banAim.Add(gameObject.AddComponent<Sense>());
        skillMode = gameObject.AddComponent<DamageMode>();
        skillMode.attackRange = new CircleAttackSelector();//
        percentage = 1.5f;
        attackDistance = 999;
        skillTime = 0;
        skillEffectsTime = 3;
        cd=maxCD=5;
        comsumeSP = 5;
        prepareTime = 0.5f;
        afterTime = 1;
        allowInterrupt = false;
        possibility = 0;
    }

    private AbstractCharacter aimState;//Ŀ��ĳ����ɫ��
    /// <summary>
    /// ���150%���������˺�
    /// </summary>
    /// <param name="useCharacter">ʩ����</param>
    public override void UseVerbs(AbstractCharacter useCharacter)
    {
        base.UseVerbs(useCharacter);
        foreach (GameObject aim in aims)
        {
            aimState = aim.GetComponent<AbstractCharacter>();
            skillMode.UseMode(useCharacter,aim.GetComponent<AbstractCharacter>().psy * percentage *(1-aimState.def/(aimState.def+20)), aimState);
        }
        SpecialAbility(useCharacter);
    }

    private float now = 0;//��ʱ
    private int[] records;//��¼���͵ľ�����ֵ
    /// <summary>
    /// ����30%������,����3��
    /// </summary>
    public override void SpecialAbility(AbstractCharacter useCharacter)
    {
        records = new int[aims.Length];
        now = 0;
        for (int i=0;i<aims.Length;i++)
        {
            AbstractCharacter a = aims[i].GetComponent<AbstractCharacter>();
            records[i] = (int)(a.psy * 0.3f);
            a.psy -= records [i];
            a.AddBuff(2);
        }
    }
    override public  void FixedUpdate()
    {
        base.FixedUpdate();
        if (now < skillEffectsTime)
        {
            now += Time.deltaTime;
        }
        else if (now >= skillEffectsTime && records!=null)//ʱ�䵽
        {
            for (int i = 0; i < aims.Length; i++)
            {
                AbstractCharacter a=aims[i].GetComponent<AbstractCharacter>();
               a.psy += records[i];
                a.RemoveBuff(2);
            }
            records = null;
        }
    }

    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return character.wordName + "���İ�֮�˶���˵�����ž������⣬������������������ʹ������";

    }

}
