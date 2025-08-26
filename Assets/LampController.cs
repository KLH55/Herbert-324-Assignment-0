using UnityEngine;

public class LampController : MonoBehaviour
{
    public ParticleSystem party;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            party.Play();
        }
    }
}
