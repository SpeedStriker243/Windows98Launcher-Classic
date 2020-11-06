# Windows 98 Launcher
A GUI front-end for QEMU that is intended for installing and running Windows 98 inside of a virtual machine. Currently unfinished. Bundled with QEMU.

## ISO file
You need to provide your own Windows 98 ISO for use with this project, however a boot disk is already supplied. This ISO file must be named `windows98.iso`.

### Other OSes
It is possible to boot other operating systems using *their* ISO files, but it is not recommended, as this project was created with Windows 98 in mind. (It may also be possible to install and boot Windows 95.)

## Hard disk image
If you already have a QCOW2 image for Windows 98 (or any other x86 OS), you can run it using this project. The image must be named `win98.qcow2`, however if you do not have an image, the program will use `qemu-img` to create one.

## QEMU
[QEMU](https://www.qemu.org/) is open source software licensed under the [GNU General Public License V2](https://www.gnu.org/licenses/old-licenses/gpl-2.0.en.html) created by [Fabrice Bellard](https://bellard.org/), and is not affiliated with this project or me whatsoever.
