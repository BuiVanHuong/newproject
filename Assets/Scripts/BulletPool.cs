using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPool : MonoBehaviour
{

    public static BulletPool bulletPoolInstanse;
    [SerializeField]
    private GameObject pooledBullet;
    private bool notEnoughBulletsInPool = true;
    private List<GameObject> bullets;
    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    private void Awake()
    {
        bulletPoolInstanse = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        bullets = new List<GameObject>();
    }
    public GameObject GetBullet()
    {
        if(bullets.Count > 0)
        {
            for (int i = 0; i< bullets.Count; i++)
            {
                if(!bullets[i].activeInHierarchy)
                {
                    return bullets[i];
                }
            }
        }
            if (notEnoughBulletsInPool)
        {
            GameObject bul = Instantiate(pooledBullet);
            bul.SetActive(false);
            bullets.Add(bul);
            return bul;
        }
        return null;
    }
    //  private void OnTriggerEnter(Collider other)
    // {
    //    Destroy(gameObject);
    //     Destroy(other.gameObject);
     
    // }
    
}
