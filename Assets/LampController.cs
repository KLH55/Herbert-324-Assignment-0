// Kristopher Herbert; LampController is a trigger for when the player gets close to the lamps and will emit particles.
using UnityEngine;

public class LampController : MonoBehaviour
{
    // public variable for the particle system
    public ParticleSystem party;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            party.Play();
        }
    }
}
