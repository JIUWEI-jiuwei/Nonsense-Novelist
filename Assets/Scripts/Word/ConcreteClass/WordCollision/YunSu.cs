using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ‘»ÀŸ
/// </summary>
public class YunSu : WordCollisionShoot
{

    public override void Awake()
    {
        base.Awake();
        this.gameObject.GetComponent<Collider2D>().sharedMaterial.friction = 0;
    }
   
}
