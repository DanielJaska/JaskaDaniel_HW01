using UnityEngine;
using System.Collections;

public abstract class PowerUpBase : MonoBehaviour
{
    [SerializeField] protected float powerUpDuration = 1f;

    private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        if(player != null)
        {
            PowerUp(player);
            GetComponent<Collider>().enabled = false;
            GetComponent<MeshRenderer>().enabled = false;
            StartCoroutine(Timer(powerUpDuration));
        }
        
        
    }

    IEnumerator Timer(float time)
    {
        yield return new WaitForSeconds(time);
        PowerDown();
        gameObject.SetActive(false);
    }

    protected abstract void PowerUp(Player player);

    protected abstract void PowerDown();
}
