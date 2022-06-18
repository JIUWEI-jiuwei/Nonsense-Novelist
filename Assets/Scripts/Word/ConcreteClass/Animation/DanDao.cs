using UnityEngine;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
using System.Collections;
///<summary>
///�����������ӵ��ϣ�
///</summary>
class DanDao: MonoBehaviour
{
    /// <summary>�ⲿ��ֵ</summary>
    [HideInInspector] public GameObject aim;
    /// <summary>�ⲿ��ֵ</summary>
    [HideInInspector] public Transform birthTransform;
    /// <summary>�ⲿ��ֵ</summary>
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
            this.transform.LookAt( this.transform.position- aim.transform.position );
            this.transform.Translate((aim.transform.position-this.transform.position).normalized*bulletSpeed);
        }
        if(aim!=null && Vector3.Distance(this.transform.position, aim.transform.position)<2)
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
