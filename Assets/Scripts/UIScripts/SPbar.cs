using UnityEngine;
using UnityEngine.UI;

///<summary>
///����UI
///</summary>
class SPbar : MonoBehaviour
{
    /// <summary>����Ԥ���� </summary>
    public GameObject SPBarPrefab;
    /// <summary>��ɫͷ��������λ�� </summary>
    private Transform SPbarPoint;
    /// <summary>ʣ��������ֵ </summary>
    private Image SPSlider;
    /// <summary>��ɫλ�� </summary>
    private Transform UIbar;
    /// <summary>��ȡ�ý�ɫ </summary>
    private AbstractCharacter chara;
    /// <summary>��λ�� </summary>
    private Transform[] barPoint;

    public void Start()
    {
        chara = gameObject.GetComponent<AbstractCharacter>();
        //SPbarPoint = gameObject.transform.GetChild(1).GetComponent<Transform>();
        barPoint= gameObject.GetComponentsInChildren<Transform>();
        SPbarPoint = barPoint[2];
        foreach (Canvas canvas in FindObjectsOfType<Canvas>())
        {
            if (canvas.name == "UIcanvas")
            {
                UIbar = Instantiate(SPBarPrefab, canvas.transform).transform;
                SPSlider = UIbar.GetChild(0).GetComponent<Image>();
            }
        }
    }
    public void Update()
    {
        UpdateSPBar(chara.sp, chara.maxSP,chara.hp);
        if (UIbar != null)
        {
            UIbar.position = SPbarPoint.position;
        }
    }
    /// <summary>
    /// ����������ֵ
    /// </summary>
    /// <param name="currentHP">��ǰ����</param>
    /// <param name="maxHP">������</param>currentHP=��ǰѪ��
    private void UpdateSPBar(int currentSP, int maxSP,int currentHP)
    {
        if (currentSP <= 0) {
            currentSP = 0;
        }
        if (currentHP <= 0) {
            Destroy(UIbar.gameObject);
        }       
        float sliderPercent = (float)currentSP / maxSP;
        if(SPSlider!=null)SPSlider.fillAmount = sliderPercent;
    }
}
