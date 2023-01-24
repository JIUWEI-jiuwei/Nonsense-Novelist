using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ͬƵ����
/// </summary>
class TongPinGongZhen: AbstractVerbs
{
    public override void Awake()
    {
        base.Awake();
        wordSort = WordSortEnum.verb;
        skillID = 9;
        wordName = "ͬƵ����";
        bookName = BookNameEnum.CrystalEnergy;
        description = "ѧ��ͬƵ�����ø����ĵ�����ѣ1.5�롣";
        skillMode = gameObject.AddComponent<UpATKMode>();
        skillMode.attackRange = new SingleSelector();
        attackDistance = 5;
        skillTime = 0;
        skillEffectsTime = 1.5f;
        cd=maxCD=5;
        prepareTime = 1;
        afterTime = 0;
        description = "ͨ���ų��Ĺ�������Χ�ĵ�����ѣ��";
    }

    /// <summary>
    /// �������Ѿ��ظ�5��SP
    /// </summary>
    /// <param name="useCharacter">ʩ����</param>
    public override void UseVerbs(AbstractCharacter useCharacter)
    {
        base.UseVerbs(useCharacter);
        SpecialAbility(useCharacter);
    }

    /// <summary>
    /// �����е�����ѣ1.5��
    /// </summary>
    public override void SpecialAbility(AbstractCharacter useCharacter)
    {
        foreach (AbstractCharacter aim in aims)
        {
            aim.dizzyTime = skillEffectsTime;
            aim.AddBuff(5);
        }
    }

    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return character.wordName + "������ˮ���������ٻ�����������ˮ����Ħ��������һ�־��й��ɵ��񶯣�"+character.wordName+"ͨ����������������ػ�������������������ɽ�嶼������������";

    }

}
