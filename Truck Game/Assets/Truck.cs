using UnityEngine;

public class Truck : MonoBehaviour
{
    public float MovementSpeed;
    void Start()
    {
        MovementSpeed = Random.Range(MovementSpeed, MovementSpeed + 15);
        this.transform.GetChild(0).gameObject.GetComponent<Rigidbody>().linearDamping = Random.Range(0.1f, 1f);
    }

    void Update()
    {
        transform.position += this.transform.forward * Time.deltaTime * MovementSpeed;
    }
}
