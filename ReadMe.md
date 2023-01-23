# OverView of the assignment

### Organized and easy-to-use interface
My tool is mostly meant as a User interface for the coder to organize all the scattered values in one place. The interface also allows for easy adjustments of the 
different values through simple sliders and is organized in sections by name. You can change the range of the variables in the code but due to
technical difficulties I wasn't able to make the change easier.

### Expanding on existing functionality
The health system of the game was both not connected between the ship's health variable and the UI value and unchangable.
I used scriptable objects to make a Max-health value that could be changed at will and added a object with a Monoscript that controlled and claculated 
the damaged health between the ship and the ingame-UI's health display.

### Ease of implimentation 
The whole tool is quite compact in the amount of scripts used and all you have to do is drag the calculations object into the scene and set up the code by the instructions
in the code to use the tool. The tool is also in one file that you can easliy be sent to someone else if need be.

# Benifits and limitations of scriptable objects

## Benifits
The first benifit of scriptable objects is how organized you can make your values in the project and easily they can be accesed from different areas of the project.
It can also an easy way to save values over play sessions if you wanted to keep the data of previous games since the values don't reset automaticly.


## Limitations
A big limitiation of the scriptable objects is that it only stores values. You can't change the values of the variables through code inside the script.
Luckily you can use seperate scripts to change adjust the values, but that makes you have to have an object in the scene that updates to be able to change the values
of the data which can make the preformance suffer if used to on a larger scale.
