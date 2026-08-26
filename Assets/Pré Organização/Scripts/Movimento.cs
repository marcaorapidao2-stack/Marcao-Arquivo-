using UnityEngine;

public class Movimento : MonoBehaviour
{
    public float Vel = 5f;
    public float FPulo = 7f;

    private Rigidbody Corpo;

    void Start()
    {
        Corpo = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float Horizontal = Input.GetAxisRaw("Horizontal");
        float Vertical = Input.GetAxisRaw("Vertical");

        Vector3 Direcao = new Vector3(Horizontal, 0f, Vertical).normalized;

        Corpo.linearVelocity = new Vector3(
            Direcao.x * Vel,
            Corpo.linearVelocity.y,
            Direcao.z * Vel
        );
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Corpo.AddForce(Vector3.up * FPulo, ForceMode.Impulse);
        }
    }
}