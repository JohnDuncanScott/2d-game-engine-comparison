# Unity
[Playable game for the source code in this repository](https://duncanscott.itch.io/2d-platformer-demo-unity)

## Getting started
1. **Create minimal playable game**
   * After spending about a day (not included in the **Platformer tutorial** timings in table since this approach was abandoned) wrestling with the official **2D Game Kit** project and encountering various bugs while customising it (e.g. adding ability to jump on enemy heads), decided to give up on this after hitting even deeper bugs like the VFX not playing unless the scene was reloaded and the VFX appearing in the middle of the scene, amongst other things. Rather than learning about Unity, I was learning more about how the kit was built, so I decided to go back to basics and follow [YouTube - Build a 2D Platformer Game in Unity | Unity Beginner Tutorial](https://www.youtube.com/watch?v=Ii-scMenaOQ&list=PLrnPJCHvNZuCVTz6lvhR81nnaf1a-b67U) to create something small as a base. All videos were followed but some are highlighted below where multiple useful topics were covered
   * If you get stuck at any point, the section after this one goes into various different areas, so feel free to skip backwards and forwards between them
   * [YouTube - Tilemap & Tile Palette | Build a 2D Platformer Game in Unity #2](https://www.youtube.com/watch?v=QkbGr1rAya8&list=PLrnPJCHvNZuCVTz6lvhR81nnaf1a-b67U&index=2)
     * Also covers basic **Physics**, **IDE setup** and **Player input**
     * Timeline:
       * Import tilemap - 5:07
       * Tilemap layers - 13:42
       * Import player - 16:31
       * Physics - 20:47
       * Custom component (Player movement) - 26:10
       * IDE setup (auto-completion) - 27:10
       * Player input - 31:52
       * Optimal physics settings - 38:15
   * [YouTube - Animation & Animator | Build a 2D Platformer Game in Unity #4](https://www.youtube.com/watch?v=GChUpPnOSkg&list=PLrnPJCHvNZuCVTz6lvhR81nnaf1a-b67U&index=4)
     * Timeline:
       * Adding a 2nd animation and creating transitions for it with good default settings - 4:45
       * Exposing script variables to inspector - 19:54
   * [YouTube - Multiple Animations | Build a 2D Platformer Game in Unity #5](https://www.youtube.com/watch?v=65E-q0JxYwU&list=PLrnPJCHvNZuCVTz6lvhR81nnaf1a-b67U&index=6)
     * Timeline:
       * Handling many interlinking animations - 4:09
       * Handling vertical direction - 15:05
   * [YouTube - Grounding Check Using Boxcast | Build a 2D Platformer Game in Unity #6](https://www.youtube.com/watch?v=LEUhxe9vUOM&list=PLrnPJCHvNZuCVTz6lvhR81nnaf1a-b67U&index=8)
     * Timeline:
       * Adding layers to help with collisions so can check if grounded - 4:58
       * Ignore side collisions by using `Platform Effector 2D` component - 9:07
   * [YouTube - Collect & Count Items | Build a 2D Platformer Game in Unity #7](https://www.youtube.com/watch?v=pXn9icmreXE&list=PLrnPJCHvNZuCVTz6lvhR81nnaf1a-b67U&index=7)
     * Timeline:
       * Using trigger colliders - 3:50
       * Using tags - 5:34
       * Creating and using prefabs - 12:44
       * Using parent game objects to keep things tidy - 14:51
       * Adding a UI component to show collected items count - 16:06
       * Using custom fonts - 17:54
   * [YouTube - Player Death Logic | Build a 2D Platformer Game in Unity #8](https://www.youtube.com/watch?v=ynH51MiKutY&list=PLrnPJCHvNZuCVTz6lvhR81nnaf1a-b67U&index=8)
     * Timeline:
       * Adding death state - 4:20
       * Adding empty frame for death animation - 14:08
       * Calling restart level from the death animation - 15:10
   * [YouTube - Moving Platforms | Build a 2D Platformer Game in Unity #9](https://www.youtube.com/watch?v=UlEE6wjWuCY&list=PLrnPJCHvNZuCVTz6lvhR81nnaf1a-b67U&index=9)
     * Timeline:
       * Adding waypoints - 6:15
       * Make player move with platform - 21:02
   * [YouTube - Sound Effects & Background Music | Build a 2D Platformer Game in Unity #11](https://www.youtube.com/watch?v=J77CMuAwVDY&list=PLrnPJCHvNZuCVTz6lvhR81nnaf1a-b67U&index=11)
     * Timeline:
       * How to setup sound effects - 2:02
       * Adding background music - 8:49
   * [YouTube - Adding Multiple Levels | Build a 2D Platformer Game in Unity #12](https://www.youtube.com/watch?v=dO5BzWYqEdY&list=PLrnPJCHvNZuCVTz6lvhR81nnaf1a-b67U&index=14)
     * Timeline:
       * Adding scenes to build settings - 12:17
   * [YouTube - Start & Game Over Menu | Build a 2D Platformer Game in Unity #13](https://www.youtube.com/watch?v=OLbWB1R095s&list=PLrnPJCHvNZuCVTz6lvhR81nnaf1a-b67U&index=13)
     * Timeline:
       * Designing a UI - 0:52
       * Adding button click events - 4:45
2. **Basics**
   * Following the first step above should have given you a broad understanding. This section goes into more of the basics
   * **Official whole game tutorials** - mixed quality, Unity devs aren't great at updating older demos so there are often setup glitches or just plain bugs
     * **Warning:** If you want to build a platformer then **none** of the official whole game Unity tutorials are particularly great. The **Platformer Microgame** doesn't feel great and there are odd bugs. The **2D Game Kit** project is better but there are bugs and it's quite a complicated project (and the docs to help customise more deeply are poor) so fixing those bugs when adding new features is not trivial (wasted about a day on this). The **Unity Playground** is simpler and more generic, so may be a good starting point for other projects but would need a fair bit of work to get a good feeling platformer. The **unofficial** tutorials are much better, so skip to those if you want to save time, although it's worth going through the official Unity learning "pathways" at some point
     * https://unity.com/how-to/beginner-2D-game-resources
       * [Platformer Microgame](https://learn.unity.com/project/2d-platformer-template) - game & tutorial in one but not much depth and doesn't really tell you why things should be done. Overall the feel of the platforming isn't great and there are odd issues like this one: https://www.reddit.com/r/Unity3D/comments/nc5zvx/issues_with_the_2d_platform_effector_with_unity/. It's good as an initial introduction to Unity so you can get used to the interface. The steps are quite easy to follow but you do end up with a game that relies on simple C# scripts. See later for an introduction to visual scripting
         * Initial setup fixes:
           * Due to [this bug](https://forum.unity.com/threads/why-unityhub-not-showing-other-template-files.1084937/), had to install **2021.3.27f1** to get the microgame working
           * [Install 2D packages](https://forum.unity.com/threads/2d-game-object-missing.1090024/) - some of the mods need these but don't tell you to install them
         * Mods tried:
           * 2D Platformer Mod: A Splash of Color
           * 2D Platformer Mod: Add Trails
           * Platformer Mod: Custom Triggers (remember to install 2D packages above, also easy to pick from Assets instead of Hierarchy when creating triggers, which will **not** work, so be careful)
           * 2D Platformer Mod: Paint Your Level (barely covers TileMap use, ok but not great)
           * 2D Platformer Mod: Bouncy Sparkly!
       * [2D Game Kit](https://learn.unity.com/project/2d-game-kit) - some bugs but overall a nicer experience than the microgame and the platforming feels better. Has a lot more configurability than the microgame too, so could build on this if you wanted to. Controls are a little unusual so make sure to read the instructions. Still lots of C# scripts, but a lot is exposed in the UI and the [reference page](https://learn.unity.com/tutorial/2d-game-kit-reference-guide) is pretty thorough
         * Initial setup fixes:
           * Create a blank 2D project
           * Go to https://assetstore.unity.com/packages/templates/tutorials/2d-game-kit-107098 -> Add to assets -> Open in Unity -> Download -> Import (a few clicks to get this done)
           * After Import, will see a bunch of errors about `RuleTileEditor.cs`
             1. Find and open `Assets/2DGamekit/Utilities/Editor/RuleTileEditor.cs`
             2. Replace all `RuleTile` with `RuleTile2D` in it (whole word match)
             3. Rename `RuleTile.cs` in `Assets/2DGamekit/Scripts/Utility/` to `RuleTile2D.cs` and change the `class` inside from `RuleTile` to `RuleTile2D`
             4. Restart Unity. Unity will likely complain that you have the wrong version of Unity, but you can use `2021.3.27f1` without any problems
             5. You can now proceed with the `Creating a New Scene` step in the tutorial
         * Bugs:
           * Edge of platform animation jumpiness
           * Dust particle for landing doesn't follow player and is just in middle of scene
           * VFXController is bugged so none of the effects work (possibly due to Unity version I used)
           * This may also help if you run into other issues: https://forum.unity.com/threads/2d-game-kit-official-thread.517249/page-11. However, it's clear this project isn't really supported anymore and there were bugs I found not covered in the thread
         * Notes:
           * Pre-built Zones can be found under `Assets\2DGamekit\Scenes` (need to click on folder in Project and add to Hiearchy)
           * Can change **ChestLight** light type to **Global** to light whole level
           * Disable **CMPlayerCam** to turn off player follow
           * **State Machine Behaviours (SMBs)** can be found in the Animator Controller when clicking on a state in the graph (e.g. **Chomper Patrol SMB** is attached to the **ChomperWalk** state). Visual effects (VFX) can also be found here (**Trigger VFX** component) (e.g. **ChomperDie** is attached to the **ChomperDeath** animation)
           * A PDF comes with the project which duplicates the website but also has a more detailed section that goes into how some of the deeper components work. However, it's still not very useful if you want to fully customise the project
     * [Unity Playground](https://learn.unity.com/project/unity-playground) - overall pleasant to use, comes with cheat sheets (`Assets\UnityTechnologies\Playground\Documentation`) and examples (`\Assets\UnityTechnologies\Playground\Examples`). Use the **Playground** menu to turn on / off the custom inspectors that simplify the Unity UI. [Reference guide](https://learn.unity.com/tutorial/playground-reference-guide)
       * Initial setup fixes:
         * Use the 2D Core template, not 3D
   * **Unofficial whole game tutorials** - these are much better than the official Unity ones
     * [YouTube - Build a 2D Platformer Game in Unity | Unity Beginner Tutorial](https://www.youtube.com/watch?v=Ii-scMenaOQ&list=PLrnPJCHvNZuCVTz6lvhR81nnaf1a-b67U) - this is the one used in the previous section
     * [YouTube - How to make a 2D Game](https://www.youtube.com/watch?v=on9nwbZngyw&list=PLPV2KyIb3jR6TFcFuzI2bB7TMNIIBpKMQ) - recommended by Unity docs. The one I ended up using was better, but there are a few worth dipping into:
       * [YouTube - How to make a 2D Game in Unity](https://www.youtube.com/watch?v=on9nwbZngyw) - nice quick intro to the basics
       * [YouTube - 2D Camera in Unity (Cinemachine Tutorial)](https://www.youtube.com/watch?v=2jTY11Am0Ig)
    * **Areas**
      * These are in alphabetical order after **General** for easy reference
      * **General**
        * https://learn.unity.com/pathway/unity-essentials (the pathways are all pretty good but long and they tend to focus on 3D games)
        * https://learn.unity.com/tutorial/unity-tips
        * [YouTube - Unity3D Mistakes I made that you should avoid](https://www.youtube.com/watch?v=3kino_s-4mo)
      * **Animations**
        * Only 1st frame of animation is played:
          * This indicates an infinite loop has accidentally been created, so the state is triggered over and over. To fix this, you need to fix whatever is causing the infinite loop
          * Potential solutions:
            * Untick `Can Transition To Self` - https://discussions.unity.com/t/animator-what-does-can-transition-to-self-do/216314/2
            * Use a `Trigger` instead of a `Bool` as an animator parameter (e.g. for death transition). They both look very similar in the UI so it's easy to mix them up, but a trigger only triggers once. `Trigger`s have a circular checkbox in the UI, whereas `Bool`s have a square checkbox
      * **Building**
        * https://docs.unity3d.com/Manual/webgl-building.html
        * https://stackoverflow.com/questions/72453065/unable-to-parse-build-build-framework-js-br
        * https://github.com/seleb/Better-Minimal-WebGL-Template (tried https://github.com/greggman/better-unity-webgl-template but it doesn't keep the aspect ratio when the height is bigger than the width)
      * **Gizmos**
        * [YouTube - How to Draw Gizmos in Unity with Visual Scripting for Visually Debugging your Game](https://www.youtube.com/watch?v=6UPjUeDydLU)
      * **Input System**
        * This replaces the built-in one and is much more configurable
        * https://docs.unity3d.com/Packages/com.unity.inputsystem@1.8/manual/Actions.html
        * https://docs.unity3d.com/Packages/com.unity.inputsystem@1.8/manual/Migration.html
        * [YouTube - How To Use The New Input System In Unity 2022](https://www.youtube.com/watch?v=UyUogO2DvwY)
          * **Note:** This tutorial uses callbacks for input events. It's also possible to poll them instead, which will be much more familiar if you're used to the old input system. See [Responding to actions](https://docs.unity3d.com/Packages/com.unity.inputsystem@1.8/manual/Actions.html#responding-to-actions)
          * Install `Input System` - 0:31
          * Create input mapping file and setup custom bindings - 1:25
          * Generate C# script for mapping file - 4:29
          * Using C# script with the player game object - 4:56
          * All required movement events setup, ready to read values - 8:58
        * [DefaultInputActions](https://docs.unity3d.com/Packages/com.unity.inputsystem@1.8/api/UnityEngine.InputSystem.DefaultInputActions.html) has a bunch of inputs pre-configured, you might be able to use this for your project to speed up setup
      * **Particles**
        * https://learn.unity.com/tutorial/introduction-to-particle-systems
        * [YouTube - Everything to know about the PARTICLE SYSTEM](https://www.youtube.com/watch?v=FEA1wTMJAR0)
        * [YouTube - Dust Effect when Running & Jumping in Unity [Particle Effect]](https://www.youtube.com/watch?v=1CXVbCbqKyg)
        * [YouTube - HOW TO MAKE 2D PARTICLE EFFECTS - UNITY TUTORIAL](https://www.youtube.com/watch?v=_z68_OoC_0o)
        * [Best practice for particle effects in 2D pixel art games](https://imgur.com/gallery/z4Boura)
        * If you can't see your particles in the game, they're probably going into and behind the background. In some cases by default the particles will go into the background along the z-axis, so you need to rotate the particle system using the `Transform` component. It's easier to fix this in 3D mode
        * Set `Simulation Space` to `World` instead of `Local` if you want particles to not follow your game object (e.g. dust trail)
      * **Physics**
        * https://blog.logrocket.com/fundamentals-unity-2d-colliders/
        * Show colliders using Gizmos button (top right) - `Edit -> Project Settings -> Physics 2D -> Gizmos -> Always Show Colliders`
        * [YouTube - Unity Physics Casts: Raycast, Boxcast, Cast All (Getting Started Tutorial)](https://www.youtube.com/watch?v=4MnkuMzFGTc)
        * Character is getting stuck:
          * https://discussions.unity.com/t/2d-character-controller-getting-stuck-on-walls/117289
          * https://forums.tigsource.com/index.php?topic=57886.0
      * **Prefabs**
        * [YouTube - Prefabs & Prefab Variants - Unity Tutorial](https://www.youtube.com/watch?v=S0cjIhI2fIw)
        * https://discussions.unity.com/t/references-to-scene-objects-in-prefabs-inspector-vs-find/245717
        * https://community.gamedev.tv/t/best-practice-for-referencing-a-gameobject-from-a-prefab-with-multiple-instances/220179
      * **Referencing game objects**
        * [YouTube - 5 ways to Reference GameObjects in Unity3D](https://www.youtube.com/watch?v=ymq2AUckws0)
        * [YouTube - Object References in Unity - How to Communicate Between Scripts](https://www.youtube.com/watch?v=dtv7mjj_iog)
        * [YouTube - Scriptable Objects vs GameObject MonoBehaviours - Unity Tutorial for Beginners 2023](https://www.youtube.com/watch?v=XofEVlNmWlI)
      * **Source control**
        * [.gitignore for Unity projects](https://github.com/github/gitignore/blob/main/Unity.gitignore) (will need this otherwise project will be too large to commit to GitHub)
      * **Text**
        * [YouTube - Unity3D - How to put text on your 2D GameObjects, and how to change the text](https://www.youtube.com/watch?v=GJUrZuz_CGM)
      * **Tilemaps**
        * https://learn.unity.com/tutorial/introduction-to-tilemaps
      * **Unity Events**
        * https://gamedevbeginner.com/events-and-delegates-in-unity/
        * https://gamedevbeginner.com/start-vs-awake-in-unity/
      * **Visual scripting**
        * Since this GitHub project is meant to focus on no code and ease of use, this is an important section. Many of the resources end up touching on C#, but it's possible to use visual scripting entirely or mix visual scripting and C# in a game
        * https://learn.unity.com/project/introduction-to-visual-scripting
          * `Edit` -> `Project Settings...` -> `Visual Scripting` -> `Enable Visual Scripting`
          * Add a **Script Machine** or **State Machine** component to a **game object** to enable this (when searching in components, `Visual` won't bring it up, search for `Script` or `State`). The **Graph** contains the visual script, is an asset and can be used in multiple machines (use the **New** button in the component to start from scratch)
          * The video below is a better tutorial, so should be followed as well
          * Tips
            * You can't just drag the visual script onto a game object, create the component first and then create the link
            * White dot variables mean automatic conversions are possible
            * Graph variables can't be accessed from other graphs
            * Object variables are connected to the selected game object
            * Double click will expand the graph area
            * Right-clicking the starting point of a connector will delete it
        * [YouTube - How to Translate C# script to Visual Scripting Graph in Unity](https://www.youtube.com/watch?v=waBRBKZaY9Q)
          * Tips
            * `Object` tab will only be enabled if you have attached the script to an object and have selected it
            * Use `Copy Component` and `Paste Component Values` to easily duplicate `Object` variables between game objects
            * Adding `Graph` variables to retrieve components isn't needed, happens automatically (https://forum.unity.com/threads/how-do-bolt-nodes-reference-components.1225401/) (assume this is as efficient)
        * [YouTube - Subgraphs in Unity Visual Scripting Tutorial (Super Units)](https://www.youtube.com/watch?v=-A36QRdkby8) - way of breaking up scripts into re-usable components
        * https://docs.unity3d.com/Packages/com.unity.visualscripting@1.7/manual/vs-events-reference.html#events-api - calling visual scripts from C# scripts. Also see [YouTube - Unity Visual Scripting - How to Connect and Trigger Scripts](https://www.youtube.com/watch?v=hEYhfC8-jEg)
3. **Add polish to playable game**
   * Removed camera follow component
   * Added slime enemy that uses new `Enemy` tag and updated `WaypointFollower` script to allow sprite flipping
   * Added `OnPlayerDeath` and `OnLevelCompleted` so `PlayerMovement` script can stop the player moving cleanly. Movement stopping is slightly different in each scenario
   * Renamed `PlayerLife` script to `PlayerDamageController` and added enemy killing by jumping
   * Added more functions to `WaypointFollower` script to allow clean destruction. This is handled by the death transition in the animator
   * Modified `PlayerDamageController` and `PlayerMovement` scripts to allow jumping off enemy head on kill
   * Modified `PlayerMovement` script jumping to allow variable jump height (https://forum.unity.com/threads/setting-variable-jump-height-for-the-second-jump.391842/)
   * Added dust effect to `PlayerMovement` script
   * Added `Checkpoint` script to handle checkpoints. `CheckpointParent` script used to make it easier to setup events. Event used to let player know last position. Be careful when copying the coordinates around, `Vector3` is fine to copy because it's a `struct` but `Transform` will give you a `reference` (see https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/choosing-between-class-and-struct)
   * Created 1-way platforms by adding another layer and ticking `Use One Way` in the `Platform Effector 2D` component
   * `ItemCollector` script now fires an event when an item is collected. Created new `FinishGated` script and moved counting logic there. Moved collected item count from canvas into game world above finish flag. These work together to show the user they need to collect all the items to finish
   * Added `Fader` script to fade and unfade finish flag to give an extra visual indicator that items need to be collected to unlock the flag. Also created `FaderVS` to show how visual scripting can be used in conjunction with C# scripts. They are both reasonably similar and are used in the `FinishGated` script
   * Replaced old input system with new input system
   * See **Building** links above for final build (this was more fiddly than expected due to the default WebGL template not having sensible defaults)
4. **Optional**
   * These are in alphabetical order for easy reference
   * **Art**
     * [YouTube - GAME ART / ANIMATION TUTORIALS](https://www.youtube.com/watch?v=9oiz1pectr8&list=PLBIb_auVtBwBzY820L_LFnlK8v_V3Avxc)
     * [YouTube - 5 Steps To Making A Gorgeous 2D Game](https://www.youtube.com/watch?v=QD3SFyWPVFY&list=PUuHVjteDW9tCb8QqMrtGvwQ&index=5)
   * **Movement**
     * Improving how things move and feel
       * https://fungies.io/2023/04/11/how-to-properly-implement-movement-in-unity-2d-a-short-guide/
       * [YouTube - Improve Your Platformer with Forces | Examples in Unity](https://www.youtube.com/watch?v=KbtcEVCM7bw)
       * [YouTube - Ultimate 2D Platformer Controller in Unity (source code provided)](https://www.youtube.com/watch?v=3sWTzMsmdx8)
       * [YouTube - The ULTIMATE 2D Character CONTROLLER in UNITY](https://www.youtube.com/watch?v=lcw6nuc2uaU)
   * **Packages**
     * Potentially useful packages (not tested, but seem useful)
       * Free
         * [Boomerang 2D Framework](https://assetstore.unity.com/packages/templates/systems/boomerang-2d-framework-164608#reviews)
         * [DOTween (HOTween v2)](https://assetstore.unity.com/packages/tools/animation/dotween-hotween-v2-27676) (paid version too)
       * Paid
         * [Corgi Engine](https://corgi-engine.moremountains.com/) - "The best 2D + 2.5D platformer solution for Unity"
   * **Tilesets**
     * [YouTube - TILESET in Photoshop (Tutorial)](https://www.youtube.com/watch?v=aaEEujLtsr8)

## Notes
* **Glossary**
  * **Component** - contain properties which you can edit to define the behavior of a **GameObject**
  * **GameObject** - fundamental objects in Unity that represent characters, props and scenery
  * **Prefabs** - templates for **GameObject**s with preset components - basically drag a **GameObject** that's been setup to a folder, usually `Prefabs`
* **Fundamentals**
  * All game objects have a **Transform** component because they're displayed on the scene somewhere
* **Keyboard shortcuts**
  * **QWERTY** - these map to the editor common tool group that starts with the Hand
  * **SHIFT+F** - Zoom into currently selected game object. Or double click on the game object
  * **CTRL+D** - Duplicate the currently selected game object
  * **CTRL+P** - Play / Stop playing game
  * **TileMaps**
    * Hold **Shift** and left-click to erase a tile you just layed
    * Rotate a tile before painting by using `[` and `]`
  * Hold **CTRL** when moving a sprite to move in increments
  * Hold **ALT** when using `Rect Tool` on a sprite to resize from the centre
* **Areas**
  * These are in alphabetical order for easy reference
  * **Animations**
    * Don't forget to check `Loop Time` in the inspector for the animation clip (asset with triangle icon) to make sure the animation loops
    * You can drag sprites into the animation timeline but it's a bit fiddly because sometimes it won't let you. Just make sure to select the game object and it should work
    * Usually need to change transition defaults so `Has Exit Time` is unchecked and `Transition Duration` is 0
    * Triggers are one-off events that can be used in the Animator (e.g. `death`)
    * **Animation** window
      * Dots in top right allow you to `Show Sample Rate` which will let you change the speed of the animation
    * Recording animations is easier than trying to do things programatically
  * **Audio**
    * `Play On Awake` is checked by default which usually isn't what you want
  * **Designing**
    * Using **Square**s as initial game objects mean you get a **Sprite Renderer** component added automatically, making setup slightly faster
    * Whenever you nest a game object under another game object, the Transform component becomes relative to the parent (e.g. if you put the camera under the player object, the camera will follow the player)
    * Freeze rotation Z on rigid body to stop it rotating about that plane
  * **Editor**
    * If you mess up Editor layout, can just select `Default` in the top right
    * Prefabs are highlighted in blue. Edit Prefabs by clicking on the `>` arrow on right (if you edit the game object directly it only applies to that one and not all the others)
    * When adding a new game object, check the Z value because it sometimes isn't exactly 0
    * **Hierarchy** window
      * Eye icon to left of objects lets you toggle visibility
  * **IDE** (e.g. `Visual Studio`)
    * Moving scripts around after creating them can break the intellisense so need to regenerate using `Edit` -> `Preferences` -> `External Tools` -> Select your IDE in `External Script Editor` -> Click `Regenerate project files`. This seems to happen more often with `Visual Studio Code`
  * **Inspector**
    * `?` icon takes you straight to documentation
  * **Project Settings**
    * **Input Manager** lets you rebind keys for old input system
  * **Sprites**
    * Click the sprite group (not the individual frames) to set the `Pixels Per Unit` value before working with a sprite
* **Troubleshooting**
  * When changing `UnityEvent`s, you need to setup up the serializable fields for events again otherwise you'll get strange type errors
  * **Visual Studio Code**
    * When adding new scripts, intellisense may not work for the new files. This can be fixed by regenerating the project files as per the setup steps
    * In some cases regenerating will not fix the issue, seem to be quite a few bugs here
    * Overall, the `Visual Studio` integration seems a lot more bug free, so recommend using that instead