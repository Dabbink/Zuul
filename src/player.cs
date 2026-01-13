class Player
{
    //fields
    private int health;
    // auto property
    public Room CurrentRoom { get; set; }
    // constructor
    public Player()
    {
        health = 100;
        CurrentRoom = null;
    }
    // methods
    public void Damage(int amount) { health -= amount; } // speler verliest health
    public void Heal(int amount) {
         health =  Math.Min(health + amount,100);
    } // speler krijgt health
    public bool IsAlive() { return health > 0; } // checkt of speler nog leeft

    public int GetHealth() { return health; } // geeft huidige health terug
}