using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 心碎
/// </summary>
class HeartBroken : AbstractVerbs
{
    public HeartBroken()
    {
        skillID = 2;
        wordName = "心碎";
        bookName = BookNameEnum.allBooks;
        description = "令目标心如刀绞。";
        nickname.Add( "刺痛");
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
    /// 造成150%精神力的伤害
    /// </summary>
    /// <param name="character">施法者</param>
    public override void UseVerbs(GameObject character)
    {
        base.UseVerbs(character);
        foreach (GameObject aim in aims)
        {
            aim.GetComponent<AbstractCharacter>().hp -= (int)(aim.GetComponent<AbstractCharacter>().psy * percentage);
        }
    }

    private float now = 0;//计时
    /// <summary>
    /// 降低30%精神力,持续3秒
    /// </summary>
    public override void Ability()
    {
        int[] records=new int[aims.Length];//记录降低的精神力值
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
