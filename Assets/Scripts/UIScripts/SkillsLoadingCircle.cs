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
    private List<GameObject> UIbar = new List<GameObject>();
    /// <summary>��ȡ�ý�ɫ </summary>
    private AbstractCharacter charaComponent;
    /// <summary>��λ�� </summary>
    private Transform[] barPoint;
    private int count;
    private AbstractVerbs[] absverbs;

    public void Start()
    {
        charaComponent = gameObject.GetComponent<AbstractCharacter>();
        barPoint = gameObject.GetComponentsInChildren<Transform>();
        verbLoadingPoints = barPoint[3];
        count = charaComponent.skills.Count;
    }
    public void FixedUpdate()
    {
        foreach (Canvas canvas in FindObjectsOfType<Canvas>())
        {
            if (canvas.name == "UIcanvas")
            {
                if(charaComponent.skills.Count>count)
                {
                    absverbs = charaComponent.GetComponents<AbstractVerbs>();
                    count = charaComponent.skills.Count;
                    UIbar.Add(Instantiate(verbLoadingPrefab, canvas.transform));
                    verbCD.Add(UIbar[count - 1].transform.GetChild(0).GetComponent<Image>()) ;
                    UIbar[count - 1].transform.position = verbLoadingPoints.GetChild(count - 1).position;                    
                }
            }
        }      
        if (UIbar != null)
        {            
            for (int i = 0; i < count; i++)
            {
                //��ȡ���ý�ɫ���ϵ�skills���еĶ��ʼ���
                float percent = absverbs[i].cd / absverbs[i].maxCD;
                verbCD[i].fillAmount = percent;
                UIbar[count - 1].transform.position = verbLoadingPoints.GetChild(count - 1).position;
            }
        }
        if (charaComponent.hp <= 0)
        {
            for(int i = 0; i < UIbar.Count; i++)
            {
                Destroy(UIbar[i]);
            }
        }
    }
}
