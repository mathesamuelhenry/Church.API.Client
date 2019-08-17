# Church.API.Client

MathSa01@BCTMATHSA02-WXL MINGW64 /c/git/Personal/Final
$ ls
Church.API/  Church.API.Client/  Church.API.Models/

MathSa01@BCTMATHSA02-WXL MINGW64 /c/git/Personal/Final
$ cd Church.API.Client/

MathSa01@BCTMATHSA02-WXL MINGW64 /c/git/Personal/Final/Church.API.Client
$ ls
ApiCallerBase.cs    ApiHelper.cs  Church.API.Client.csproj  obj/
ApiCallerMember.cs  bin/          Church.API.Client.sln

MathSa01@BCTMATHSA02-WXL MINGW64 /c/git/Personal/Final/Church.API.Client
$ git init
Initialized empty Git repository in C:/git/Personal/Final/Church.API.Client/.git/

MathSa01@BCTMATHSA02-WXL MINGW64 /c/git/Personal/Final/Church.API.Client (master)
$ git remote add origin https://github.com/mathesamuelhenry/Church.API.Client.git

MathSa01@BCTMATHSA02-WXL MINGW64 /c/git/Personal/Final/Church.API.Client (master)
$ git remote -v
origin  https://github.com/mathesamuelhenry/Church.API.Client.git (fetch)
origin  https://github.com/mathesamuelhenry/Church.API.Client.git (push)

MathSa01@BCTMATHSA02-WXL MINGW64 /c/git/Personal/Final/Church.API.Client (master)
$ git pull
remote: Enumerating objects: 4, done.
remote: Counting objects: 100% (4/4), done.
remote: Compressing objects: 100% (3/3), done.
remote: Total 4 (delta 0), reused 0 (delta 0), pack-reused 0
Unpacking objects: 100% (4/4), done.
From https://github.com/mathesamuelhenry/Church.API.Client
 * [new branch]      master     -> origin/master
There is no tracking information for the current branch.
Please specify which branch you want to merge with.
See git-pull(1) for details.

    git pull <remote> <branch>

If you wish to set tracking information for this branch you can do so with:

    git branch --set-upstream-to=origin/<branch> master


MathSa01@BCTMATHSA02-WXL MINGW64 /c/git/Personal/Final/Church.API.Client (master)
$ git pull
There is no tracking information for the current branch.
Please specify which branch you want to merge with.
See git-pull(1) for details.

    git pull <remote> <branch>

If you wish to set tracking information for this branch you can do so with:

    git branch --set-upstream-to=origin/<branch> master


MathSa01@BCTMATHSA02-WXL MINGW64 /c/git/Personal/Final/Church.API.Client (master)
$ git status
On branch master

No commits yet

Untracked files:
  (use "git add <file>..." to include in what will be committed)

        .vs/
        ApiCallerBase.cs
        ApiCallerMember.cs
        ApiHelper.cs
        Church.API.Client.csproj
        Church.API.Client.sln
        bin/
        obj/

nothing added to commit but untracked files present (use "git add" to track)

MathSa01@BCTMATHSA02-WXL MINGW64 /c/git/Personal/Final/Church.API.Client (master)
$ git log
fatal: your current branch 'master' does not have any commits yet

MathSa01@BCTMATHSA02-WXL MINGW64 /c/git/Personal/Final/Church.API.Client (master)
$ git pull https://github.com/mathesamuelhenry/Church.API.Client.git master
From https://github.com/mathesamuelhenry/Church.API.Client
 * branch            master     -> FETCH_HEAD

MathSa01@BCTMATHSA02-WXL MINGW64 /c/git/Personal/Final/Church.API.Client (master)
$ git status
On branch master
Untracked files:
  (use "git add <file>..." to include in what will be committed)

        ApiCallerBase.cs
        ApiCallerMember.cs
        ApiHelper.cs
        Church.API.Client.csproj
        Church.API.Client.sln

nothing added to commit but untracked files present (use "git add" to track)

MathSa01@BCTMATHSA02-WXL MINGW64 /c/git/Personal/Final/Church.API.Client (master)
$ git log
commit f3d8caddbce0e2f9ec1a31b93e319c9872d4a374 (HEAD -> master, origin/master)
Author: Samuel Henry <msamuelhenry@outlook.com>
Date:   Fri Aug 16 23:34:17 2019 -0400

    Initial commit

MathSa01@BCTMATHSA02-WXL MINGW64 /c/git/Personal/Final/Church.API.Client (master)
$ git pul
git: 'pul' is not a git command. See 'git --help'.

The most similar commands are
        pull
        push

MathSa01@BCTMATHSA02-WXL MINGW64 /c/git/Personal/Final/Church.API.Client (master)
$ git pull
There is no tracking information for the current branch.
Please specify which branch you want to merge with.
See git-pull(1) for details.

    git pull <remote> <branch>

If you wish to set tracking information for this branch you can do so with:

    git branch --set-upstream-to=origin/<branch> master


MathSa01@BCTMATHSA02-WXL MINGW64 /c/git/Personal/Final/Church.API.Client (master)
$ git status
On branch master
Untracked files:
  (use "git add <file>..." to include in what will be committed)

        ApiCallerBase.cs
        ApiCallerMember.cs
        ApiHelper.cs
        Church.API.Client.csproj
        Church.API.Client.sln

nothing added to commit but untracked files present (use "git add" to track)

MathSa01@BCTMATHSA02-WXL MINGW64 /c/git/Personal/Final/Church.API.Client (master)
$ git add .

MathSa01@BCTMATHSA02-WXL MINGW64 /c/git/Personal/Final/Church.API.Client (master)
$ git commit -m "initial commit of the API Client"
[master e2b2eea] initial commit of the API Client
 5 files changed, 150 insertions(+)
 create mode 100644 ApiCallerBase.cs
 create mode 100644 ApiCallerMember.cs
 create mode 100644 ApiHelper.cs
 create mode 100644 Church.API.Client.csproj
 create mode 100644 Church.API.Client.sln

MathSa01@BCTMATHSA02-WXL MINGW64 /c/git/Personal/Final/Church.API.Client (master)
$ git push
fatal: The current branch master has no upstream branch.
To push the current branch and set the remote as upstream, use

    git push --set-upstream origin master


MathSa01@BCTMATHSA02-WXL MINGW64 /c/git/Personal/Final/Church.API.Client (master)
$ git push --set-upstream origin master
Enumerating objects: 8, done.
Counting objects: 100% (8/8), done.
Delta compression using up to 12 threads
Compressing objects: 100% (7/7), done.
Writing objects: 100% (7/7), 2.19 KiB | 373.00 KiB/s, done.
Total 7 (delta 0), reused 0 (delta 0)
To https://github.com/mathesamuelhenry/Church.API.Client.git
   f3d8cad..e2b2eea  master -> master
Branch 'master' set up to track remote branch 'master' from 'origin'.
