using UnityEngine;

public class enemy : MonoBehaviour
{

    public Transform position1;
    public Transform position2;
    
    public float velocity;

    private bool seguindoPos1 = true; 
    private Rigidbody2D rb; 

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(this.gameObject.transform.position.x>position1.position.x){
            rb.linearVelocity = new Vector2 (-velocity, rb.linearVelocity.y);
        } else {
            rb.linearVelocity = new Vector3 (velocity, rb.linearVelocity.y);
            
        }    
        }
}
