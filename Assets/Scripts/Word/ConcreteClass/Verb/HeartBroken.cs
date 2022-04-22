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
        banAim.Add( new Sense());
        skillMode = new DamageMode();
        percentage = 1.5f;
        attackDistance = Mathf.Infinity;
        skillTime = 0;
        skillEffectsTime = 3;
        cd=maxCD=5;
        comsumeSP = 5;
        prepareTime = 0.5f;
        afterTime = 1;
        allowInterrupt = false;
        possibility = 0;
    }
    /// <summary>
    /// ���150%���������˺�
    /// </summary>
    /// <param name="character">ʩ����</param>
    public override void UseVerbs(GameObject character)
    {
        base.UseVerbs(character);
        foreach (GameObject aim in aims)
        {
            aim.GetComponent<AbstractCharacter>().hp -= (int)(aim.GetComponent<AbstractCharacter>().psy * percentage);
        }
    }

    private float now = 0;//��ʱ
    /// <summary>
    /// ����30%������,����3��
    /// </summary>
    public override void Ability()
    {
        int[] records=new int[aims.Length];//��¼���͵ľ�����ֵ
        for(int i=0;i<aims.Length;i++)
        {
            records[i] = (int)(aims[i].GetComponent<AbstractCharacter>().psy * 0.3f);
            aims[i].GetComponent<AbstractCharacter>().psy-=records [i];
        }
        now += Time.deltaTime;
        if (now>= 3)
        {
            now = 0;
            for (int i = 0; i < aims.Length; i++)
            {
                aims[i].GetComponent<AbstractCharacter>().psy += records[i];
            }
        }
    }
}
