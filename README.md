NBA Simple Score Viewer
===

## Table of Contents

[TOC]

## Guide

How to build and run the app

1. Navigate to ".\NBAScore\bin\Debug\net5.0"
2. Run the "NBAScore.exe" executable
3. Enjoy!

User flows
---
```sequence
User->NBAScore:open app
User->balldontlie API:DoGetTeams: query all teams
balldontlie API->NBAScore:returns JSON query
NBAScore-->User:show list of teams and date picker
User->NBAScore:EventArgs: selected team, date, and clicked search button
NBAScore->balldontlie API:GetGamesAsync: query selected games
balldontlie API->NBAScore:returns JSON query
NBAScore-->User: show the selected games on DataGrid
```

## Sources
1. [StackOverflow](https://stackoverflow.com/)
2. [Avalonia Documentation](http://reference.avaloniaui.net/)
3. [.NET Documentation](https://docs.microsoft.com/en-us/dotnet/?view=net-5.0)
4. Teachers



###### tags:`Documentation`
