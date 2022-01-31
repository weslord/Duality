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
about that process.

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

### Physics

No gravity, anti-friction material - can set project-wide as default.

Cumulative collider (sp?)

Issues with inertia when pushing objects - follower character will
de-synchronize position with main character if it's the only one pushing

### Level Desgin

Made it simple by having colliders auto-sync to visual rectangles in `validate()`

Really hard to come up with something that's not just solvable by button-mashing
Wish I'd had more time to develop...

## Credits

This project was made possible by the following assets:

- [Shapes](https://assetstore.unity.com/packages/tools/particles-effects/shapes-173167),
  a vector graphics package by Freya Holmér
- [3270](https://github.com/rbanffy/3270font), a font inspired by the IBM 3270
  terminal
- [Nord](https://www.nordtheme.com/), a colour palette for text editors

