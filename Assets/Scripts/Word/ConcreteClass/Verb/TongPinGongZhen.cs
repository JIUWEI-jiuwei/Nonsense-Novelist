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
        skillID = 8;
        wordName = "ͬƵ����";
        bookName = BookNameEnum.CrystalEnergy;
        description = "ʹ���ѻ�á�����";
        skillMode = gameObject.AddComponent<UpATKMode>();
        skillMode.attackRange = new SingleSelector();
        skillEffectsTime = 30;
        rarity = 2;
        needCD=2;

    }

    /// <summary>
    /// �������Ѿ��ظ�5��SP
    /// </summary>
    /// <param name="useCharacter">ʩ����</param>
    public override void UseVerbs(AbstractCharacter useCharacter)
    {
        base.UseVerbs(useCharacter);
        buffs.Add(skillMode.CalculateAgain(attackDistance, useCharacter)[0].gameObject.AddComponent<GongZhen>());
        buffs[0].maxTime = skillEffectsTime;
    }


    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return character.wordName + "������ˮ���������ٻ�����������ˮ����Ħ��������һ�־��й��ɵ��񶯣�"+character.wordName+"ͨ����������������ػ�������������������ɽ�嶼������������";

    }

}
