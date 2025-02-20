using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] private Transform orientationtransform;

    float horizontalinput, verticalinput;
    Vector3 movementdirection;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
 
    void Update()
    {
        SetInputs();
        
    }

    void SetInputs(){
        horizontalinput = Input.GetAxisRaw("Horizontal");
        verticalinput = Input.GetAxisRaw("Vertical");
    }

    void SetPlayerMovement(){
        movementdirection = orientationtransform.forward * verticalinput + orientationtransform.right * horizontalinput;
    }

}
