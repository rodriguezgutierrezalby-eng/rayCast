using UnityEngine;

public class JuegoRayCast : MonoBehaviour
{
    
    void Start()
    {
        //Camera.main.ScreenPointToRay(Input.mousePosition);
    }

    // Update is called once per frame
    void Update()
    {
        //print(Input.mousePosition);
        Ray rayo = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        Physics.Raycast(rayo, out hit);

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(rayo, out hit))
            {
                if (hit.collider.gameObject.tag == "Destrutibles")
                {
                    //print(hit.collider.gameObject.name);
                    Destroy(hit.collider.gameObject);
                }
                
            }
        }
    }
}
