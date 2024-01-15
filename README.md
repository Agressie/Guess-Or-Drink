# Guess Or Drink

Choose a category and start guessing and maby you'll just end-up with that HOT cousin in bed tonight.

#Native Service:
The Native Mobile function is added on the creation of an new account. When a new account is created the app wil automatically send an notifcation to the user to welcome them.

#API:
On the 2nd page there are 2 options, 1 is to start a game and the other to see account details. Because the account details weren't to important i made this a Meme page and the memes are gathered from the internet via an API. I do need to give Rachel Breve credits here. because she showed me this and let my copy it so to make it work i only had to change some namespaces and using arguments to make it work. This was not even 2 minutes work to change.

#SQLite:
The Database was giving me some issues on some parts. That is why i chose to create the category's everytime the app opens. However i did get it working on the user. Here the app can create an user and save it to the database and it can also read from the database to do an logincheck. I did redo some of the structure of creating the user because the way the slides showed it didn't realy make sense to me and i had a hard time figuring it out. Thus i created my own version that still uses the repository's only not via an ICommand but by calling the function "manualy".

#How to Use:
When you open the app for the first time there aren't any users created so you need to create a user before you can procede. (Plans to make a forgotten password function was thought of but was ultimitly decides not to implemt as of right now and is pushed farther away in the pipeline.)
Then when you are logged in, you can create a new game and then chose a category. after that you select a gamemode and or change the settings or procede with 2 standerd teams. If you change the settings you can change the amount of rounds played and the amount of teams in competition.
Functionality after has unfortunatly not been realized and implemented. The essence was that each team would get 30 secondes to guess or portray 5 charades. If they did correctly they are safe. If they didn't then that team would have to take an shot. At the end of the game to decide an winner the team captan would hold the phone in his hands and the team captain that would keep it the most steady while walking over an 5 meter line wins the game.
