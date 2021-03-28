using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInvaders : MonoBehaviour
{

    [SerializeField]
    GameObject invasorA;

    [SerializeField]
    GameObject invasorB;

    [SerializeField]
    GameObject invasorC;

    [SerializeField]
    int nInvasores = 7;

    [SerializeField]
    float xMin = -3f;

    void Awake()
    {
        /*
         * "Pega" neste objecto, duplica e coloca-o "naquele" sítio
         */

        float firstLineInvadersXPosition = xMin;
        for( int i = 1; i <= nInvasores; i++ )
        {
            GameObject newInvader = Instantiate(invasorA, transform);
            newInvader.transform.position = new Vector3(firstLineInvadersXPosition, -0.5f, 0f);

            GameObject newInvader2 = Instantiate(invasorA, transform);
            newInvader2.transform.position = new Vector3(firstLineInvadersXPosition, 0.0f, 0f);

            firstLineInvadersXPosition += 1f;
        }

        float secondLineInvaderXPosition = xMin;
        for (int i = 1; i <= nInvasores; i++)
        {
            GameObject newInvader = Instantiate(invasorB, transform);
            newInvader.transform.position = new Vector3(secondLineInvaderXPosition, 0.5f, 0f);
            
            GameObject newInvader2 = Instantiate(invasorB, transform);
            newInvader2.transform.position = new Vector3(secondLineInvaderXPosition, 1.0f, 0f);


            secondLineInvaderXPosition += 1f;
        }

        float thirdLineInvaderXPosition = xMin;
        for (int i = 1; i <= nInvasores; i++)
        {
            GameObject newInvader = Instantiate(invasorC, transform);
            newInvader.transform.position = new Vector3(thirdLineInvaderXPosition, 1.5f, 0f);
            thirdLineInvaderXPosition += 1f;
        }
    }
}
