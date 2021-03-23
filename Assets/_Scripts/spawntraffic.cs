using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawntraffic : MonoBehaviour
{
    public Transform TargetCoin1, TargetCoin2, TargetCoin3, TargetCoin4, TargetCoin5, TargetCoin6, TargetCoin7, TargetCoin8, TargetCoin9, TargetCoin10, TargetCoin11, TargetCoin12;
    public Transform targetMist, target1, target2, target3, target4, target5, target6, target7, target8, target9, target10, target11, target12, target13, target14, target15, target16, target17, target18, target19, target20, target21, target22, target23, target24;
    private int rand1, rand2, rand3, rand4, rand5, rand6, rand7, rand8, rand9, rand10, rand11, rand12, rand13, rand14, rand15, rand16, rand17, rand18, rand19, rand20;
    public GameObject object1, object2, object3, coin;

    void Start()
    {
        rand1 = Random.Range(0, 3);
       /* rand2 = Random.Range(0, 3);
        rand3 = Random.Range(0, 3);
        rand4 = Random.Range(0, 3);
        rand5 = Random.Range(0, 3);
        rand6 = Random.Range(0, 3);
        rand7 = Random.Range(0, 3);
        rand8 = Random.Range(0, 3);
        rand9 = Random.Range(0, 3);
        rand10 = Random.Range(0, 3);
        rand11 = Random.Range(0, 3);
        rand12 = Random.Range(0, 3);
        rand13 = Random.Range(0, 3);
        rand14 = Random.Range(0, 3);
        rand15 = Random.Range(0, 3);
        rand16 = Random.Range(0, 3);
        rand17 = Random.Range(0, 3);
        rand18 = Random.Range(0, 3);
        rand19 = Random.Range(0, 3);
        rand20 = Random.Range(0, 3);*/
    }


    void Line1()
    {
        if (rand1 == 0)
        {
            Instantiate(object1, target1.position, Quaternion.identity);
            Instantiate(coin, target3.position, Quaternion.identity);

        }

        if (rand1 == 1)
        {
            Instantiate(object2, targetMist.position, Quaternion.identity);

        }
        if (rand1 == 2)
        {
            Instantiate(object3, target3.position, Quaternion.identity);

        }
    }
   
}
