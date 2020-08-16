# Simple Priority

Send an automated randomized message every 7 minutes in your server with ease! just follow the Installation & Setup guide and you will have an automated message sending system ready!

## Installation & Setup

1) [Download Source](https://github.com/YonLiud/Simple-Priority)
2) Open in ``Simple Priority.sln`` in [Visual Studio](https://visualstudio.microsoft.com/)
3) Locate in line 38, 44,50,56,60  in ``Server.cs`` 
```cs
message =
```
4) Change the String Parameters to the wanted text to appear in game;
5) Build The Whole Solution ([How to Do It](https://docs.microsoft.com/en-us/visualstudio/ide/building-and-cleaning-projects-and-solutions-in-visual-studio?view=vs-2019))
6) Inside your server.cfg, type the following command:
```lua
start sHourly
```
7) Replace the both built files inside the `sHourly` folder
8) Drag and drop the `sHourly` Folder into ``..\FXServer\server-data\resources\``

9) Restart your server







## Questions and Requests
If you have any suggestions or ideas, feel free to  contact me in [my Linktree](https://linktr.ee/YonLiud) or my Discord > y0nliud#1545 <

### Bug Reporting
To report a bug or any issue you encounter, open a github issue ticket, and I will fix the issue hopefully the following commit and releases 

## Authors and acknowledgment
Created by Yonatan Mark Liudmirsky



## License
[MIT](https://choosealicense.com/licenses/mit/)
