using UnityEngine.UI;
using UnityEngine;

///<summary>
///�رմ����������(���ڴ������������)
///</summary>
class DestroyWordDetals : MonoBehaviour
{
    /// <summary>��������</summary>
    public GameObject wordDetail;
    private GameObject otherCanvas;
    private void Start()
    {
        otherCanvas = GameObject.Find("MainCanvas");
    }
    public void CloseDetails()
    {
        Destroy(this.gameObject.transform.parent.gameObject);
        Time.timeScale = 1;
    }
    /// <summary>
    /// �鿴������ϸ��Ϣ
    /// </summary>
    public void ShowDetails()
    {
        //��ȡ������
        Transform a = Instantiate(wordDetail, otherCanvas.transform).transform.GetChild(0).GetChild(0);
        a.transform.GetChild(0).GetComponent<Text>().text = this.GetComponent<AbstractWords0>().wordName;
        a.transform.GetChild(1).GetComponent<Text>().text = this.GetComponent<AbstractWords0>().description;
        Time.timeScale = 0;
    }
}
