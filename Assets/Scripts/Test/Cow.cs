using UnityEngine;

public class Cow
{
    private int hp = 1;
    private int power = 1;
    private string name;


    public Cow(string name = "A cow",int power = 1, int hp = 1)
    {
        this.name = name;
        this.power = Random.Range(1,10);
        this.hp = Random.Range(1,1000);
    }
    public void Move()
    {
        Debug.Log(name + " is moving...");
    }

    public void Frappe(Cow target)
    {
        target.SetHP(-this.power);
        Debug.Log(name + " is frapping..." + target.GetName() +" et perd " + power + " HP");
    }

    public void Information()
    {
        Debug.Log(this.name + " a " + this.power.ToString() + " Force" + " et " + this.hp.ToString() + " HP");
        Debug.Log("__________________________");
    }
    
    public int GetHP()
    {
        return this.hp;
    }
    public int GetPower()
    {
        return this.power;
    }
    public string GetName()
    {
        return this.name;
    }
    
    public void SetHP(int hp)
    {
         this.hp = this.hp + hp ;
         this.hp = Mathf.Clamp(this.hp, 0, 100);
    }
    
    
}
