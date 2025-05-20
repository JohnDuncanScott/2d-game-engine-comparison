# GDevelop Engine Guide
[Playable game for the source code in this repository](https://duncanscott.itch.io/2d-platformer-demo-gdevelop)

## Getting started
1. **Basics**
   * https://gdevelop.io/academy
     * [YouTube - Beginner's Guide To GDevelop](https://www.youtube.com/watch?v=595-swNh0Mw&list=PL3YlZTdKiS89Kj7IQVPoNElJCWrjZaCC8) - good overview before creating the game
2. **Create a very bare game skeleton**
   * https://wiki.gdevelop.io/gdevelop5/tutorials/platformer/ (example 1, older IDE version and a few minor errors but still mostly fine to follow)
        * Part 6 has quite a few errors mainly due to the Slime image being reversed compared to the instructions, so the initial direction and horizontal flipping needs changing
   * [YouTube - Platform(er) - In Depth Tutorial - GDevelop](https://www.youtube.com/watch?v=V0d93elLHkQ) (example 2, not used but more modern one you could follow)
3. **Turn the skeleton into a playable game**
   * Creating a start and end to your game - https://wiki.gdevelop.io/gdevelop5/tutorials/space-shooter/13-main-menu/#series
    * https://forum.gdevelop.io/t/solved-when-i-press-a-button-to-change-the-scene-for-example-the-next-button-is-pressed-also/30752/7
4. **Add polish to playable game**
   * [YouTube - Particle Emitter – In Depth Tutorial - GDevelop](https://www.youtube.com/watch?v=mqXYlsOENpg)
   * [YouTube - The 10 BEST Game Development Extensions](https://www.youtube.com/watch?v=dqGoJKn3XOQ)
     * "Advanced platformer movements"
     * "Camera Shake"
     * "Gamepads (controllers)"
     * "Multitouch joystick and buttons"
     * "Hexagonal grid" / "Snap objects to a virtual grid"
     * "Shake Object (position, angle, scale)" (can use for any kind of general movement, including button scaling, etc.) - useful but particles are usually easier for simple death / pickup / hit animations since they don't mess with the original object
     * "Rectangular Movement"
     * "Health (life points)"
     * "Smooth Camera" (can be used to stabilise camera when jumping)
     * "Fire bullets"
5. **Optional**
   * [Expressions reference](https://wiki.gdevelop.io/gdevelop5/all-features/expressions-reference/)
   * [JavaScript Code events](https://wiki.gdevelop.io/gdevelop5/events/js-code/) - used to keep track of total coins
     * https://forum.gdevelop.io/t/typescript-integration-in-gdjs/25022
   * Organising game logic
     * Variable types
       * Global
       * Scene
       * Object
       * Instance
     * Event groups - useful to put together a set of events related to the same concept
     * External events - can be re-used throughout game via links
     * Custom extensions (objects, behaviours, conditions, actions or expressions)

## Notes
* Event list is run from top to bottom every frame
* You can disable the in-game watermark in **Game properties** without needing a subscription

## Tips
### Performance
* Events will stop being read if the condition above is false. This means you can optimise by putting a common conditional at the top (e.g. if player is dead, then do a bunch of stuff) - doesn't automatically combine common conditionals
* Collision detection is intense so if you can use something else (like distance from object for a coin where perfect collision detection is less important), then do that instead
* If you need to display many objects, you can improve FPS by reducing animation loops or removing actions like movement
* Delete / de-activate behaviours for things that are off the screen ("Object 'Is On Screen' Detection" extension super useful)
* Be reasonable with your asset sizes
* Use tile maps for large scenes
* Keep size small
  * Can remove unused resources easily by using **Remove unused...** in the right-click menu in the **Resources** tab