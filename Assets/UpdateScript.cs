using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateScript : MonoBehaviour
{
    private GameObject selected;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
  {
         if (Input.GetMouseButtonDown(0))
         {
             RaycastHit raycastHit;
             Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
             if (Physics.Raycast(ray, out raycastHit, 100f))
             {
                 if (raycastHit.transform != null)
                 {
                     CurrentClickedGameObject(raycastHit.transform.gameObject);
                 }
             }
         }

        if (selected == null)
        {
            return;
        }

         if (Input.GetKeyDown(KeyCode.RightArrow))
         {
            selected.GetComponent<Rigidbody>().AddForce(500 * Time.deltaTime, 0, 0);
         }
         if (Input.GetKeyDown(KeyCode.LeftArrow))
         {
            selected.GetComponent<Rigidbody>().AddForce(-500 * Time.deltaTime, 0, 0);
         }
  }
 
 public void CurrentClickedGameObject(GameObject gameObject)
 {
     if(gameObject.tag=="TestSphere")
     {
        selected = gameObject;
     }
 }
}
