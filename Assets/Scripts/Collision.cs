using UnityEngine;

public class Treat : MonoBehaviour
{
    [SerializeField] float delay = 0.1f;
    private bool FullMouth = false;

    void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.gameObject.CompareTag("Treat") && !FullMouth)
        {
            Debug.Log("Treat Collected");
            FullMouth = true;
            GetComponent<ParticleSystem>().Play();
            Destroy(collision.gameObject, delay);
        }
        if(collision.gameObject.CompareTag("Guardian") && FullMouth)
        {
            Debug.Log("Treat stored at Guardian");
            FullMouth = false;
            GetComponent<ParticleSystem>().Stop();

        }
    }

}
