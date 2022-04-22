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
        skillMode = new ChangeATKMode();
        attackDistance = 5;
        skillTime = 0;
        skillEffectsTime = 5;
        cd=maxCD=18;
        comsumeSP = 10;
        prepareTime = 2;
        afterTime = 0;
        allowInterrupt = true;
        possibility = 0;
        abilitySustainTime = 5;
    }

    private float now = 0;//��ʱ
    /// <summary>
    /// ����30%�������Ĺ�����,����5��
    /// </summary>
    public override void Ability()
    {
        foreach (GameObject aim in aims)
        {
            aim.GetComponent<AbstractCharacter>().atk += (int)(aim.GetComponent<AbstractCharacter>().psy * 0.3f);
        }
        now += Time.deltaTime;
        if (now> 5)
        {
            foreach (GameObject aim in aims)
            {
                aim.GetComponent<AbstractCharacter>().atk -= (int)(aim.GetComponent<AbstractCharacter>().psy * 0.3f);
            }
        }
    }
}
