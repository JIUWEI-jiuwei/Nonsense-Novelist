using UnityEngine.UI;
using UnityEngine;
using System.Collections.Generic;

///<summary>
///���ܴ�����ԲȦ������ʾ
///</summary>
class SkillsLoadingCircle : MonoBehaviour
{
    /// <summary>����ԲȦԤ���� </summary>
    public GameObject verbLoadingPrefab;    
    /// <summary>��ɫͷ������ԲȦ�ĸ�����λ�� </summary>
    private Transform verbLoadingPoints;
    /// <summary>ʣ�����ʱ����ֵ </summary>
    private List<Image> verbCD = new List<Image>();
    /// <summary>��ɫλ�� </summary>
    private GameObject UIbar;
    /// <summary>��ȡ�ý�ɫ </summary>
    private AbstractCharacter charaComponent;
    /// <summary>��λ�� </summary>
    private Transform[] barPoint;


    public void Start()
    {
        charaComponent = gameObject.GetComponent<AbstractCharacter>();
        barPoint = gameObject.GetComponentsInChildren<Transform>();
        verbLoadingPoints = barPoint[3];
        foreach (Canvas canvas in FindObjectsOfType<Canvas>())
        {
            if (canvas.name == "UIcanvas")
            {
                for (int i = 0; i < charaComponent.skills.Count; i++)
                {
                    UIbar = Instantiate(verbLoadingPrefab, canvas.transform);
                    verbCD[i] = UIbar.transform.GetChild(i).GetComponent<Image>();
                    UIbar.transform.position = verbLoadingPoints.GetChild(i).position;
                }                   
            }
        }
    }
    public void FixedUpdate()
    {
        UpdateHealthBar();
        if (UIbar != null)
        {
            for (int i = 0; i < charaComponent.skills.Count; i++)
            {                
                UIbar.transform.position = verbLoadingPoints.GetChild(i).position;
            }
        }
    }
    /// <summary>
    /// ����CD����
    /// </summary>
    public void UpdateHealthBar()
    {
        for (int i = 0; i < charaComponent.skills.Count; i++)
        {//��ȡ���ý�ɫ���ϵ�skills���еĶ��ʼ���
            verbCD[i].fillAmount = charaComponent.skills[i].cd / charaComponent.skills[i].maxCD;
        }
    }
}
