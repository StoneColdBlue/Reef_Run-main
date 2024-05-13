using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform charater;
    Vector3 set;

    void Start()
    {
        set = transform.position - charater.position;
    }

    void Update()
    {
        Vector3 stable = charater.position + set;
        stable.x = 0;
        transform.position = stable;
    }
}
