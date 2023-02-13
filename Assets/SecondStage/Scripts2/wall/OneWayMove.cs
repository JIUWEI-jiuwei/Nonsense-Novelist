using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ǽ���ƶ�or��ת
/// </summary>
public class OneWayMove : MonoBehaviour
{
    /// <summary>ˮƽ����</summary>
    private float hori_way;
    public float value1 = 10;
    /// <summary>��ֱ����</summary>
    private float ver_way;
    public float value2 = 10;
    /// <summary>��ת�Ƕ�</summary>
    public float angle = 1;
    /// <summary>��ʧʱ��</summary>
    public float disappearTime = 2;
    /// <summary>����λ��</summary>
    public Transform exitPoint;
    /// <summary>�����ٶ�ϵ��</summary>
    public float k = 0.5f;

    /// <summary>�ж�</summary>
    public int or = 0;
    // Update is called once per frame
    void Update()
    {
        if (or==0)//ˮƽ����
        {
            hori_way = Mathf.PingPong(Time.time, value1);
            transform.position = new Vector3(hori_way, transform.position.y, transform.position.z);
        }
        else if (or == 1)//��ֱ����
        {
            ver_way = Mathf.PingPong(Time.time, value2);
            transform.position = new Vector3(transform.position.x, ver_way, transform.position.z);
        }
        else if(or==2)//������ת
        {
            transform.RotateAround(this.transform.position, Vector3.forward, angle);

        }

    }
    /// <summary>
    /// ǽ����ʧ���ٳ���
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (or == 3)//��ʧ���ٳ���
        {
            if (collision.transform.tag == "bullet")
            {
                this.gameObject.SetActive(false);
                Invoke("EnableBack", disappearTime);
            }
        }
        
    }
    public void EnableBack()
    {
        this.gameObject.SetActive(true);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (or == 4)//�������ţ���������ײ��
        {
            if (collision.transform.tag == "bullet")
            {
                Vector3 a = collision.GetComponent<Rigidbody2D>().velocity*k;

                while(a.magnitude <= 1)//��ֹ�ٶȹ���
                {
                    a = collision.GetComponent<Rigidbody2D>().velocity * 2;
                }
                collision.transform.position = exitPoint.position+a;
            }
        }
    }
}
