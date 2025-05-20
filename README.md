# 2D Game Engine Comparison For Rapid Prototyping For Anyone

## Introduction
I've always wanted to build my own game but had *zero* knowledge about this area. Game engines have advanced so much that *most people* can now put something reasonably impressive together for fun (or profit) *without too much effort*. [This post](https://farawaytimes.blogspot.com/2023/02/how-to-make-good-small-games.html?m=1) inspired me to dive in.

### What does this repo offer me?
There are an overwhelming number of game engines to pick from so here is:
* A **2023** shortlist for *anyone* to try out that are all **free**
* Links to get you started
* The same playable game for each engine to make it easy to compare (created by following the links provided)
* The source code for each game
* A list of engines that didn't quite make the cut, with reasons (mostly objective)

### Selection criteria
I've been a software engineer since about 2007 and although I can code in a variety of languages I wanted something that *anyone* could pick up so these are the key criteria for inclusion:
* **Free** (you can build a good game without being forced to upgrade to premium versions). Open Source is a bonus
* Good documentation
* Good community
* Under active development
* Easy [visual programming](https://en.wikipedia.org/wiki/Visual_programming_language) (so you don't need to learn how to code)
* Support working in a **common and useful programming language** (so you can teach yourself coding at the same time or not feel limited by the visual scripting)
* Easy to use editor
* Supports exporting to **HTML5** (since this is an easy format to host and share, e.g. free hosting on https://itch.io/games). More formats available is even better
 
For total beginners 2D games are much simpler to build than 3D games. If you're interested in **3D games** I would create a few 2D prototypes first and pick the game engines I've marked as supporting 3D.

If you enjoy this project, please consider [:hearts: buying me a beer :beer: :hearts:](https://johnduncanscott.github.io/#/tip) and starring :star: the project. My [**personal website**](http://johnduncanscott.github.io) for the curious.

## Summary
**GDevelop** is probably the one you should start with. If you feel limited, move to **Unity** but expect a steep learning curve. I've personally decided to stick with **Unity** (despite the 2023 pricing fiasco) as it's powerful and I like C#, plus some of my friends are using this. Key information can be found below, see the **Comparison** section next for a deeper analysis.

| Area                               | GDevelop                                                                                                                   | Unity                                                                                                                |
| ---------------------------------- | -------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------- |
| **Playable game link**             | [My demo](https://duncanscott.itch.io/2d-platformer-demo-gdevelop)                                                         | [My demo](https://duncanscott.itch.io/2d-platformer-demo-unity)                                                      |
| Playable game screenshot           | ![GDevelop screenshot](https://johnduncanscott.github.io/assets/projects/2d-game-engine-comparison_gdevelop_thumbnail.png) | ![Unity screenshot](https://johnduncanscott.github.io/assets/projects/2d-game-engine-comparison_unity_thumbnail.png) |
| Game size                          | ~9 MB                                                                                                                      | ~10 MB                                                                                                               |
| Time (hours) - General tutorials   | 1.5                                                                                                                        | 6.5                                                                                                                  |
| Time (hours) - Platformer tutorial | 2                                                                                                                          | 10                                                                                                                   |
| Time (hours) - Platformer polish   | 4.75                                                                                                                       | 18                                                                                                                   |
| Time (hours) - Total               | **8.25**                                                                                                                   | **34.5**                                                                                                             |
| **Notable games**                  | **Hyperspace Dogfights**                                                                                                   | **Cuphead**, **Hearthstone**, **Hollow Knight**                                                                      |
| **Showcase**                       | [YouTube](https://www.youtube.com/watch?v=vhVT_avcFgA)                                                                     | [YouTube](https://www.youtube.com/watch?v=IjJ9j_HYgGI)                                                               |

## Comparison
See **Details** below to clarify some of the ratings.

* **Key**
  * ⭐ - excellent (very few flaws)
  * ✅ - good (flaws but overall pleasant experience)
  * 🆗 - average (mixed experience)
  * 😡- poor (easy to find flaws, overall negative experience)
  * ❌- not supported

| Area                  | GDevelop                                                   | Unity                                           |
| --------------------- | ---------------------------------------------------------- | ----------------------------------------------- |
| Version used          | 5.1.160                                                    | 2021.3.27f1                                     |
| Updates               | ⭐ (every month)                                            | ⭐ (every 2 weeks)                               |
| Pricing / Licensing   | ⭐, [Link](https://gdevelop.io/pricing) / Open Source (MIT) | 🆗 [Link](https://unity.com/compare-plans)       |
| 2D                    | ✅                                                          | ✅                                               |
| 3D                    | 😡 (being improved)                                         | ✅                                               |
| Platforms             | ✅ (HTML5, Mobile, Desktop & Facebook)                      | ⭐ (Free: HTML5, Mobile, Desktop. Paid: Console) |
| Documentation         | ⭐                                                          | 🆗                                               |
| Community             | ✅                                                          | ⭐                                               |
| Ease of use           | ⭐                                                          | 🆗                                               |
| Build time / Speed    | ⭐                                                          | ✅                                               |
| Editor                | ✅                                                          | ✅                                               |
| Editor - Autocomplete | ✅                                                          | ⭐                                               |
| Editor - Size         | ~400 MB                                                    | ~7 GB                                           |
| Editor - Preview      | ✅ (quick)                                                  | ✅ (quick)                                       |
| Languages supported   | JavaScript                                                 | C#                                              |
| Game controls         | ⭐ (Keyboard built-in, controller via extension)            | ⭐ (new input system very flexible)              |
| Sprites               | ✅ (built-in Piskel support)                                | ✅                                               |
| Enemies               | ✅ (AI via extensions)                                      | ⭐                                               |
| Asset store           | ✅                                                          | ⭐                                               |
| Tilemaps              | ✅                                                          | ⭐                                               |
| Text                  | 🆗                                                          | ⭐                                               |
| Hit detection         | ✅                                                          | ⭐                                               |
| Animations            | ✅ (via Piskel)                                             | ⭐                                               |
| Particle effects      | ✅                                                          | ⭐                                               |
| Sound effects         | ✅                                                          | ⭐                                               |
| Music                 | ✅                                                          | ⭐                                               |
| Abstraction           | ⭐ (custom objects, extensions, functions, etc.)            | ⭐ (prefabs, subgraphs, functions, etc.)         |

### Details

#### GDevelop
Overall good fun to use and quick to get up and running for a total beginner. **Recommended**.

Key parts are free and there are useful free services. Documentation is easy to find, up-to-date and there are extensive videos. There's an active community that's a reasonable size. Editor on mobile is limited but on desktop and web it's unrestricted. Editor supports grouping, comments and colours for organisation plus the preview is instant. HTML5 builds are unlimited but you only get a few per day for other platforms, but this is probably manageable. Can download extensions in the IDE to build things faster (e.g. add controller support) and you can add your own. IDE has built-in guided lessons. Reasonable selection of free assets.

Console builds are not supported. Can't use other editors for JavaScript coding (e.g. Visual Studio Code). Specialises in 2D games; 3D games can be made through extensions but are in an early state, but is being developed rapidly. Although 2D is a speciality it lacks advanced features like skeletal animations. Tilemaps could be a bit more clever. Some of the older tutorials haven't been updated for the new IDE and have a few minor errors. IDE provides reasonable autocomplete but improvements can be made here. Could do with more free assets, especially sounds & music.

The developers are really good at listening to feedback and polishing things, so things keep changing rapidly. [GDevelop 5.3](https://www.youtube.com/watch?v=1GXC-LPqhV0) was released which added a few things I thought were lacking when starting out, such as object folders, improved variable syntax, Steamworks integration (networking, achievements, etc.) and simplified conditions / actions.

#### Unity
Overall very powerful but at the expense of being complicated and having many unpolished features. Would recommend you start with **GDevelop** first then migrate to this if you feel limited. You might choose this first if you want:
* To learn a solid backend programming language (static typing will give you nicer errors than JavaScript and switching to Java later is also easy)
* To learn a battle-tested popular game engine (**Unreal Engine** is its main competitor)
* You want something that won't limit you (but may frustrate you)

The important parts are free (unless you want to release to consoles). API documentation and the community is good. There is a full learning track but it's mostly for 3D. Excellent external editors (e.g. Visual Studio) are easy to setup and are a must if not using visual scripting. Massive selection of free assets. Very powerful and has many tools (e.g. smart tiling, skeletal animations, solid particle system, etc.). Good for 2D and 3D although the 2D isn't really specialised (just a modified view of the 3D world, which you might prefer if you want to mix and match). Multiplayer is available. 

Initially found it hard to make progress because there's so much to learn. It took **4x** as long as **GDevelop** to learn enough and build the equivalent game, although I feel the Unity one is more polished. This is not helped by the fact that many of the official tutorials are designed for specific versions, so expect mistakes or bugs when not using the exact one. In addition the **2D** tutorials are poor at teaching you the fundamentals (stick to YouTube). The vast majority of tutorials (both official and unofficial) focus on coding rather than visual scripting. It's not too tricky to convert between them, but you may find it tricky to get started if you want to only focus on visual scripting. In the end I chose to follow C# ones and then try some visual scripting which was nice enough (much of the C# is copy / pasting anyway so you'll probably be ok). Many annoyingly unpolished features (e.g. "2d game kits" left to rot, version mismatch issues, default WebGL template doesn't stretch properly, etc. - too many to list, also see https://garry.net/posts/unity-2020). The editor is complicated to get to grips with initially. Projects are slow to open.

If you would like to get started faster then there a few packages in the **Optional** section that could be good.

##### 2023 pricing fiasco
* https://arstechnica.com/gaming/2023/09/oldest-unity-game-developer-group-breaks-up-over-lack-of-trust-in-the-company/
* https://www.bbc.co.uk/news/technology-67063855

Ultimately, all companies need to make money but they did a bad job with this one. At least the CEO quit. This has made me a bit more cautious, but I'm still sticking with Unity because overall it is a good tool and ultimately anything you pick that's free might have similar changes.

#### Language guide
This project only focuses on engines that offer [visual programming](https://en.wikipedia.org/wiki/Visual_programming_language) (in addition to common languages). However, you may wish to start with visual programming and then dig into a popular programming language (e.g. for job purposes). Choosing a language is ultimately a personal preference. Below is a brief guide for the common ones:
* JavaScript - popular in web development
* TypeScript - typed version of JavaScript. Gaining popularity in web development
* Java / C# - solid all-rounders. Syntax is similar. Usually seen in backend services. C# is popular in games too (e.g. **Unity** engine, **Godot** engine)
* Python - easy to read. Popular in AI / machine learning. Good as a general purpose scripting language for automation
* Lua - easy to embed in other applications. Easy to learn. Popular in games (e.g. **Love** engine, Roblox, World of Warcraft interface customisation, etc.)
* C++ - subjectively harder than the others to learn. Great for optimisation. Usually seen in high performance systems, low level software and games (e.g. **Unreal Engine**)

## Engine Guides

* [General](docs/general_engine_guide.md)
* [GDevelop](docs/gdevelop_engine_guide.md)
* [Unity](docs/unity_engine_guide.md)

### Potential game engines
* **Unreal** - market leader. Better experience for 3D games but can also do 2D games. Can export to HTML5. Has visual scripting via `Blueprints`. Code must be C++ (harder than C#). `Pixel 2D` and `PaperZD` packages are popular, but `PaperZD` doesn't support multiplayer. `PaperZD` got bought by Epic to replace `Paper2D` since it hasn't been updated in a long time ([Link](https://www.reddit.com/r/unrealengine/comments/xzgv6t/is_ue_well_suited_to_2d_games/)). However `Paper2D` *does* support multiplayer. Would likely be a worse experience than **Unity** so this hasn't be prioritised yet ([Link](https://www.reddit.com/r/unrealengine/comments/15znwya/anything_you_feel_was_hard_to_overcome_with/))

### Rejected game engines
These are in alphabetical order for easy reference. Each is validated against the key criteria defined at top. Any ❌ results in a rejection. In some cases you may think the rejection is unfair, so feel free to try some out. There are a large number of game engines and they had to be cut down somehow. "Last update" column updated on 01/11/2023.

| Engine             | Free version  | Visual programming | Common languages                | HTML5 supported | Docs   | Community | Ease of use | Last update          | Notes                                                                                                                                                      |
| ------------------ | ------------- | ------------------ | ------------------------------- | --------------- | ------ | --------- | ----------- | -------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------- |
| **BabylonJS**      | ✅             | ❌                  | ✅ TypeScript                    | ✅               | ✅      | ?         | ?           | ✅ 5 days ago         | Can do 2.5D. **Phaser 3** preferred for 2D. No plans to focus on 2D                                                                                        |
| **Bitsy**          | ✅             | ✅                  | ❌                               | ✅               | ✅      | ✅         | ✅           | 🆗 97 days ago        | ❌ Can't make anything complex (simple grid-based games)                                                                                                    |
| **Cocos2dx**       | ✅             | ❌                  | ✅ JavaScript, Lua               | ✅               | ❌ Poor | ?         | ?           | ✅ 15 days ago        | Seems more geared towards chinese market than english                                                                                                      |
| **Construct 3**    | ❌ Too limited | ✅                  | ✅ JavaScript                    | ✅               | ✅      | ✅         | ✅           | ✅ 49 days ago        | [Forum discussion](https://www.construct.net/en/forum/construct-3/general-discussion-7/construct-free-version-149886) suggests free version is too limited |
| **Defold**         | ✅             | ❌                  | ✅ Lua                           | ✅               | ✅      | ?         | ?           | ✅ 8 days ago         |                                                                                                                                                            |
| **GameMaker**      | ❌ Too limited | ✅                  | ❌ GML                           | ❌ Paid          | ✅      | ✅         | ✅           | ✅ 47 days ago        |                                                                                                                                                            |
| **Godot**          | ✅             | ❌                  | ✅ C#                            | ✅               | ✅      | ✅         | ✅           | ✅ 28 days ago        | Visual scripting support was removed in 4.0                                                                                                                |
| **Love**           | ✅             | ❌                  | ✅ Lua                           | ✅               | ✅      | ?         | ?           | ❌ ~2 years ago       |
| **Phaser**         | ✅             | ❌                  | ✅ JavaScript, TypeScript        | ✅               | 🆗      | ?         | ?           | 🆗 6 months ago       | Visual scripting via paid 3rd party editor                                                                                                                 |
| **PICO-8**         | ✅             | ❌                  | ✅ Lua                           | ✅               | ✅      | ✅         | ✅           | 🆗 10 months ago      | Fantasy console. Font hard to read in free version                                                                                                         |
| **Pixel Vision 8** | ✅             | ❌                  | ✅ C#                            | ❌               | ✅      | ?         | ?           | ❌ Development paused | Fantasy console                                                                                                                                            |
| **PlayCanvas**     | ❌ Too limited | ❌                  | ✅ JavaScript                    | ✅               | ✅      | ?         | ?           | ✅ 3 weeks ago        | Free version does not allow private projects                                                                                                               |
| **PuzzleScript**   | ✅             | ❌ (not needed)     | ❌ PuzzleScript                  | ✅               | ✅      | ?         | ✅           | 🆗 6 months ago       | ❌ Can't make anything complex (puzzles only)                                                                                                               |
| **Stencyl**        | ✅             | ✅                  | ❌ Haxe                          | ✅               | ?      | ?         | ✅           | ❌ 2 years ago        | ❌ Free version can only publish to web                                                                                                                     |
| **TIC-80**         | ✅             | ❌                  | ✅ JavaScript, Lua, Python, Ruby | ✅               | ✅      | ✅         | ✅           | ✅ 2 months ago       | Fantasy console. Similar to **PICO-8** but less limited (more memory for code and sprites). External editor requires paid version                          |
| **Twine**          | ✅             | ❌ (not needed)     | ✅ JavaScript via Snowman        | ✅               | ✅      | ?         | ✅           | ✅ 3 months ago       | ❌ Can't make anything complex (interactive stories only)                                                                                                   |  |
