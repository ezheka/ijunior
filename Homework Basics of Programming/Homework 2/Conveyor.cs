using UnityEngine;

public class Conveyor : MonoBehaviour
{
    [SerializeField] private Vector3 _direction;
    private float _speed = 3f;

    private void OnCollisionStay(Collision collision)
    {
        collision.gameObject.transform.position += _direction * _speed * Time.deltaTime;
    }
}
