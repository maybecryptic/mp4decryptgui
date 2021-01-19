# mp4decryptgui

**if you've never ripped from amazon then learn how to do that first before trying to use this program**

this project was quickly thrown together to speed up the process to rip from amazon. this is something I made for myself and figured if anyone else finds it useful, then that's cool. but I won't program requests in or anything. if you just want to clean the code up or whatever and it doesn't mess with core functionality, then I may PR it

the core functionality is pulling the keys out of the mpd along with pulling the subtitles out as well (no more searching for them). only ttml2 has been added thus far since that's all I have run into. _the program uses the directory it runs in for all of the files so make sure you have everything placed in a single directory_

the mkvmerge arguments sets the video, audio and subtitles to english, and makes the subs non-default. if you want that changed then make sure to edit that before running

do note this hasn't been extensively tested so it may not work with all amazon shows

# requirements
- mp4decrypt
- SubtitleEdit (if ripping subtitles - optional)
- mkvmerge

# instructions
1. get the mpd and click the "get keys" box (it will paste in automatically and get the video/audio kids)
2. download the video and audio streams to the directory (do not rename them)
3. get the subtitles and click the "get subs" box (it will get the link and download the subs right away)
4. get the matching keys from the widevine decryptor plugin and paste them in by clicking the corresponding boxes
5. click start and hope it doesn't explode

# video tutorial
https://lbry.tv/@cryptic:6/mp4decryptgui