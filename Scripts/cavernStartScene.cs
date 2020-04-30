using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cavernStartScene : MonoBehaviour
{

    public cavernDialogueMan manager;
    public dialogue dialogue;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(beginScene());
    }

    IEnumerator beginScene()//takes current sentence and creates letter animation
    {
        yield return new WaitForSeconds(2.0f);
        manager.startDialogue(dialogue);
    }
}
