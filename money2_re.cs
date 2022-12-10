var curHealth : int = 100;

var maxHealth : int = 100;

function Update()
{
    if (curHealth > maxHealth)
    {
        curHealth = maxHealth;
    }

    if (curHealth < 0)
    {
        curHealth = 0;

        moneySystem.money += 100;//name of your script moneySystem
    }

}