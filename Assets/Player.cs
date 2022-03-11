using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public static int currPoints=0;

    void OnCollisionEnter(Collision other){
        // string objName = other.collider.gameObject.name;

        // if (other.collider.gameObject.GetComponent<Collectible>()){
        //     print("I hit another collectible called "+other.collider.gameObject.name);
        // }

        // if (objName.Equals("Cube")){
        //     currPoints += 10;
        // }

        // if (objName.Equals("Sphere")){
        //     updatePoints(20);
        // }
                
        // if (objName.Equals("Cylinder")){
        //     updatePoints(30);
        // }

    }

    public static void updatePoints(int points) {
        currPoints += points;
        print(currPoints);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
