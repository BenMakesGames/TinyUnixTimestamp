# TinyUnixTimestamp
by BenMakesGames / Ben Hendel-Doying

See LICENSE for licensing info (spoiler: it's the MIT License).

TinyUnixTimestap is a tiny program written in C# using Visual Studio. All it does is this:

1. It adds a system tray icon which, when clicked, copies the current Unix timestamp to your clipboard.
2. Right-clicking its tray icon brings up a menu with one option: "Exit".

If you don't want to compile it yourself, there's a compiled executable in [the TinyUnixTimestamp/bin/Release directory of this project](https://github.com/BenMakesGames/TinyUnixTimestamp/tree/master/TinyUnixTimestamp/bin/Release).

## FAQ

### What on earth compelled you to make such a program? Why would anyone want it?

I used to do a lot of MySQL work in a database where times were always stored as a Unix timestamp. Visiting unixtimestamp.com was fine, but it occurred to me that a program like this would make my life _even better_. Unable to find such a program, I made one myself: TinyUnixTimestamp.

Why _you_ would want it... I don't know. I guess if you find yourself working with Unix timestamps so much that even visiting a webpage seems like too much trouble.

### Can you add an option to make TinyUnixTimestamp run when Windows starts?

I don't need to: Windows itself already provides you a way to run _anything you want_ when it starts. Remember the "Startup" folder in the Start menu? Yeah, it's still there; and it's still good! Just drop a shortcut to TinyUnixTimestamp (or even the executable itself) into that folder. Ta-da!
