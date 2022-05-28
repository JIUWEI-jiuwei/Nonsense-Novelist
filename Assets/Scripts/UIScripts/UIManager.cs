
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
    private static CharacterTranslateAndCamera charaTransAndCamera;
    /// <summary>��ȡ�ؿ��������</summary>
    private static GameObject endPanel;
    /// <summary>��ȡ�½ڽ������</summary>
    public static GameObject bookEndPanel;
    public static LoadingScript loadingScript;

    private void Awake()
    {
        charaTransAndCamera = GameObject.Find("MainCamera").GetComponent<CharacterTranslateAndCamera>();
        endPanel = GameObject.Find("endPanel");
        bookEndPanel = GameObject.Find("BookEndPanel");
        loadingScript = GameObject.Find("MainCamera").GetComponent<LoadingScript>();
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
    public static bool WinEnd()
    {
       

            if (GameObject.Find("EnemyCharacter").transform.childCount <= 1 && charaTransAndCamera.guanQiaNum <= 1)
            {
                //�򿪹ؿ��������
                endPanel.transform.GetChild(0).gameObject.SetActive(true);
                return true;
            }
            if (GameObject.Find("EnemyCharacter").transform.childCount <= 1 && charaTransAndCamera.guanQiaNum == 2)
            {
                //���½ڽ������
                bookEndPanel.transform.GetChild(0).gameObject.SetActive(true);
                return true;
            }
        
        return false;
    }

    /// <summary>
    /// �жϵ�ǰ�ؿ��Ƿ����
    /// </summary>
    /// <returns></returns>
    public static bool LoseEnd()
    {
        if (GameObject.Find("SelfCharacter").transform.childCount <= 1 )
        {
            //ʧ������ת��loading���棬����ת��startgame����
            loadingScript.enabled = true;
            return true;
        }
        return false;
    }
}
