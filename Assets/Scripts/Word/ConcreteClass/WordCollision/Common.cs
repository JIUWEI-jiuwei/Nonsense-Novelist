using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// »ù´¡Åö×²
/// </summary>
public class Common : WordCollisionShoot
{
    public override void OnTriggerEnter2D(Collider2D collision)
    {
        //¸øabsWord¸³Öµ
        absWord = Shoot.abs;
        base.OnTriggerEnter2D(collision);
    }
}
