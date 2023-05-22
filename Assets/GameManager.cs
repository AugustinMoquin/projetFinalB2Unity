using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public GameObject PrefabMonster;
    public List<GameObject> AliveMonsters;
    public int NbWave;
    public GameObject Player;
    public DataHandler Data;

    public UnityEvent NextLevel;

    private float timer = 1;

    public static GameManager Instance;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void NextWave()
    {


        //Création de monstres
        //augmentation de la difficulté
        //Gain de récompenses
        //Affichage de l'Ui de victoire
        //Un son de victoire
        //.....
    }
}
