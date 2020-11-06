# Windows 98 Launcher
An open source GUI front-end for QEMU that is intended for installing and running Windows 98 inside of a virtual machine. Currently unfinished. Bundled with QEMU and written in .NET C#. Yeah, that means it won't work in macOS or Linux without any [compatibility layers](https://www.winehq.org/). Sorry.

![Windows 98 Launcher](https://github.com/SpeedStriker243/Windows98Launcher/raw/master/win98launcher.png)

# Important stuff
## OS files
You need to provide your own Windows 98 ISO for use with this project, however a boot disk is already supplied. This ISO file must be named `windows98.iso`. For legal reasons, I can't include one in this project.

### Other OSes
It is possible to boot other operating systems using *their* ISO files, but it is not recommended, as this project was created with Windows 98 in mind. 
If the OS in question supports i386 (Intel x86 32-bit) processors, it'll probably work.

## Hard disk image
If you already have a QCOW2 image for Windows 98 (or any other x86 OS), you can run it using this project. The image must be named `win98.qcow2`, however if you do not have an image, the program will use `qemu-img` to create one.

## QEMU
[QEMU](https://www.qemu.org/) is open source software licensed under the [GNU General Public License V2](https://www.gnu.org/licenses/old-licenses/gpl-2.0.en.html) created by [Fabrice Bellard](https://bellard.org/), and is not affiliated with this project or me whatsoever.

# Frequently asked questions (that were not actually asked)
## Why would you make this?
For fun.

## What can it do?
Whatever you can do with a Windows 98 VM.

## Does it have internet?
Unless you somehow had a flipping modem from the 90's, then no, I don't think it'd have internet. (Disclaimer: even if you *did* have a modem I don't think it'd work)

## Why would I use this when I can just use VirtualBox or VMware?
No one said you had to, this was just an experiment.

## Can it run Doom?
Abso-fricking-lutely.
