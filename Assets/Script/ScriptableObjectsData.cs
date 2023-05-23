using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Data", order = 1)]
public class DataHandler : ScriptableObject
{
    public GameObject Prefab;
    public string Name;
    public int lvl;
}
