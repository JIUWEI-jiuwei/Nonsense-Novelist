using UnityEngine.UI;
using UnityEngine;
using System;

/// <summary>
/// ����ʵ�
/// </summary>
public class Shoot : MonoBehaviour
{
    /// <summary>����λ��</summary>
    public Transform gang;
    /// <summary>����</summary>
    public GameObject bullet;
    /// <summary>���������ĸ�����</summary>
    public Transform bulletRoot;
    /// <summary>��ǰ����</summary>
    [SerializeField]
    private float crtForce = 0;
    /// <summary>��С��</summary>
    private float minForce = 0;
    /// <summary>�����</summary>
    private float maxForce = 200;
    /// <summary>�����ٶ�</summary>
    public float forceSpeed = 80;
    /// <summary>���޷���</summary>
    private bool fired = false;
    /// <summary>����Slider</summary>
    public Slider aimSlider; 

    private void Update()
    {
        aimSlider.value = 0; // ����slider��ֵ

        if (crtForce >= maxForce && !fired)// ���������ֵ
        { 
            crtForce = maxForce;
        }

        if (Input.GetButtonDown("Fire1"))
        { 
            crtForce = minForce; // �������Ĵ�С
            fired = false; // ���ÿ���״̬Ϊδ����
        }
        else if (Input.GetButton("Fire1" ) && !fired)// һֱ����
        { 
            crtForce += forceSpeed * Time.deltaTime; // ����
            aimSlider.value = crtForce/maxForce; // ����slider��ֵ
        }
        else if (Input.GetButtonUp("Fire1" ) && !fired)
        {
            CreateWordBullet(); 
        }
    }
    /// <summary>
    /// ��������ʵ��
    /// </summary>
    void CreateWordBullet()
    {
        fired = true; // ���ÿ���״̬Ϊ�ѿ���

        GameObject go = Instantiate(bullet);

        //Ԥ�������
        go.transform.SetParent(gang);
        go.transform.localPosition = Vector3.zero;
        go.transform.localScale = Vector3.one;
        go.transform.localEulerAngles = Vector3.zero;
        go.transform.SetParent(bulletRoot);

        //���Ӵ�������
        go.AddComponent(AllSkills.CreateSkillWord());

        //���Ӵ���ͼ��

        //���������һ����ʼ����
        go.GetComponent<Rigidbody2D>().AddForce(go.transform.up * crtForce);
    }
}
