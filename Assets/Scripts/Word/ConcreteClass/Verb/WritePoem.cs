using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ��ʫ
/// </summary>
class WritePoem : AbstractVerbs
{
    public void Awake()
    {
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
    /// <summary>
    /// ����30%�������Ĺ�����,����5��
    /// </summary>
    public override void SpecialAbility()
    {
        foreach (GameObject aim in aims)
        {
            skillMode.UseMode(null,aim.GetComponent<AbstractCharacter>().psy * 0.3f, aim.GetComponent<AbstractCharacter>());
        }
        now += Time.deltaTime;
        if (now> skillEffectsTime)
        {
            foreach (GameObject aim in aims)
            {
                skillMode.UseMode(null,-aim.GetComponent<AbstractCharacter>().psy * 0.3f, aim.GetComponent<AbstractCharacter>());
            }
        }
    }

    public override void UseVerbs(AbstractCharacter character)
    {
        base.UseVerbs(character);
        SpecialAbility();
    }
}
