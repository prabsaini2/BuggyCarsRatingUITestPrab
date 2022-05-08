# BuggyCarsRatingUITestPrab
This selenium based C# automation project caters to UI automation of different flows for the website : https://buggy.justtestit.org & its API's
## About the Project
This is a C# Specflow project: BuggyCarsRatingUiAutomation.

Test Approach document: https://github.com/prabsaini2/BuggyCarsRatingUITestPrab/blob/main/TestApproach_BuggyCarApp.docx
## Structure:

Solution has Few folders, each containing main classes. 

#### BASE: 

Containing UiBase class Which is parent Class for most of the classes in the project and helps to intialize the Webdriver.

#### Managers: 

Containing PageObjectManger class, the Page Object Manger is to create the page’s object and also to make sure that the same object should not be created again and again. But to use single object for all the step definition files.

#### PageObjects:

Containing Page classes (MainPage,RegistrationPage)

#### Features:

Containing SpecFlow Feature files (ApiTest, UserRegistration, ValidateSingleUserRegistration and ValidUserLogin).

#### StepDefinitions:

Containing all the step files for the features (ApiTest, UserRegistrationSteps, ValidateSingleUserRegistrationSteps and ValidUserLoginSteps).


![image](https://user-images.githubusercontent.com/68798285/167316640-14cfdadd-82b3-436c-9735-3f204310aa77.png)



Chromedriver is downloaded from : https://chromedriver.chromium.org/downloads

#### Note: Make sure the chromedriver version should be same as version of Chrome installed in your PC.

### Built With

i) IDE : visualStudio 2019.

ii) Used Selenium Packages for interacting with website.

iii) Used Page Object Model Pattern to structure code.

iv) Used SpecFlow for BDD approach.

v) Used Nunit framework.

vi) .Netframework 4.7.2

vii) RestSharp
## Installation

1) Clone the repo

```bash
  npm install my-project
  cd my-project
```

2) Install VisualStudio :

```bash
  https://visualstudio.microsoft.com/downloads/
```

3) Open the cloned repo in VisualStudio

4) Insatll extentions: Nunit3TestAdapter and Specflow for Visual Studio (year of VS installed)

5) NuGet should also be cloned with the code incase not please follow below screen shots.

![image](https://user-images.githubusercontent.com/68798285/167292096-3f865d4b-4202-45cd-9e8d-abcdedb4308d.png)
![image](https://user-images.githubusercontent.com/68798285/167292111-37daadef-a349-4e96-a849-f845929fdb91.png)



## Usage

Cleane and rebuild the project you should be able to see the tests in Test Explorer and you can run in indiviaually or all at once.

Note: For API Test its not completed as there are some issues with API Response.
After sending request the response says Activation required tried different approaches still was unsuccessfull. 

Result:
<img width="193" alt="Capture" src="https://user-images.githubusercontent.com/68798285/167292149-8bd9f76a-9717-4ef5-9ac8-701818e32ff7.PNG">


 Happy Testing. 
