# 4th-Year-Project
## Machine Learning Football Playing Agents
Final year project investigating Python's AI capabilities in a Unity3D environment

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

When the configuration panel pops up, simple click “Play!”.
(Note: if you are NOT using a graphics card it is recommended to lower the quality before running the environment)

If you would like to view the project working using the internal C# code, then simply open the Unity editor and run the “Soccer” scene. The C# code will control the agents and replicate what the neural network aimed to achieve.
