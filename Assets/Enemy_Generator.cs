using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Generator : MonoBehaviour
{
    public GameObject Enemy;
    public int xPos;
    public int zPos;
    public int enemyCount;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    IEnumerator EnemyDrop()
    {
        while(enemyCount<10)
        {
            xPos=Random.Range(1,20);
            zPos=Random.Range(2,30);
            Instantiate(Enemy,new Vector3(xPos,3.89f,zPos),Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            enemyCount+=1;

        }
    }
}
