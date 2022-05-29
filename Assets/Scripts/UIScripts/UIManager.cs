
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
    public static AudioSource audioSource_write;
    private AudioSource audioSource_BGM;
    public AudioClip[] audioClips;
    private CharacterTranslateAndCamera transAndCamera;

    private void Awake()
    {
        charaTransAndCamera = GameObject.Find("MainCamera").GetComponent<CharacterTranslateAndCamera>();
        endPanel = GameObject.Find("endPanel");
        bookEndPanel = GameObject.Find("BookEndPanel");
        loadingScript = GameObject.Find("MainCamera").GetComponent<LoadingScript>();
        audioSource_write = GameObject.Find("AudioSource_wirte").GetComponent<AudioSource>();
        transAndCamera = GameObject.Find("MainCamera").GetComponent<CharacterTranslateAndCamera>();
        audioSource_BGM = GameObject.Find("AudioSource_BGM").GetComponent<AudioSource>();

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
        audioSource_BGM.clip = audioClips[transAndCamera.guanQiaNum + 1];
        audioSource_BGM.Play();
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
                audioSource_write.Play();
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
