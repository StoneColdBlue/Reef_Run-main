using UnityEngine;

public class DeathBehavior : MonoBehaviour
{
    CharacterMovement playerMovement;
    
    // Start is called before the first frame update
    void Start()
    {
        playerMovement = GameObject.FindObjectOfType<CharacterMovement>();//specifying the variable
    }

    private void OnCollisionEnter(Collision collision)//Detects collisions
    {
        //Kills player if it touches the objects
        if (collision.gameObject.name == "Player")
        {
            playerMovement.Death();
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
