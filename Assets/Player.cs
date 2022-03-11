using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField]
    public TextMesh outputText;

    public static int currPoints=0;
    public static int currObjs=0;
    public static int currUniqObj=0;
    public static HashSet<string> types = new HashSet<string>();

    void OnCollisionEnter(Collision other){

    }

    public static void updatePoints(int points, string name) {
        currPoints += points;
        print(currPoints);
        currObjs++;

        if (name.Equals("Cube") || name.Equals("Sphere") || name.Equals("Cylinder")) {
            types.Add(name);
            currUniqObj = types.Count;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    async void Update()
    {
        this.gameObject.transform.Find("New Text").gameObject.GetComponent<TextMesh>().text=
            "Total Points: " + currPoints +  "\n Total Objects Collected: " 
            + currObjs + "\n unique items collected" + currUniqObj;

        if (currUniqObj == 3) {
            this.gameObject.transform.Find("New Text").gameObject.GetComponent<TextMesh>().text=
            "YOU WIN, bEn lIn";
        }
    }

}

