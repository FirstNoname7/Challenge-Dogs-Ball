using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float maxTime = 3; //максимальное время таймера
    public float timer = 3.0f; //таймер
    public bool dogSpawn = true; //проверка, можно ли в определённый момент спаунить объект (собак) или нет


    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && dogSpawn) //если игрок нажал на пробел и (&&) если dogSpawn = true, то:
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation); //запускаем собаку
            dogSpawn = false; //и ставим dogSpawn на false (чтобы в эту же секунду нельзя было выпустить новую собаку)
        }

        if (timer > 0) //если таймер больше нуля, то:
        {
            timer -= Time.deltaTime; //уменьшаем время
        }
        else //в обратном случае (то есть если таймер = 0), то:
        {
            dogSpawn = true; //возобновляем спаун собак
            timer = maxTime; //и возобновляем таймер (делаем его максимальным, ибо он равен 0)
        }
    }
}
