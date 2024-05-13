using UnityEngine;

public class EndlessSpwan : MonoBehaviour
{
    public GameObject ground;
    Vector3 nextTile;

    public void NewTile()
    {
        GameObject pos = Instantiate(ground, nextTile, Quaternion.identity);
        nextTile = pos.transform.GetChild(1).transform.position;
    }

    void Start()
    {
        for (int i = 0; i < 15; i++)
        {
            NewTile();
        }
    }

    private void Update()
    {
        
    }
}
