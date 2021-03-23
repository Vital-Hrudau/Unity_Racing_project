using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnTech : MonoBehaviour {

    public Transform Point;
    public Transform TargetCoin1, TargetCoin2, TargetCoin3, TargetCoin4, TargetCoin5, TargetCoin6, TargetCoin7, TargetCoin8, TargetCoin9, TargetCoin10, TargetCoin11, TargetCoin12;
    public Transform targetMist, target1, target2, target3, target4, target5, target6, target7, target8, target9, target10, target11, target12, target13, target14, target15, target16, target17, target18, target19, target20, target21, target22, target23, target24;
    public GameObject Prefab1, Prefab2;
    public GameObject object1, object2, object3, coin; 
    private int rand1, rand2, rand3, rand4, rand5, rand6, rand7, rand8, rand9,rand10,rand11, rand12, rand13, rand14, rand15, rand16, rand17, rand18, rand19, rand20, RandomPrefab;
    private int tr;

    private void Start()
    {
        //public static float Range(float min, float max);
        //target3.transform.position = new Vector3(float x, 4f, z:);
        RandomPrefab = Random.Range(0, 2);
        rand1 = Random.Range(0,3);
        rand2 = Random.Range(0, 3);
        rand3 = Random.Range(0, 3);
        rand4 = Random.Range(0, 3);
        rand5 = Random.Range(0, 3);
        rand6 = Random.Range(0, 3);
        rand7 = Random.Range(0, 3);
        rand8 = Random.Range(0, 3);
        //coin random:
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
        rand20 = Random.Range(0, 3);
        //rand12 = Random.Range(0, 3);
        Line1();
        Line2();
        Line3();
        Line4();
        Line5();
        Line6();
        Line7();
        Line8();
        CoinLine1();
        CoinLine2();
        CoinLine3();
        CoinLine4();
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
    void Line2()
    {
        if (rand2 == 0)
        {
            Instantiate(object1, target4.position, Quaternion.identity);
        }
        if (rand2 == 1)
        {
            Instantiate(object2, target5.position, Quaternion.identity);
        }
        if (rand2 == 2)
        {
            Instantiate(object3, target6.position, Quaternion.identity);
        }
    }
    void Line3()
    {
        if (rand3 == 0)
        {
            Instantiate(object1, target7.position, Quaternion.identity);
            Instantiate(coin, target8.position, Quaternion.identity);
        }
        if (rand3 == 1)
        {
            Instantiate(object2, target8.position, Quaternion.identity);
        }
        if (rand3 == 2)
        {
            Instantiate(object3, target9.position, Quaternion.identity);
        }
    }
    void Line4()
    {
        if (rand4 == 0)
        {
            Instantiate(object1, target10.position, Quaternion.identity);
        }
        if (rand4 == 1)
        {
            Instantiate(object2, target11.position, Quaternion.identity);
        }
        if (rand4 == 2)
        {
            Instantiate(object3, target12.position, Quaternion.identity);
        }
    }
    void Line5()
    {
        if (rand5 == 0)
        {
            Instantiate(object1, target13.position, Quaternion.identity);
        }
        if (rand5 == 1)
        {
            Instantiate(object2, target14.position, Quaternion.identity);
        }
        if (rand5 == 2)
        {
            Instantiate(object3, target15.position, Quaternion.identity);
        }
    }
    void Line6()
    {
        if (rand6 == 0)
        {
            Instantiate(object1, target16.position, Quaternion.identity);
        }
        if (rand6 == 1)
        {
            Instantiate(object2, target17.position, Quaternion.identity);
        }
        if (rand6 == 2)
        {
            Instantiate(object3, target18.position, Quaternion.identity);
            Instantiate(coin, target16.position, Quaternion.identity);
        }
    }
    void Line7()
    {
        if (rand7 == 0)
        {
            Instantiate(object1, target19.position, Quaternion.identity);
        }
        if (rand7 == 1)
        {
            Instantiate(object2, target20.position, Quaternion.identity);
        }
        if (rand7 == 2)
        {
            Instantiate(object3, target21.position, Quaternion.identity);
        }
    }
    void Line8()
    {
        if (rand8 == 0)
        {
            Instantiate(object1, target22.position, Quaternion.identity);
            Instantiate(coin, target23.position, Quaternion.identity);
        }
        if (rand8 == 1)
        {
            Instantiate(object2, target23.position, Quaternion.identity);
        }
        if (rand8 == 2)
        {
            Instantiate(object3, target24.position, Quaternion.identity);
        }
    }
    void CoinLine1()
    {
        if (rand9 == 0)
        { 
            Instantiate(coin, TargetCoin1.position, Quaternion.identity);
        }
        if (rand10 == 1)
        {
            Instantiate(coin, TargetCoin2.position, Quaternion.identity);
        }
        if (rand11 == 2)
        {
            Instantiate(coin, TargetCoin3.position, Quaternion.identity);
        }
    }
    void CoinLine2()
    {
        if (rand12 == 0)
        {
            Instantiate(coin, TargetCoin4.position, Quaternion.identity);
        }
        if (rand13 == 1)
        {
            Instantiate(coin, TargetCoin5.position, Quaternion.identity);
        }
        if (rand14 == 2)
        {
            Instantiate(coin, TargetCoin6.position, Quaternion.identity);
        }
    }
    void CoinLine3()
    {
        if (rand15 == 0)
        {
            Instantiate(coin, TargetCoin7.position, Quaternion.identity);
        }
        if (rand16 == 1)
        {
            Instantiate(coin, TargetCoin8.position, Quaternion.identity);
        }
        if (rand17 == 2)
        {
            Instantiate(coin, TargetCoin9.position, Quaternion.identity);
        }
    }
    void CoinLine4()
    {
        if (rand18 == 0)
        {
            Instantiate(coin, TargetCoin10.position, Quaternion.identity);
        }
        if (rand19 == 1)
        {
            Instantiate(coin, TargetCoin11.position, Quaternion.identity);
        }
        if (rand20 == 2)
        {
            Instantiate(coin, TargetCoin12.position, Quaternion.identity);
        }
    }







    void Update () {
		
	}
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Playjer" )
        {
            if (RandomPrefab == 0)
            {
                Instantiate(Prefab1, Point.position, Quaternion.identity);
                //RandomPrefab = Random.Range(0, 2);
            }
          
            
        }
        if(col.tag == "Playjer" )
        {
            if (RandomPrefab == 1)
            {
                Instantiate(Prefab2, Point.position, Quaternion.identity);
                //RandomPrefab = Random.Range(0, 2);
            }
            

        }
        if (col.tag == "Player")
        {
            Instantiate(Prefab1, Point.position, Quaternion.identity);
        }
        if (col.tag == "enemy")
        {
            print("TRIGGER");
        }
    }
   
}
