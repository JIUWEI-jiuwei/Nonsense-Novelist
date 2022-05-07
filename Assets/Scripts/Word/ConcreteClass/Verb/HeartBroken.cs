using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ����
/// </summary>
class HeartBroken : AbstractVerbs
{
    public void Awake()
    {
        skillID = 2;
        wordName = "����";
        bookName = BookNameEnum.allBooks;
        description = "��Ŀ�����絶�ʡ�";
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
            records[i] = (int)(aims[i].GetComponent<AbstractCharacter>().psy * 0.3f);
            aims[i].GetComponent<AbstractCharacter>().psy-=records [i];
        }
    }
    override public  void Update()
    {
        base.Update();
        if (now < skillEffectsTime)
        {
            now += Time.deltaTime;
        }
        else if (now >= skillEffectsTime)//ʱ�䵽
        {
            for (int i = 0; i < aims.Length; i++)
            {
                aims[i].GetComponent<AbstractCharacter>().psy += records[i];
            }
        }
    }
}
