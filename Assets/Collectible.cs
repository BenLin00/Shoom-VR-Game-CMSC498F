using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
        
    void OnCollisionEnter(Collision other){
        string objName = other.collider.gameObject.name;
        string thisName = this.gameObject.name;
        
        if (objName.Equals("Cube")){
            Player.updatePoints(10, "Cube");
        }

        if (objName.Equals("Sphere")){
            Player.updatePoints(20, "Sphere");
        }
                
        if (objName.Equals("Cylinder")){
            Player.updatePoints(30, "Cylinder");
        }


        if (other.collider.gameObject.name.Equals("AROrigin")){
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
