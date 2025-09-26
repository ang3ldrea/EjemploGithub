using UnityEngine;

public class CONTADORDEESPACIOS : MonoBehaviour
{
    int vecesPulsado = 0;
    Rigidbody rb;
    public float hoberfloat = 6f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
           
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyUp(KeyCode.Space) == true)  
       {
            rb.AddForce(Vector3.up * hoberfloat, ForceMode.Impulse);
            vecesPulsado = vecesPulsado + 1;
            if (vecesPulsado == 8)
            {
                Debug.Log("Pulsado 8 veces");
                vecesPulsado = 0;
            }
            else
            {
                Debug.Log("vecesPulsado = " + vecesPulsado);
            }
            

        }


    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Entra en colisión");
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Sale en colisión");

    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Mantiene en colisión");
    }






}
