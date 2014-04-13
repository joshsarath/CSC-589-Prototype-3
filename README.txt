{\rtf1\ansi\ansicpg1252\cocoartf1265\cocoasubrtf190
{\fonttbl\f0\fswiss\fcharset0 Helvetica;}
{\colortbl;\red255\green255\blue255;}
\margl1440\margr1440\vieww10800\viewh8400\viewkind0
\pard\tx720\tx1440\tx2160\tx2880\tx3600\tx4320\tx5040\tx5760\tx6480\tx7200\tx7920\tx8640\pardirnatural

\f0\fs24 \cf0 This needs a lot of work and actually doesn\'92t work yet. I was having a lot of trouble getting my array to properly adjust to input. I don\'92t plan on leaving it like this but I will need to come to office hours and discuss further but I want something to be submitted.\
\
As far as what this is SUPPOSED to be, I was trying to make a replica of the 2048 game that has been popular recently. I got a grid working and had the desired movement working when only one pieces was on the board. Each move would trigger another piece being created. For now this was only in one location but ultimately it will be randomly selected based on the open spaces in the array. Also, I was struggling to Destroy both objects when the pieces should combine. I suspect I will need to institute a collider and use the OnTriggerEnter(Collider other) method and then Destroy(other) as well as Destroy(this). to Instantiate(new piece). But I realized this far to late to make any progress ahead of the late deadline. \
\
Another problem I continue to have is updating the array, which I currently have working through a GetComponent line in each gamePiece\'92s movement script. I have this working with the first new object but a second movement doesn\'92t react properly. I suspect I may need to completely restructure this and iterate through the array displaying at each location the appropriate block. I have created empty gameObjects at each grid location named with their grid address location so I think it will be possible to simply assign a type of object at location of GameObject.Find(\'93*(x,y) coordinates*\'94). This will be a question that I will ask at office hours.\
\
}