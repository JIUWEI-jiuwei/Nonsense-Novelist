using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCharacterDetail : MonoBehaviour
{

    public void CloseDetail()
    {
        Destroy(this.gameObject);
    }
}
