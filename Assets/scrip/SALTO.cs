using UnityEngine;

public class SALTO : MonoBehaviour
{
    [SerializeField] float fuerzaSalto = 10f;
    [SerializeField] float distancia = 1f;
    bool tocandoElSuelo = true;
    void Start()
    {
        
    }

    
    void Update()
    {
        tocandoElSuelo = Physics.Raycast(transform.position, Vector3.down, distancia);
        //if (tocandoElSuelo)
        Debug.DrawRay(transform.position, Vector3.down * distancia,tocandoElSuelo ? Color.green : Color.red);
        //Debug.DrawRay(transform.position, Vector3.down * distancia, Color.red);

        //else

        //Debug.DrawRay(transform.position, Vector3.down * distancia, Color.green);

        if (Input.GetKeyDown(KeyCode.Space) && tocandoElSuelo)
        {
            
            GetComponent<Rigidbody>().AddForce(Vector3.up*fuerzaSalto, ForceMode.Impulse);
        }
    }
}
