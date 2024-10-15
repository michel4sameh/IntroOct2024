# Day 1 Review

Please address your current understanding of the following topics we covered (or began to cover) in class today. Your thoughts about these can and should be revised throughout the training (and your career!) as your understanding grows.

I am *not* looking for super "technical" stuff here. Just your ability to express and convey in your way your understanding of these things.

## 1. Git

We created a git repository on our VMs and added some existing code and committed it. We then used the `gh` cli tool to push that code to Github. 

- Say a few words about why *we* are using source control in this class?
We are using source control in this class to share changes in the code base and maybe 
restore the solution to a version that works if the current one is broken.
- Say a few words about how source control is used by teams of developers working on the same code base.
Source control is used in teams to share access to code for code reviews, and Devs working on one project. 
It is also used to push individual changes of many developers into one source and make sure it all works together coherently.
- What is meant when we say a copy of the repository is the "origin"? (That's our copy on github).
The origin is the main copy of the code base that pull changes from and push changes to.
- Why do we create commits locally?
That could serve as a checkpoint that you could return to, in case you introduce a 
new feature that breaks the program.

- Why do we push those commits to Github?
If we decide that the changes on the commit are safe, we push it to the 
Github for other people to see it and maybe can be pulled by someone else. 

### Extra Credit

What were the steps, as detailed as you like, that we took to create our repository and push it to Github.

What are some other ways you might do the same thing?

## 2. Services

We began a project in Visual Studio to create a service. What is meant by the term "Service" in software development?
It is a feature that provides some type of functionality and that can be provided to many apps, like user authentication.  
Our service exposes an *interface* that other applications can use to drive our service (make it do stuff). This is an
"Application Programming Interfact". How does an API differ from a "User Interface" (UI)? How are they similiar?

UI are features that are provided to users to be able to interact with the App. While an API is like a library that contains functions and capabilities 
that are not necessarily going to be seen by the user. It also manages the connections between app and database. 

What are some benefits of exposing a service's interface using the HTTP Protocol?
The biggest benefit of using HTTP Protocol is that it’s pretty unisversal between 
developers and it has a lot of support. We "tested" our API three different ways. 

1. Manually using SwaggerUI
2. Manually using the `.http` file functionality in Visual Studio
3. Automated using an xUnit test project.

Which is the *right* way to do it? Why give preference to automated tests? 

I thing using automated tests in a test project is the best way to go about it. 
It is better because you have access to tools that help with the testing such as 
the Assert class. A test solution also organizes the tests in one location. 
And you can use Test Explorer to run all or individual tests and see specific problem.   

### Extra Credit

Have you used any existing HTTP APIs in other projects?

Have you created any other HTTP APIs in your own work or studies?



