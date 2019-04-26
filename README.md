# 4th-Year-Project
## Machine Learning Football Playing Agents

### Group Members
- Brian Doyle
- Ryan Conway
- James Kinsella

### Supervisors
- Gerard Harrison
- Daniel Cregg

---

### Introduction
This application is a simulation of agents moving independently in a 3D through a neural network developed using python. We plan to have these agents recognize the object around them in the environment and use these to their advantage. With this we hope to add some personalities to each of these agents so that they make decisions based on what position they are in, and what to prioritize when in certain situations. We also hope to implement a win condition so that the simulation stops after a certain amount of time has passed or a certain amount of goals have been scored by a single team or agent.

### Our Objectives
- Design a working 3D environment in Unity to best suit our needs.
- Find a way to connect Unity and Python together, allowing for data to be transferred between both the environment and the external code.
- Pass movements into the Unity environment using the external code.
- Pull observations from the Unity environment back into the external code.
- Control the agents using the external neural network.

## Design

![TechUsed]

### Scope
As this is a final year software development project, we felt that this idea would provide many learning outcomes associated with the scope at this level. We were encouraged to use technologies that were new to us so with little to no experience in both unity and python we felt our idea slotted right into this category. As the project developed further we dove into other possible technologies that would benefit our development and working environment.

### Learning Outcomes
- A better decision could have been made in terms of using ML-Agents, since the plugin is actually still in early beta.
- ML-Agents went from version 0.5 to version 0.6 in the midst of our development, and with it many aspects of how the plugin worked previously changed, this meant that all the documentation on the previous version was changed also.
- We made the decision to stick to version 0.5, but now looking back perhaps it would have been more benifical to upgrade and adapt the project to the newer 0.6.
- The documentation for ML-Agents wasn't actually as helpful as we originally thought, lots of pre-built examples exist, however an actual breakdown of what went into these examples does not.
- For any future development we may be involved in, versioning has clearly stated itself as being of utmost importance, for example, ML-Agents version 0.5 will only work with python 3, something that we were never made aware of in the ML-Agents documentation (ML-Agents 0.5 will not run with the latest version of ML-Agents, meaning ML-Agents 0.6 will not run any project developed in 0.5)}
- Hardware was an issue running the Unity environment after intense training simulations had taken place.
- Scrum Agile Methodology provided good structure to our development process, however mid way through development, with so many setbacks and subsequent blocking issues, the sprint schedule was effected in the later stages, messing with our overall time management.
- Despite the problems with using the Scrum Agile Methodology, it was still extremely helpful in our overall development of the project, and will follow us into industry in the future.
- GitHub has a limit to the size of file that can be uploaded, meaning that many of the ml-agents files could not be uploaded directly, as they exceeded the 100MB allowance.

---

### Installation Guide
Download and install Anaconda for Windows using the following link:
```
  https://www.anaconda.com/distribution/#windows
```
Once Anaconda is installed you will need to run Anaconda Navigator to finish the setup. 

After running Anaconda Navigator you can close it again. If environment variables were for some reason not created you will see error "conda is not recognized as internal or external command" when you type “conda” into the command line. To fix this type “environment variables” into the windows search bar, and You should see an option called “Edit the system environment variables”. From here click “Environment Variables” and double click “Path” under “System variable. Click “New” and add the following new paths:
```
  %UserProfile%\Anaconda3\Scripts
  %UserProfile%\Anaconda3\Scripts\conda.exe
  %UserProfile%\Anaconda3
  %UserProfile%\Anaconda3\python.exe
```
Once this is all done, open the new “Anaconda Prompt” from the windows search bar. Then type in the following command:
```
  conda create -n ml-agents python=3.6
```
If you are asked to install any new packages simple type “y” and press enter.

Now you’ll have to activate this new environment. In the same Anaconda Prompt type the following:
```	
  activate ml-agents
```
Finally lets install TensorFlow using the “pip” package manager in Anaconda. To do so type the following command from the same Anaconda Prompt:
```	
  pip install tensorflow==1.7.1
```
Now with all of that out of the way, we can move on to setting up the project files.
Begin by cloning the GitHub repository, this can be done from the command line using the following command:
```	
  git clone https://github.com/BrianD147/4th-Year-Project
```
Once the repo has been clones, you will need to retrieve the ML-Agents assets folder from the following Google Drive link:
```	
  https://drive.google.com/open?id=1mqoev-1K-7lDgqTIGWRbmnrZZCFxhKZY
```
This folder needs to be placed into the Assets folder of the project; this folder can be found here:
```	
  \4th-Year-Project\4th-Year-Project\Assets\
```
Now with the files set up, you can begin by running a notebook and observing the environment. Navigate to the 4th-Year-Project folder in the command line, and navigate into the notebooks folder using the following command:
```	
  cd notebooks
```
Then type the following to run Jupyter:
```	
  jupyter notebook
```
This will open a web browser, from here select the 10-Episode-Random.ipynb file, this is a notebook which will connect to the Unity environment and send random inputs to the agent. Press the “Restart the kernel and run all cells” option from the top of the window (the button is two arrows pointing to the right).

When the configuration panel pops up, simple click “Play!”

(Note: if you are NOT using a graphics card it is recommended to lower the quality before running the environment)

If you would like to view the project working using the internal C# code, then simply open the Unity editor and run the “Soccer” scene. The C# code will control the agents and replicate what the neural network aimed to achieve.

[TechUsed]: https://github.com/BrianD147/4th-Year-Project/blob/master/Project-Dissertation/img/TechUsed.png
