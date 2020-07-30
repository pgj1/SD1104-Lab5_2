LAB5.2: Enum Task List
Lesson Time: 30 Minutes

In this lab, we’re going to improve the task list system by using enums. 
This code will do the same thing as the code we wrote in the previous lesson, but it will use enums 
and lists instead of using arrays. The goal of this lab is to help you practice enums and to show you 
there is no one way to solve a problem.

Follow along on your own to the steps shown below to complete the lab.

1. Start by creating an enum. Remember that you must do this above the Main() code block. 
Trying to create this inside of it will give you an error. This enum will represent the days of the week.

2. Inside of the main code block, let’s create a list of strings to represent our list of task items.

3. Now, the next step is to loop through all of the values in the enum, offering the user a 
chance to assign a task to the day. To do this, we have to use a special function called Enum.GetValues(). 
This will get all of our values from our enum.
After getting each enum value & getting input from the user, we add the task to our list.

4. Finally, all that is left to do is print each task from the list.
Running the code, should give us output like this.

To view the solution, view the 5_2Labsolution project from our github page.
https://github.com/ACTWebDev/SD104/blob/master/5_2LabSolution/5_2LabSolution/Program.cs

