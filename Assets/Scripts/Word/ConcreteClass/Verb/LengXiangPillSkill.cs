using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ������
/// </summary>
class LengXiangPillSkill : AbstractVerbs
{
    public void Awake()
    {
        skillID = 5;
        wordName = "������";
        bookName = BookNameEnum.HongLouMeng;
        banUse.Add(new Biology());
        skillMode = new CureMode();
        skillMode.attackRange = new CircleAttackSelector();//
        percentage = Mathf.Infinity;//����(���ô˱�����
        attackDistance = 2;
        skillTime = 0f;
        skillEffectsTime = 0;
        cd=maxCD=6;
        comsumeSP = 0;
        prepareTime = 0.5f;
        afterTime = 0;
        allowInterrupt = false;
        possibility = 0;
    }
    /// <summary>
    /// ����Ѫ
    /// </summary>
    /// <param name="character">ʩ����</param>
    public override void UseVerbs(AbstractCharacter character)
    {
        base.UseVerbs(character);
        foreach (GameObject aim in aims)
        {
            aim.GetComponent<AbstractCharacter>().hp = aim.GetComponent<AbstractCharacter>().maxHP;
        }
        SpecialAbility();
    }
    /// <summary>
    /// ������и���״̬
    /// </summary>
    public override void SpecialAbility()
    {

    }
}
