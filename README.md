# ScreenGrabber

## What is ScreenGrabber?
ScreenGrabber is a program written in Visual Basic .NET that will capture the screen and save it as a file when you press Print Screen. It is mainly a programming exercise to teach myself a little more about programming. I'd advise using a better screenshot program like [Greenshot](https://getgreenshot.org/) or [ShareX](https://getsharex.com/).

## Specifications
- Language: Visual Basic .NET
- Requirements: .NET Framework 4.0 (for backwards compatability up to Windows XP)

## Features
- Capture a screenshot of primary or all monitors
- Instantly save screenshots, removing the need to paste into an image editor

---

## Development Notes
ScreenGrabber is a fresh project and is still in the very early stages of development. It is somewhat functional, but may not work as desired yet. Here are notes of what needs to get done and what I plan for the future.

## To-Do List

### Plans: 2021 Jan 15
- ~~Add an option to change the directory for screenshots~~ (Completed 2021 Jan 15)
- Add the ability to capture individual monitors other than the primary monitor
- Add a screen snipping feature as a way to easily crop screenshots
- Add a way to save settings for future sessions
- Add the ability to save in different formats (JPG, BMP, etc)

---

## About VirusTotal
When scanning the latest executable (can be found in /bin/Debug/) in [VirusTotal](https://www.virustotal.com/gui/file/884d9a83113b3da7567b00bdd1ac4c61ad9704f28bc5302de8b8bfd9befd08d0/detection), it brings up 2/69 detection. These are false positives; you can read the code yourself and rest assured I have not written any malicious code. However, there may be bugs I haven't noticed. Use this software at your own risk.