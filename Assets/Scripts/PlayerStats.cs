using UnityEngine;
using System.Collections.Generic;

public class PlayerStats : MonoBehaviour
{
    public  List<S_CowBase> myCows = new();


    private void Start()
    {
        print(myCows);
    }
}
