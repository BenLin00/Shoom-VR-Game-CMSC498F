using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
        
    void OnTriggerEnter(Collider other){
        string objName = other.gameObject.name;
        string thisName = this.gameObject.name;
        print(objName);

        if (other.gameObject.name.Equals("Main Camera")){
            if (thisName.Equals("Cube")){
                Player.updatePoints(10, "Cube");
            }  

            if (thisName.Equals("Sphere")){
                Player.updatePoints(20, "Sphere");
            }
                    
            if (thisName.Equals("Cylinder")){
                Player.updatePoints(30, "Cylinder");
            }
            Destroy(this.gameObject);
            
        }

    }

    void Start()
    {
        if (this.gameObject.name.Equals("Cube")){
            this.gameObject.transform.Find("New Text").gameObject.GetComponent<TextMesh>().text="Points: 10";
        }

        if (this.gameObject.name.Equals("Sphere")){
            this.gameObject.transform.Find("New Text").gameObject.GetComponent<TextMesh>().text="Points: 20";
        }

        if (this.gameObject.name.Equals("Cylinder")){
            this.gameObject.transform.Find("New Text").gameObject.GetComponent<TextMesh>().text="Points: 30";
        }

    }

}
