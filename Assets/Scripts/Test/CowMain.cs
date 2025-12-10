using System.Reflection;
using NUnit.Framework.Internal;
using UnityEngine;

public class CowMain : MonoBehaviour
{
    void Start()
    {
        // Création des personnages
        Cow MooCow = new Cow("MooCow");
        Cow ZoomZoomCow = new Cow("ZoomZoomCow");
        
        //Baston
        
        //Affiche MooCow
        MooCow.Information();   
        
        //Affiche ZoomZoomCow
        ZoomZoomCow.Information();
        

        if (ZoomZoomCow.GetHP() != 0)
        {
            while (ZoomZoomCow.GetHP() > 0 || MooCow.GetHP() > 0)
            {
                //MooCow frappe ZoomZoomCow pour X hp
                MooCow.Frappe(ZoomZoomCow);
                Debug.Log(ZoomZoomCow.GetName() + " a pris un coup et possede desormais " + ZoomZoomCow.GetHP() + " HP");
                
                //ZoomZoomCow frappe Moocow pour X hp
                ZoomZoomCow.Frappe(MooCow);
                Debug.Log(MooCow.GetName() + " a pris un coup et possede desormais " + MooCow.GetHP() + " HP");
                
            }
            if (ZoomZoomCow.GetHP() == 0)
            {
                Debug.Log(ZoomZoomCow.GetName() + " a ded" + ZoomZoomCow.GetName() + " a win");
            }
                
            if (MooCow.GetHP() != 0)
            {
                if (MooCow.GetHP() == 0)
                {
                    Debug.Log(MooCow.GetName() + " a ded" + ZoomZoomCow.GetName() + " a win");
                }
            }
        }
    }
}
