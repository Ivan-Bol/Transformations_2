using UnityEngine;

public class Enlarger: MonoBehaviour
{
    [SerializeField] private float _increaseSpeed;

    private void Update()
    {
        transform.localScale += Vector3.one * _increaseSpeed * Time.deltaTime;
    }
}
