using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public float Health=50;
    // Start is called before the first frame update
    public GameObject RagdollEnemy;

    // Update is called once per frame
    void Update()
    {
        Die();
    }
    public void Die()
    {
        if(Health<=0)
        {
            Instantiate(RagdollEnemy,gameObject.transform.position,gameObject.transform.rotation);
            Destroy(gameObject);
        }
    }
}
