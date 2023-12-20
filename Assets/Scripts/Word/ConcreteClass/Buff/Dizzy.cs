using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// buff����ѣ
/// </summary>
public class Dizzy : AbstractBuff
{
    static public string s_description = "�޷��ж�����������ֹͣ";
    static public string s_wordName = "��ѣ";
    float record;
    override protected void Awake()
    {
        base.Awake();
        buffName = "��ѣ";
        description = "�޷��ж�����������ֹͣ";
        book = BookNameEnum.allBooks;
        record = chara.energy;
        if (record > 0.9f) record = 0.9f;
        StartCoroutine(Wait());
        upup = 1;
        isBad = true;
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.1f);
        chara.dizzyTime = maxTime;
        StartCoroutine(Wait());
    }

    public override void Update()
    {
        base.Update();
        chara.energy = record;//��������ֹͣ
    }
}
