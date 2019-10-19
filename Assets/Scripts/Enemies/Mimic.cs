Using Unity Engine;
Using System.Collections;

public class Mimic : Monobehaviour { //50% chance treasure chest is a Mimic and will attack you
    public gameObject chest;
    public gameObject player;

    public gameObject speedBoost = getComponent<PowerUps>(speedBuff);
    public gameObject damageBoost = getComponent<PowerUps>(damageBuff); 
    public gameObject shieldBoost = getComponent<PowerUps>(shieldBuff);

    public gameObject[] gold = new gameObject[math.random(5, 25)];
    var goldDrop = gold[0];

    public gameObject[] powerUpList = new gameObject[speedBoost, damageBoost, shieldBoost];
    public gameObject[] loot = new gameObject[powerUpList, gold];

    function isMimic(){
        if(/*player collision with chest*/) {
            var mimicTest = math.random(1,3);
            if(mimicTest == 1){
                bite();
            }
            else(){
                Instantiate(loot[math.random(1,3)]);
            }
        }

        function bite(){
            //bite down animation,=
            //deal damage to player
            //drop no loot
        }
    }
}