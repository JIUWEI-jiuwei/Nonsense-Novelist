using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ‘»ÀŸ
/// </summary>
public class YunSu : WordCollisionShoot
{
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<Collider2D>().sharedMaterial.friction = 0;
    }

}
