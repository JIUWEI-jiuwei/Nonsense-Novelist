
using UnityEngine;
using UnityEngine.UI;

///<summary>
///UI������(����һ��UIManager�����壬��������)
///</summary>
class UIManager  : MonoBehaviour
{
    /// <summary>ս�������Ƿ������һ��</summary>
    public static bool nextQuanQia;
    /// <summary>�ű�</summary>
    private CharacterTranslateAndCamera charaTransAndCamera;
    /// <summary>��ȡ�ؿ��������</summary>
    private static GameObject endPanel;    

    private void Awake()
    {
        charaTransAndCamera = GameObject.Find("MainCamera").GetComponent<CharacterTranslateAndCamera>();
        endPanel = GameObject.Find("endPanel");
        
    }
    /// <summary>
    /// ÿһ�µ���һ�ذ�ť
    /// </summary>
    public void NextQuanQia()
    {
        //�򿪹ؿ��������
        endPanel.transform.GetChild(0).gameObject.SetActive(false);
        charaTransAndCamera.BeginMove();
        nextQuanQia = true;
    }
    /// <summary>
    /// �жϵ�ǰ�ؿ��Ƿ����
    /// </summary>
    /// <returns></returns>
    public static bool isEnd()
    {
        if (GameObject.Find("EnemyCharacter").transform.childCount <= 1)
        {
            //�򿪹ؿ��������
            endPanel.transform.GetChild(0).gameObject.SetActive(true);
            return true;
        }
        return false;
    }
}
