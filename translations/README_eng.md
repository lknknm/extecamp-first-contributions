# Extecamp First Contributions

This project was created using [First Contributions](https://github.com/firstcontributions/first-contributions) as a starting point as well as Unicamp professor Rodrigo Bonacin's assignment with the objective of helping Extecamp Microsoft Technologies (Campinas State University) course students on Git version control, serving also as an exercise of maintaining a small GitHub repository.

Before you start, it's mandatory to install Git following the official documentation: https://git-scm.com/downloads or https://docs.github.com/en/get-started/quickstart/set-up-git

You might also need to [authenticate with GitHub from Git](https://docs.github.com/en/get-started/quickstart/set-up-git#authenticating-with-github-from-git)

## Forking a project
Open up the GitHub repository and make a Fork to your profile by cligking on the icon `Fork` at the top-right corner. This will copy this repository to your GitHub profile.
<br></br>
<img src="../assets/Fork.jpg" alt="git status" />

## Cloning the repository
<img align=right height="330" src="../assets/clone.jpg" alt="git status" />

Now you can clone the repository to your local machine. Open your account repository (the Fork you just created) and click on the dropdown menu `<> Code`. Copy that link:

After copying the code URL, execute the following Git command in a folder of your preference:

```shell
git clone <copied-url>
```
Alternatively, you can also use a SSH URL to clone the repository:
```shell
git clone git@github.com:this-is-you/first-contributions.git
```
Where `this-is-you` is your GitHub username.

## Creating a branch
Enter on your repository folder by executing the command `cd`:
```shell
cd extecamp-first-contributions
```
Now, create a branch using the command `git branch`:
```shell
git switch -c <your-branch-name>
```
For example:
```
git switch -c add-lucas-m
```

## Making changes in code 
Open up the C# file `HelloProject/hello.cs` inside a code editor of your like (VSCode, Vim, etc).
After the comment on the `line 21`, add a `Hello World` print where `<your-name>` is your name or GitHub username, for example:

```cs
Console.WriteLine("Hello world! My name is <seu-nome>");
```
Example:
```cs
Console.WriteLine("Hello world! My name is Lucas");
```
To verify the changes you've made, execute the command `git status`. 
Now, to stage your changes, run the command:
```shell
git add HelloProject/hello.cs
```
You can create a commit message with your changes to send it to a pull request:
```shell
git commit -m "Add <your-name> to Extecamp Contributors"
```

## Git Push
Now, for your changes to be live in the `main`(or `master`) branch, you'll need to `push` your local code to the remote repository. We'll then run the command:

```shell
git push -u origin <nome-de-sua-branch>
```
Where `<nome-de-sua-branch>` is the branch name you created earlier.

## Sending your changes through a Pull Request
In your GitHub repository you'll now find a tab called `Compare & Pull Request`
<img src="../assets/pullrequest.png" alt="git status" />
By clicking this button, you'll open up a window to submit your changes to the remote repository. This will show the comparison with the lines you added, changed or the files you inserted/removed.

<img src="../assets/p_request.jpg" alt="git status" />

After the pull request, it will be possible to verify and check the comparions of the lines changed, functions, files, etc.
<br></br>
<img src="../assets/pull_request_change.jpg" alt="git status" />

When your pull request is finally submitted, I can then `merge` your changes with the `main` branch and you'll be able to see your name on the project!

## Summarizing
Now you're familiar with the workflow using Git + Github as a remote repository. You can also follow the tutorials provided by [First Contributions](https://github.com/firstcontributions/first-contributions) -- which are the original source I used to build this tutorial -- to create your first commits and pull requests, as well as be able to contribute to [Open Source](https://github.com/open-source) projects!

## License
>MIT License. You can fork, copy, use, modify, and distribute this repository without restriction.