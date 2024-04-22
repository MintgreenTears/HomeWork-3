# HomeWork-3
HomeWork-3







Part 4: Eduardo Castrezana
    Part I: Bullets
        The bullets are triggered by the F keycode. There is a public GameObject so that the bullet can be shot out of the player. Despite both Cube(1) and Real Bullet 1 have the same componets, only Cube(1) can be shot in order to trigger events such as the death animations and explosions.

    Part II: Destroying barrels.
        In order to destroy both the barrels and immediately start the particle system, I first destroy the gameObject (the barrels), and then Instantiate the particle system. Keep in mind that both of these steps are in the OnTriggerExit() method so that not only the gameObject is destroyed by the bullet, but also the particle system is triggered for some time. By the way, I use TrueExplosions by marserMD when I used the particle system. 

    Part III: Bandit's Death animation
        Similarly to Part II, there is a OnTriggerExit() method in order to trigger the death animation. 

