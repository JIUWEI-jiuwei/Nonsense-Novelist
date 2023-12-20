using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// buff：晕眩
/// </summary>
public class Dizzy : AbstractBuff
{
    float record;
    override protected void Awake()
    {
        base.Awake();
        buffName = "晕眩";
        description = "无法行动，能量增长停止";
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
        chara.energy = record;//能量增长停止
    }
}
