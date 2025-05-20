# General Engine Guide

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
  * **Note:** **Unity** is able to do this out of the box
  * Export game as HTML5
  * Go to directory where game was exported
  * Run `python -m http.server 8000` then go to http://localhost:8000 in your browser
* **Areas**
  * **General**
    * https://github.com/Kavex/GameDev-Resources - lots of links to resources, might come in handy
  * **Art**
    * https://www.piskelapp.com/ - free online editor for animated sprites and pixel art (built into some game engines like **GDevelop**)
    * [YouTube - The Ultimate Pixel Art Tutorial](https://www.youtube.com/watch?v=lfR7Qj04-UA)
  * **Marketplaces**
    * https://itch.io/ - host indie games. Totally free. Lets users download the files exactly as you uploaded them so you can upload any kind of project for any kind of platform. Adult content is allowed. If your game is HTML5, users can run game directly in the browser
  * **Music**
    * **Content**
      * https://www.chosic.com/free-music/all/
      * ? https://pixabay.com/music/search/genre/video%20games/
      * ? https://tunetank.com/#pricing
    * **Tools**
      * https://github.com/steffest/BassoonTracker - browser-based old-school Amiga music tracker
  * **Physics**
    * [GDCVault - Designing with Physics: Bend the Physics Engine to Your Will](https://gdcvault.com/play/1021921/Designing-with-Physics-Bend-the)
     * Check your:
       * **G**ravity
       * **U**nits
       * **T**imestep
     * Change your:
       * **M**ass values
       * **I**terations
       * **N**on-resolvable scenarios
       * **D**rag forces
  * **Platforms**
    * https://ruoyusun.com/2023/10/12/one-game-six-platforms.html
  * **Sound**
    * https://frozenfractal.com/projects/jfxr