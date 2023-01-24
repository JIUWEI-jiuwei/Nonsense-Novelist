using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ��������
/// </summary>
class CHOOHShoot : AbstractVerbs
{
    public override void Awake()
    {
        base.Awake();
        wordSort = WordSortEnum.verb;
        skillID = 7;
        wordName = "��������";
        bookName = BookNameEnum.PHXTwist;
        description = "ѧ���������䣬���150%���������˺�������2���������";
        attackDistance = 5;
        skillMode = gameObject.AddComponent<DamageMode>();
        skillMode.attackRange = new SingleSelector();
        attackDistance = 5;
        skillTime = 0;
        skillEffectsTime = 7;
        cd=maxCD=3;
        prepareTime = 0.3f;
        afterTime = 0;
        description = "��ȫ�������ټ�ѹ��������Ķ�Һ���Ը�ʴ���ס�";
    }


    private float now = 0;//��ʱ
    /// <summary>
    /// ��ʴ���ɵ���9�Σ�ÿ��-2����
    /// </summary>
    public override void SpecialAbility(AbstractCharacter useCharacter)
    {
        
        for (int i = 0; i < aims.Length; i++)
        {
            if (!aims[i].buffs.ContainsKey(9) || aims[i].buffs[10] < 9)
            {
                aims[i].def -= 2;
                aims[i].AddBuff(10);
                now = 0;
            }
        }
    }
    override public void FixedUpdate()
    {
        base.FixedUpdate();
        if (now < skillEffectsTime)
        {
            now += Time.deltaTime;
        }
        else if (now >= skillEffectsTime && aims!=null)
        {
            for (int i = 0; i < aims.Length; i++)
            {
                aims[i].def += 2;
                aims[i].RemoveBuff(10);
            }
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

        return character.wordName + "�Ķ����Լ����������壬ͻȻ�����������������һ�����Ե�Һ�壬��������������2��������";

    }
}
