# Duality

A simple puzzle game

January 2022

<https://weslord.com/games/duality/>

## Controls

- Arrow keys, WASD, or gamepad to move around
- [ESC] or [CANCEL] to reset the level
- [,] or [.] to skip levels (secret cheat code, shhhh!)

## Post Mortem

Over the last couple days, I solo jammed out this game. Here are some thoughts
(too many thoughts) about that process.

### Colour Palette

I knew my game was going to be very graphically primitive, so the colors would
shoulder the bulk of the responsibility for how the game looks. Before I started
coding, I decided to use the colour palette from my favourite text editor colour
scheme, Nord.

The colour picker in Unity's editor has a "swatch" feature, which seemed like a
perfect place to store my colours. Unfortunately, as of Unity 2020.3.26f, it's
pretty clunky. Adding colours through the default colour picker is a bit of a
pain, and managing them is even less convenient. Also, the default swatch is not
project-specific, but shared for all Unity projects.

I created a new custom swatch and saved it in my project, so that I could check
it in to version control. The swatch asset itself also had a slightly better
interface for adding colours than via the colour picker itself. Still a little
clunky, but an improvement.

There's another limitation here: colours in the swatch are basically just
shortcuts to a colour value that you can select in the colour picker, but they
are not dynamic at all. Applying the colour to a property does not preserve a
relationship with the swatch, so it can't be used for palette swapping.

Luckily my use-case was pretty simple, so this was fine, but even then, the
Unity editor would apply the first colour you select in a swatch after opening
the colour picker. You can't even click around your different colours to quickly
compare options. It's pretty clear this feature isn't a high priority on Unity's
radar.

In the end, it did end up saving me a bunch of time. But I'd mostly chalk that
up to luck - I happened to be using it in exactly the limited way it was useful
for.

### Level Desgin

I used a vector graphics library called "Shapes" to create all my visual
elements.  It's a bit expensive, but I bought it a while ago when it was on
sale, expecting I'd be doing a lot of vector work someday. It retrospect,
though, it wasn't necessary for this project. I built everything out of
primitive rectangles, and could have used Unity's built-in 2D rectangle shape
instead.

Walls were all instances of a prefab with a static rigidbody, no friction, and a
box collider. The collider's shape was automatically synced to the size of the
rectangles in `OnValidate()`, so creating levels was as simple as dropping in a
prefab and stretching it to be where I wanted my walls.

This is how I was able to throw together nearly two dozen levels in just a few
hours - keeping the tools simple and easy.

I do wish I'd finished coding earlier than I did, to have a bit more time to
work on the levels. As it stands, the "harder" levels can easily be beaten by
button mashing, rather than deliberate skill or puzzle solving.

### Physics

I'm using Unity's two dimensional physics for collision detection. And I guess
to push blocks around in the later levels (spoiler warning, forget I said
anything). But it would be a stretch to describe any other aspect of the game as
a "physics simulation". We're fighting against pretty much every other physics
feature to get the behaviour we want.

First off, gravity. Can be turned off globally in the 2D Physics settings.
Second off, friction. It's pretty important to keep the two blocks in sync, and
they get out of sync very fast if one of them slows down every time it rubs
against a wall. I made a physics material with zero friction, and applied it to
all my prefabs - then later I noticed you can set a default physics material
globally in the 2D Physics settings. So that would have been easier. (I set it
there too, just in case.)

I made plans for a bunch of  cool control modes, but God laughs. You only get
one, so you better like it. It's the most interesting one, anyways: the uni-
directional link. Oooh! Aahhh!

The way it works is a bit of a hack. Both character objects get the same
controller inputs and process them the same. Each of them has their own
collider, to stop them from ghosting through their own walls. But the right side
character has a bonus child collider that syncs its position to the left side
character. This works as a compound collider, so it suffers both constraints.

It works pretty well for the limited scenarios currently in the game, but I
wanted a mechanic in later levels where movements are mirrored or rotated around
an axis. I don't think it's possible without an overhaul of the movement system.

Also, there are issues with inertia when pushing objects. The right side
character will de-synchronize position with left side character if it's the only
one pushing a block.

## Credits

This project was made possible by the following assets:

- [Shapes](https://assetstore.unity.com/packages/tools/particles-effects/shapes-173167),
  a vector graphics package by Freya Holmér
- [3270](https://github.com/rbanffy/3270font), a font inspired by the IBM 3270
  terminal
- [Nord](https://www.nordtheme.com/), a colour palette for text editors

