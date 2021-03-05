using System.Collections;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    bool isStart = false;
    Distance distanceInstance;

    IEnumerator DelayStart()
    {
        yield return new WaitForSeconds(1.5f);
        transform.rotation = Quaternion.Euler(0, 0, 0);
        isStart = true;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneLoader.instance.GoToGameOver();
    }


    void Awake()
    {
        distanceInstance = GetComponent<Distance>();
    }

    void Start()
    {
        StartCoroutine(DelayStart());
    }

    void Update()
    {
        if (isStart)
        {
            if (distanceInstance.distance <= 5)
                transform.Translate(Vector3.right * 1 * Time.deltaTime);

            if (distanceInstance.distance > 5 && distanceInstance.distance <= 15)
                transform.Translate(Vector3.right * 3 * Time.deltaTime);

            if (distanceInstance.distance > 15)
                transform.Translate(Vector3.right * 10 * Time.deltaTime);
        }
    }
}
