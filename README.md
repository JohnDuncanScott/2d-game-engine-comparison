# 2D Game Engine Comparison For Rapid Prototyping For Everyone

## Introduction
I've always wanted to build my own game but had *zero* knowledge about this area. Game engines have advanced so much that *most people* can now put something reasonably impressive together for fun (or profit) *without too much effort*. [This post](https://farawaytimes.blogspot.com/2023/02/how-to-make-good-small-games.html?m=1) inspired me to dive in.

### What does this repo offer me?
There are an overwhelming number of game engines to pick from so here is:
* A **2023** shortlist for *anyone* to try out that are all **free**
* Links to get you started
* The same playable game for each engine to make it easy to compare (created by following the links provided)
* The source code for each game

### Selection criteria
I've been a software engineer since about 2007 and although I can code in a variety of languages I wanted something that *anyone* could pick up quickly so these are the key criteria for inclusion:
* **Free** (you can build a good game without being forced to upgrade to premium versions). Open Source is a bonus
* Good documentation
* Good community
* Under active development
* Easy **visual scripting** (so you don't need to learn how to code)
* Support working in a **common and useful programming language** (so you can teach yourself coding at the same time or not feel limited by the visual scripting)
* Easy to use editor
* Supports exporting to **HTML5** (since this is an easy format to host and share, e.g. free hosting on https://itch.io/games)
 
For total beginners 2D games are much simpler to build than 3D games. If you're interested in **3D games** I would create a few 2D prototypes first and pick the game engines I've marked as supporting 3D.

My **personal website** can be found [here](http://johnduncanscott.github.io/personal-website/).

## Summary
Still comparing engines, but favourite so far is: **GDevelop**.

## Comparison

See **Notes** below to clarify some of the ratings. See the **Notable games** and **Showcase** below for what's possible.

* **Key**
  * ⭐ - excellent
  * ✅ - good
  * 🆗 - average
  * 😡- poor
  * ❌- not supported

| Area                               | GDevelop                                                                                |
| ---------------------------------- | --------------------------------------------------------------------------------------- |
| Playable game link                 | [Link](https://duncanscott.itch.io/2d-platformer-demo-gdevelop)                         |
| Game size                          | ~9 MB                                                                                   |
| Time (hours) - Basic tutorials     | 1.5                                                                                     |
| Time (hours) - Platformer tutorial | 2                                                                                       |
| Time (hours) - Platformer polish   | 4.75                                                                                    |
| Time (hours) - Total               | **8.25**                                                                                |
| Notable games                      | [Hyperspace Dogfights](https://store.steampowered.com/app/842170/Hyperspace_Dogfights/) |
| Showcase                           | [YouTube](https://www.youtube.com/watch?v=vhVT_avcFgA)                                  |
| Version used                       | 5.1.160                                                                                 |
| Updates                            | ⭐ (every month, open source)                                                            |
| Pricing / Licensing                | ⭐, [Link](https://gdevelop.io/pricing)                                                  |
| 2D                                 | ✅                                                                                       |
| 3D                                 | 😡                                                                                       |
| Platforms                          | ⭐ (HTML5, Mobile, Desktop & Facebook)                                                   |
| Documentation                      | ⭐                                                                                       |
| Community                          | ⭐                                                                                       |
| Editor                             | ✅                                                                                       |
| Editor - Autocomplete              | ✅                                                                                       |
| Editor - Size                      | ~400 MB                                                                                 |
| Editor - Preview                   | ✅ (quick to see changes)                                                                |
| Languages support                  | JavaScript                                                                              |
| Game controls                      | ⭐ (Keyboard built-in, controller via extension)                                         |
| Sprites                            | ✅ (built-in Piskel support)                                                             |
| Enemies                            | ✅ (AI via extensions)                                                                   |
| Asset store                        | ✅                                                                                       |
| Tilemaps                           | ✅                                                                                       |
| Text                               | 🆗                                                                                       |
| Hit detection                      | ✅                                                                                       |
| Animations                         | ✅ (via Piskel)                                                                          |
| Particle effects                   | ✅                                                                                       |
| Sound effects                      | ✅                                                                                       |
| Music                              | ✅                                                                                       |
| Abstraction                        | ✅ (functions and extensions)                                                            |

### Notes



#### GDevelop
Overall good fun to use and quick to get up and running. **Recommended**.

Key parts are free and there are useful free services. Editor on mobile is limited but on desktop and web it's unrestricted. Editor supports grouping, comments and colours for organisation. HTML5 builds are unlimited but you only get a few per day for other platforms, but this is probably manageable. Can download extensions in the IDE to build things faster (e.g. add controller support) and you can add your own. IDE has built-in guided lessons. Reasonable selection of free assets.

Multiplayer isn't an out of the box experience. Have access to P2P protocols but it's up to you to get multiplayer working how you want. This extension supposedly alleviates that but quality is unknown - https://gdevelop.io/blog/make-multiplayer-games-easily. Specialises in 2D games; 3D games can be made through extensions but are in an early state. Although 2D is a speciality it lacks advanced features like skeletal animations. Tilemaps could be a bit more clever. Some of the older tutorials haven't been updated for the new IDE and have a few minor errors. IDE provides reasonable autocomplete but improvements can be made here. No support for organising things in folders so careful naming of game objects is essential. Could do with more free assets, especially sounds & music.

## Engine Guides

### General
* [YouTube - I Made the Same Game in 8 Engines](https://www.youtube.com/watch?v=MASAqbRMnaM)
* [YouTube - Choosing a game engine in 2021](https://www.youtube.com/watch?v=rK6ulQaOpso)
* [YouTube - 6 ways to make your game better](https://www.youtube.com/watch?v=27e3m906x7I) – for **GDevelop** but good in general
  * Add object shake on interaction
  * Tweens - animations play external sprites sequentially, tweens smoothly animate properties of an object in the gameworld, such as width or opacity (e.g. make button grow on hover)
  * Sound effects – randomise pitch so many sound effects at once (like a bullet shot) sound unique, or change pitch in some way that sounds nice (like increasing pitch for coin pickup)
  * Particle effects – use for any kind of collisions
  * Leaderboards – for games where it makes sense, easy way of adding social aspect to a single player game 
* https://www.gamesindustry.biz/rami-ismails-top-ten-tips-on-surviving-the-indiepocalypse
* Running an HTML5 game locally:
  * Export game as HTML5
  * Go to directory where game was exported
  * Run `python -m http.server 8000` then go to http://localhost:8000 in your browser

### GDevelop

[Playable game for the source code in this repository](https://duncanscott.itch.io/2d-platformer-demo-gdevelop)

#### Getting started

##### Official
* https://gdevelop.io/academy  
  * [YouTube - Beginner's Guide To GDevelop](https://www.youtube.com/watch?v=595-swNh0Mw&list=PL3YlZTdKiS89Kj7IQVPoNElJCWrjZaCC8)
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
* Platformer demo
  * https://wiki.gdevelop.io/gdevelop5/tutorials/platformer/ (example 1, older IDE version and a few minor errors but still mostly fine to follow)
    * Part 6 has quite a few errors mainly due to the Slime image being reversed compared to the instructions, so the initial direction and horizontal flipping needs changing
  * [YouTube - Platform(er) - In Depth Tutorial - GDevelop](https://www.youtube.com/watch?v=V0d93elLHkQ) (example 2)
* Creating a start and end to your game - https://wiki.gdevelop.io/gdevelop5/tutorials/space-shooter/13-main-menu/#series
  * https://forum.gdevelop.io/t/solved-when-i-press-a-button-to-change-the-scene-for-example-the-next-button-is-pressed-also/30752/7
* [YouTube - Particle Emitter – In Depth Tutorial - GDevelop](https://www.youtube.com/watch?v=mqXYlsOENpg)
* [JavaScript Code events](https://wiki.gdevelop.io/gdevelop5/events/js-code/)
  * https://forum.gdevelop.io/t/typescript-integration-in-gdjs/25022

#### Notes
* Event list is run from top to bottom every frame
* You can disable the in-game watermark in **Game properties** without needing a subscription

#### Tips
##### Performance
* Events will stop being read if the condition above is false. This means you can optimise by putting a common conditional at the top (e.g. if player is dead, then do a bunch of stuff) - doesn't automatically combine common conditionals
* Collision detection is intense so if you can use something else (like distance from object for a coin where perfect collision detection is less important), then do that instead
* If you need to display many objects, you can improve FPS by reducing animation loops or removing actions like movement
* Delete / de-activate behaviours for things that are off the screen ("Object 'Is On Screen' Detection" extension super useful)
* Be reasonable with your asset sizes
* Use tile maps for large scenes
* Keep size small
  * Can remove unused resources easily by using **Remove unused...** in the right-click menu in the **Resources** tab

### Rejected
TBD