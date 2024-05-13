using UnityEngine;

public class GroundTrigger : MonoBehaviour
{
    EndlessSpwan groundSpwan;
    void Start()
    {
        groundSpwan = GameObject.FindObjectOfType<EndlessSpwan>();//triggers the tiles to spwan endlessly
        SpawnObstacles();
        SpawnPower();
    }

    private void OnTriggerExit(Collider other)//This is a restart to the game 
    {
        groundSpwan.NewTile();//spawns a new game
        Destroy(gameObject, 2);//Delays the restart by 2 seconds
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int rnOBJ = 0;
    public GameObject obstaclePrefab1;
    public GameObject obstaclePrefab2;
    public GameObject obstaclePrefab3;

    void RandomObject()
    {
        rnOBJ = Random.Range(1,4);

        switch(rnOBJ)
        {
            case 0:
                if (rnOBJ == 1)
                {
                    //random point for spawning obstacle
                    int obstecleSpawnIndex = Random.Range(2, 5);//randomizes between children
                    Transform spawnPoint = transform.GetChild(obstecleSpawnIndex).transform;//this gets the childs transform from unity
                                                                                            //spwan obstacle
                    Instantiate(obstaclePrefab1, spawnPoint.position, Quaternion.identity/*keeps it from rotating*/, transform);
                }

                break;
            case 1:
                if (rnOBJ == 2)
                {
                    //random point for spawning obstacle
                    int obstecleSpawnIndex = Random.Range(2, 5);//randomizes between children
                    Transform spawnPoint = transform.GetChild(obstecleSpawnIndex).transform;//this gets the childs transform from unity
                                                                                            //spwan obstacle
                    Instantiate(obstaclePrefab2, spawnPoint.position, Quaternion.identity/*keeps it from rotating*/, transform);
                }
                break;
            case 2:
                if (rnOBJ == 3)
                {
                    //random point for spawning obstacle
                    int obstecleSpawnIndex = Random.Range(2, 5);//randomizes between children
                    Transform spawnPoint = transform.GetChild(obstecleSpawnIndex).transform;//this gets the childs transform from unity
                                                                                            //spwan obstacle
                    Instantiate(obstaclePrefab3, spawnPoint.position, Quaternion.identity/*keeps it from rotating*/, transform);
                }
                break;
        }
    }

    void SpawnObstacles()
    {
        
        //random point for spawning obstacle
        int obstecleSpawnIndex = Random.Range(2, 5);//randomizes between children
        Transform spawnPoint = transform.GetChild(obstecleSpawnIndex).transform;//this gets the childs transform from unity
        //spwan obstacle
        Instantiate(obstaclePrefab1, spawnPoint.position, Quaternion.identity/*keeps it from rotating**/, transform );
    }

    public GameObject powerUpPrefab;//variable to store power ups

    //spawn tokens for power ups but for now is a score token
    void SpawnPower()
    {
        int tokenSpawn = 30;//token amount
        for (int i = 0; i < tokenSpawn; i++)
        {
            GameObject tokenCoin = Instantiate(powerUpPrefab, transform);//spawns token
            tokenCoin.transform.position = GetRandomPointInCollider(GetComponent<Collider>());
        }
    }
   
    Vector3 GetRandomPointInCollider (Collider collider)//function to get the location for coin spawn
    {
        Vector3 location = new Vector3
            (
                Random.Range(collider.bounds.min.x, collider.bounds.max.x),//This sets the random spwan to always be on the platform
                Random.Range(collider.bounds.min.y, collider.bounds.max.y),
                Random.Range(collider.bounds.min.z, collider.bounds.max.z)
            );

        if ( location != collider.ClosestPoint(location))
        {
            location = GetRandomPointInCollider(collider);//sets the coins to spwan on the platform
        }

        location.y = 1;//makes the coins spawn on the ground
        return location;
    }
}
