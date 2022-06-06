using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigidBody2D;
    SurfaceEffector2D surfaceEffector2D;
    [SerializeField] float torqueAmount = 1f;
    [SerializeField] float boostSpeed = 300f;
    [SerializeField] float normalSpeed = 20f;

    bool canMove = true;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(canMove){
            PlayerRotation();
            PlayerBoost();
        }
        
    }

    public void DisableControls(){
        canMove = false;
    }

    private void PlayerRotation()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidBody2D.AddTorque(torqueAmount);

        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidBody2D.AddTorque(-torqueAmount);
        }
    }

    private void PlayerBoost(){

        if (Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector2D.speed = boostSpeed;
        }
        else
        {
            surfaceEffector2D.speed = normalSpeed;
        }
    
    }
}
