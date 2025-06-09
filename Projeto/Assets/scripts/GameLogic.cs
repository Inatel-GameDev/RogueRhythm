using System.Collections;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    bool[,] Songs = { { true, false, true, true }, { false, true, true, false }, { true, true, true, false }, { true, false, false, false } };

    int size;

    [SerializeField]
    Transform[] Spawners;
    [SerializeField]
    GameObject Note;

    float timeBetweenBeats = 1.0f;

    void Start()
    {
        StartCoroutine(PlayMusic()); 
    }

/*
void Update()
{

}
*/

IEnumerator PlayMusic()
    {
        size = Songs.GetLength(0);
        while (true)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (Songs[i, j] == true)
                    {
                        Instantiate(Note, Spawners[j].transform);
                    }
                }
                yield return new WaitForSeconds(timeBetweenBeats);
            }
        }

    }

}
