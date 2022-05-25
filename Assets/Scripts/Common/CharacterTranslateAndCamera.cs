using UnityEngine;
using UnityEngine.UI;

///<summary>
///��ɫ�ƶ�+������ƶ�(���������
///</summary>
class CharacterTranslateAndCamera : MonoBehaviour
{
    private GameObject[] characters1;
    private Camera camera_;
    public float moveSpeed = 0.1f;
    private GameObject[] targets;
    private int guanQiaNum = 0;
    public GameObject[] zhuangShiPin;

    private void Start()
    {
        camera_ = GameObject.Find("MainCamera").GetComponent<Camera>();
        targets = new GameObject[3];
        targets[1] = GameObject.Find("target2");
        targets[2] = GameObject.Find("target3");
    }
    private void FixedUpdate()
    {
        if (UIManager.nextQuanQia && characters1.Length != 0)
        {   
            //������ƶ�
            camera_.transform.Translate(Vector3.right*moveSpeed);
            //ʣ���ɫ�ƶ�
            foreach(var item in characters1)
            {
                item.transform.Translate(Vector3.right * moveSpeed);
            }
        }
        EndMove();
    }
    public void BeginMove()
    {
        AbstractCharacter[] tempCharacters = GameObject.Find("SelfCharacter").GetComponentsInChildren<AbstractCharacter>();
        characters1 = new GameObject[tempCharacters.Length];
        for(int i=0; i < tempCharacters.Length; i++)
        {
            characters1[i] = tempCharacters[i].gameObject;
        }
    }
    public void EndMove()
    {
        if (Vector3.Distance(camera_.transform.position, targets[guanQiaNum+1].transform.position) <= 1f)
        {
            camera_.transform.position = targets[guanQiaNum+1].transform.position;
            UIManager.nextQuanQia = false;
            zhuangShiPin[guanQiaNum + 1].SetActive(true);
            zhuangShiPin[guanQiaNum].SetActive(false);
            guanQiaNum++;//��һ����Զ���������
        }
    }
}
