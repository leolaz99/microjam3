using UnityEngine;

public class Distance : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] Transform enemy;

    public float distance;


    void Update()
    {
        distance = player.position.x - enemy.position.x;
    }
}
