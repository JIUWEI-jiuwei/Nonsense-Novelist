using UnityEngine;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
using System.Collections;
///<summary>
///弹道（挂在子弹上）
///</summary>
class DanDao: MonoBehaviour
{
    /// <summary>外部赋值</summary>
    [HideInInspector] public GameObject aim;
    /// <summary>外部赋值</summary>
    [HideInInspector] public Transform birthTransform;
    /// <summary>外部赋值</summary>
    [HideInInspector] public float bulletSpeed = 1;
    bool a;

    private void OnEnable()
    {
        this.transform.position  = birthTransform.position;
        a = true;
    }

    private void Update()
    {
        if(a && aim != null)
        {
            a = false;
            StartCoroutine(Wait());
            this.transform.right=  aim.transform.position- this.transform.position;
            this.transform.Translate((aim.transform.position-this.transform.position).normalized*bulletSpeed,Space.World);
        }
        if(aim!=null && Vector3.Distance(this.transform.position, aim.transform.position)<1)
        {
            this.gameObject.SetActive(false);
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.05f);
        a = true;
    }
}
