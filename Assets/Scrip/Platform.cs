using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    [SerializeField] private float distance = 3f;

    private Vector3 startPos;
    private bool movingRight = true;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        if (movingRight)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);

            if (Vector3.Distance(transform.position, startPos) >= distance)
                movingRight = false;
        }
        else
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);

            if (Vector3.Distance(transform.position, startPos) <= 0.1f)
                movingRight = true;
        }
    }
}