using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ������ײ
/// </summary>
public class Common : WordCollisionShoot
{
    public override void OnTriggerEnter2D(Collider2D collision)
    {
        //��absWord��ֵ
        absWord = Shoot.abs;
        base.OnTriggerEnter2D(collision);
    }
}
