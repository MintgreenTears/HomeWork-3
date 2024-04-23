# HomeWork-3
HomeWork-3

Group work
Task 1: Wenkang Lyu
Task 2: Yida Fang
Task 3: Eduardo Castrezana
Task 4: Wenkang Lyu
Task 5: Quinn
Task 6: Wenkang Lyu
Task 7: Wenkang Lyu

Task1: This is done by creating three virtual cameras, two Dolly tracks and two Dolly Carts, setting up the track, 
setting the Dolly cart path so that the virtual camera can follow the dolly and look at the dolly. 
Use Timeline to manage the control logic between individual virtual cameras.

Task2: Add three kick animations to the animation controller and set three Trigger values. 
Each time you click the space button, a random number between 0 and 2 is obtained. 
According to the random number, you can determine which kick animation to play. 
Apply kick forces through X-ray inspection to add colliders and rigid bodies to tumbleweeds, baskets, crates, and buckets.

Task 3: 
​    Part I: Bullets
​        The bullets are triggered by the F keycode. There is a public GameObject so that the bullet can be shot out of the player. Despite both Cube(1) and Real             Bullet 1 have the same componets, only Cube(1) can be shot in order to trigger events such as the death animations and explosions.

    Part II: Destroying barrels.
        In order to destroy both the barrels and immediately start the particle system, I first destroy the gameObject (the barrels), and then Instantiate the              particle system. Keep in mind that both of these steps are in the OnTriggerExit() method so that not only the gameObject is destroyed by the bullet, but            also the particle system is triggered for some time. By the way, I use TrueExplosions by marserMD when I used the particle system. 
    
    Part III: Bandit's Death animation
        Similarly to Part II, there is a OnTriggerExit() method in order to trigger the death animation.

Task4: Add three Audio sources to trigger different music based on the scene when the player moves to a certain location, 
add animated events to complete footsteps, and add empty objects in the scene to complete wind. 
Add a taunt script for each robber in the scene and control the randomness of the taunt through the 
WaitForSeconds and Random.Range methods in the coroutine.

Task 5:

Task6: Add BanditShoot script to realize the effect of robber shooting players, 
periodically execute shooting events through InvokeRepeating, 
Instantiate bullet preform through instantiate, trigger shooting sound when firing, 
and according to the direction of the player, To give the bullet a velocity in the initial direction. 
The bullet prefab has a script attached to it that plays a hit sound when the object as a trigger 
collides with the object tagged Player.

Task7: Make rain and ripple material ball, make raindrop and ripple texture through the particle system, 
when the rain falls on the ground, it will collide with the ground and play the ripple effect. 
By setting the number and range of particle effects, it is more consistent with real world rain.





Part 4: Eduardo Castrezana
​    Part I: Bullets
​        The bullets are triggered by the F keycode. There is a public GameObject so that the bullet can be shot out of the player. Despite both Cube(1) and Real Bullet 1 have the same componets, only Cube(1) can be shot in order to trigger events such as the death animations and explosions.

    Part II: Destroying barrels.
        In order to destroy both the barrels and immediately start the particle system, I first destroy the gameObject (the barrels), and then Instantiate the particle system. Keep in mind that both of these steps are in the OnTriggerExit() method so that not only the gameObject is destroyed by the bullet, but also the particle system is triggered for some time. By the way, I use TrueExplosions by marserMD when I used the particle system. 
    
    Part III: Bandit's Death animation
        Similarly to Part II, there is a OnTriggerExit() method in order to trigger the death animation. 

