Console application for creating a copy of the image with a reduced size.

Author: Roman Kopaev aka ZooY, Programming Zone / www.pzone.ru, zooy@pzone.ru
Version: 1.0
Source code: https://github.com/ZooY/PZone.Tools

Usage:

ImageResizer.exe s=<filename> r=<filename> [w=<number>] [h=<number>]

s=<filename>   Image source file.
r=<filename>   Image destination file.
w=<number>     Width of the resulting image.
h=<number>     Height of the resulting image.

The names of the files that have spaces must be enclosed in quotes, i.e.: s="c:\My Documents\Image.jpg"
To proportionally change the size, you must specify either the width or the height of the image.