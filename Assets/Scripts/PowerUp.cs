 using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public float trunSpeed = 90f;

    private void OnTriggerEnter (Collider other)
    {
        //check if power ups are spawning inside obstacles
        if (other.gameObject.GetComponent<EndlessSpwan>() != null)
        {
            Destroy(gameObject);//destroys them if they are inside objects
            return;
        }

        //Check Collision with player
        if (other.gameObject.name != "Player")
        {
            return;
        }
        //Add to Power Ups
        PointsManager.instan.IncrementScore();

        //Destroy object
        Destroy(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, trunSpeed * Time.deltaTime);
    }
}
