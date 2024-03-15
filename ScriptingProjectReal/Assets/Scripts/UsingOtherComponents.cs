using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingOtherComponents : MonoBehaviour
{
    public GameObject otherGameobject;

    private AnotherScript anotherScript;
    private YetAnotherScript yetAnotherScript;
    private BoxCollider boxCol;

    // Start is called before the first frame update
    void Awake()
    {
        anotherScript = GetComponent<AnotherScript>();
        yetAnotherScript = otherGameobject.GetComponent<YetAnotherScript>();
        boxCol = otherGameobject.GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Start()
    {
        boxCol.size = new Vector3(3, 3, 3);
        Debug.Log("The player's score is " + anotherScript.playerScore);
        Debug.Log("The player has died " + yetAnotherScript.numberOfPlayerDeaths + " times");
    }
}
