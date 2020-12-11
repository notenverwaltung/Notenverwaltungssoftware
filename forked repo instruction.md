# work with a forked repository
[from stackoverflow](https://stackoverflow.com/questions/7244321/how-do-i-update-a-github-forked-repository)


## with GitHub Online (dirty)
[stackoverflow-answer](https://stackoverflow.com/a/23853061/12543744)

1. Open your fork on GitHub.
2. Click on <kbd>Pull Requests</kbd>.
3. Click on <kbd>New Pull Request</kbd>. By default, GitHub will compare the original with your fork, and there shouldn't be anything to compare if you didn't make any changes.
4. Click <kbd>switching the base</kbd> if you see that link. Otherwise, manually set the <kbd>base fork</kbd> drop down to your fork, and the <kbd>head fork</kbd> to the upstream. Now GitHub will compare your fork with the original, and you should see all the latest changes.
5. <kbd>Create pull request</kbd> and assign a predictable name to your pull request (e.g., `Update from original`).
6. Scroll down to <kbd>Merge pull request</kbd>, but don't click anything yet.

Now you have three options, but each will lead to a less-than-clean commit history.

1. The default will create an ugly merge commit.
2. If you click the dropdown and choose <kbd>Squash and merge</kbd>, all intervening commits will be squashed into one. This is most often something you don't want.
3. If you click <kbd>Rebase and merge</kbd>, all commits will be made "with" you, the original PRs will link to your PR, and GitHub will display `This branch is X commits ahead, Y commits behind <original fork>`.

So yes, you can keep your repo updated with its upstream using the GitHub web UI, but doing so will sully your commit history.



## with git commands (clean)
[stackoverflow-answer](https://stackoverflow.com/questions/7244321/how-do-i-update-a-github-forked-repository/7244456#7244456)

### Add  remote

Add the remote, call it "upstream"

```
git remote add upstream https://github.com/notenverwaltung/Notenverwaltungssoftware.git
```

### Fetch

Fetch all the branches of that remote into remote-tracking branches

```
git fetch upstream
```

### checkout

Make sure that you're on your master branch

```
git checkout master
```

### rebase

Rewrite your master branch so that any commits of yours that aren't already in upstream/master are replayed on top of that other branch

```
git rebase upstream/master
```

### push

If you've rebased your branch onto upstream/master you may need to force the push in order to push it to your own forked repository on GitHub. You'd do that with:

You only need to use the -f the first time after you've rebased.

```
git push -f origin master
```
